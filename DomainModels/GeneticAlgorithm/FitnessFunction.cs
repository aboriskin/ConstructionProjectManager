using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModels.Managers;
using DomainModels.Models;
using GeneticAlgorithm.Core;
using GeneticAlgorithm.Interfaces;

namespace DomainModels.GeneticAlgorithm
{
    public class FitnessFunction : IFitnessFunction<int>
    {
        public FitnessFunction(
            List<Resource> resources,
            List<Activity> activities)
        {
            _resources = resources;
            _activities = activities;
            _activityMap = activities.ToDictionary(a => a.Id);
            _schedulerManager = new SchedulerManager(_resources);
        }

        private readonly List<Resource> _resources;
        private readonly List<Activity> _activities;
        private readonly Dictionary<int, Activity> _activityMap;
        private readonly SchedulerManager _schedulerManager;

        public double Calculate(Chromosome<int> chromosome, out bool isValid)
        {
            ClearCalculatedActivityValues();

            var orderedActivities = FormOrderedActivities(chromosome);

            isValid = _schedulerManager.Schedule(orderedActivities);
            return orderedActivities.Max(a => a.ActivityDayIndex + a.Duration);
        }

        private List<Activity> FormOrderedActivities(Chromosome<int> chromosome)
        {
            var orderedActivities = new List<Activity>();
            foreach (var activityId in chromosome.Genes)
            {
                orderedActivities.Add(_activityMap[activityId]);
            }
            return orderedActivities;
        }

        private void ClearCalculatedActivityValues()
        {
            foreach (var activity in _activities)
            {
                activity.ClearCalculatedValues();
            }
        }        
    }
}
