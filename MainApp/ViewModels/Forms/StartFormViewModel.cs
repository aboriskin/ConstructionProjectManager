using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModels.Models;
using DomainModels.Models.Constraints;
using Newtonsoft.Json;
using Utils.Extensions;

namespace MainApp.ViewModels.Forms
{
    public class StartFormViewModel
    {
        public int NextActivityId { get; set; } = 1;
        public int NextResourceId { get; set; } = 1;

        public BindingList<ActivityViewModel> Activities { get; private set; } = new BindingList<ActivityViewModel>();
        public BindingList<ResourceViewModel> Resources { get; private set; } = new BindingList<ResourceViewModel>();

        #region Calculated fields
        [JsonIgnore]
        public Dictionary<int, ResourceViewModel> ResourceMap
        {
            get { return Resources.ToDictionary(r => r.Id); }
        }
        #endregion

        public ActivityViewModel CreateNewActivity()
        {
            var activity = new ActivityViewModel(this) { Id = NextActivityId++ };
            return activity;
        }

        public void AddActivity(ActivityViewModel activity)
        {
            Activities.Add(activity);
        }

        public void DeleteActivity(ActivityViewModel activity)
        {
            Activities.Remove(activity);

            foreach (var model in Activities)
            {
                model.DeletePreactivity(activity.Id);
            }
        }

        public void AddNewResource()
        {
            Resources.Add(new ResourceViewModel() { Id = NextResourceId++ });
        }

        public void RemoveResource(ResourceViewModel resource)
        {
            foreach (var activity in Activities)
            {
                activity.RemoveResource(resource);
            }

            Resources.Remove(resource);
        }

        public void SetInternalLinks()
        {
            foreach (var activity in Activities)
            {
                activity.SetStartForm(this);
            }
        }

        public string Validate()
        {
            if (Activities.IsNullOrEmpty() || Resources.IsNullOrEmpty())
            {
                return "Enter at least 1 resource and 1 activity for running the algorithm";
            }

            if (Activities.All(a => a.From == null))
            {
                return "There must be at least one 'X ≤ Start/Finish' condition";
            }

            foreach (var resource in Resources)
            {
                if (resource.LimitPerDay <= 0)
                {
                    return $"Resource with Id={resource.Id} should have positive limit";
                }
            }

            var actityIds = Activities.Select(a => a.Id).ToList();
            foreach (var activity in Activities)
            {
                if (activity.PreActivityIds.Any(id => !actityIds.Contains(id)))
                {
                    return $"Activity with Id={activity.Id} has a reference to the non-existing activity";
                }

                foreach (var activityResource in activity.Resources)
                {
                    if (activityResource.Amount > ResourceMap[activityResource.ResourceId].LimitPerDay)
                    {
                        return $"Activity with Id={activity.Id} consumes more resources than available";
                    }
                }
            }

            return null;
        }

        public List<Activity> GetDomainActivities()
        {
            return Activities.Select(a => a.ConvertToDomain()).ToList();
        }

        public List<Resource> GetDomainResources()
        {
            return Resources.Select(r => r.ConvertToDomain()).ToList();
        } 
        
    }
}
