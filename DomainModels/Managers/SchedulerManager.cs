using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModels.Helpers;
using DomainModels.Models;
using DomainModels.Models.Constraints;
using Utils.Extensions;

namespace DomainModels.Managers
{
    /// <summary>
    /// Build the schedule for the ordered list of activities based on the resource limitation
    /// </summary>
    public class SchedulerManager
    {
        public SchedulerManager(List<Resource> resources)
        {
            _resources = resources;
            _timelines = new Dictionary<int, ResourceConsumptionTimeline>();
        }

        private readonly List<Resource> _resources;
        private readonly Dictionary<int, ResourceConsumptionTimeline> _timelines;
        private DateTime? _startDate;

        public bool Schedule(List<Activity> orderedActivities)
        {
            InitializeTimelines();

            var activityMap = orderedActivities.ToDictionary(a => a.Id);

            foreach (var activity in orderedActivities)
            {
                if (!ScheduleActivity(activity, activityMap))
                    return false;

                ApplyTimeConstraintsAndSetAustronomicalDate(activity, orderedActivities);
            }

            return orderedActivities.All(a => a.Validate());
        }

        private void InitializeTimelines()
        {
            _startDate = null;
            _timelines.Clear();
            foreach (var resource in _resources)
            {
                _timelines.Add(resource.Id, new ResourceConsumptionTimeline(resource));
            }
        }

        private void ApplyTimeConstraintsAndSetAustronomicalDate(
            Activity activity,
            List<Activity> orderActivities)
        {
            if (_startDate != null)
            {
                activity.StartDate = _startDate.Value.AddDays(activity.ActivityDayIndex);
            }

            var earliestConstraints = activity.TimeConstraints.SafeWhere(c => c.ConstraintType == TimeConstraintType.Earliest).ToList();
            if (!earliestConstraints.IsNullOrEmpty())
            {
                var earliest = earliestConstraints.Min(c => c.ConstraintDate);

                if (_startDate == null)
                {
                    activity.StartDate = earliest;
                    _startDate = activity.StartDate.Value.AddDays(-activity.ActivityDayIndex);

                    SetStartDateForPreviousActivities(activity, orderActivities);                    
                }
                else
                {
                    if (activity.StartDate < earliest)
                    {
                        activity.StartDate = earliest;
                        activity.ActivityDayIndex = (int)(earliest - _startDate).Value.TotalDays;
                    }
                }    
            }
        }

        private static void SetStartDateForPreviousActivities(Activity activity, List<Activity> orderActivities)
        {
            int index = 0;
            while (orderActivities[index].Id != activity.Id)
            {
                var orderedActivity = orderActivities[index];
                orderedActivity.StartDate =
                    activity.StartDate.Value.AddDays(orderedActivity.ActivityDayIndex - activity.ActivityDayIndex);
                index++;
            }
        }

        private bool ScheduleActivity(
            Activity activity,
            Dictionary<int, Activity> activityMap)
        {
            var timeRangeAfterPreActivity = GetTimeRangeAfterPreActivity(activity, activityMap);

            var resourceConsumptionPerDay = activity.GetResourceConsumption(_resources);

            var availableTimeRange = FindAvailableRange(timeRangeAfterPreActivity, activity.Duration,
                resourceConsumptionPerDay);

            if (availableTimeRange == null)
            {
                return false;
            }

            ConsumeResources(availableTimeRange, resourceConsumptionPerDay);
            activity.ActivityDayIndex = availableTimeRange.StartIndex.Value;

            return true;
        }

        private void ConsumeResources(DateRange availableTimeRange, Dictionary<int, decimal> resourceConsumptionPerDay)
        {
            foreach (var resourceLine in _timelines.Values)
            {
                resourceLine.Consume(availableTimeRange, resourceConsumptionPerDay[resourceLine.ResourceId]);
            }
        }

        private DateRange GetTimeRangeAfterPreActivity(
            Activity activity,
            Dictionary<int, Activity> activityMap)
        {
            if (activity.PreActivityIds.IsNullOrEmpty())
            {
                return DateRange.Infinite();
            }

            var lastIndexFinish = activity.PreActivityIds.Max(
                id =>
                {
                    var preActivity = activityMap[id];
                    return preActivity.ActivityDayIndex + preActivity.Duration;
                });

            return new DateRange
            {
                StartIndex = lastIndexFinish // (lastIndexFinish, +inf) interval
            };
        }

        private DateRange FindAvailableRange(DateRange range, int duration, Dictionary<int, decimal> resouceConsumptionPerDay)
        {
            foreach (var index in range.Enumerate())
            {
                if (_timelines.All(t => t.Value.IsResourceAvailable(index, duration, resouceConsumptionPerDay[t.Key])))
                {
                    return new DateRange(index, index + duration - 1);
                }
            }

            return null;
        }
    }
}
