using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModels.Models;
using GeneticAlgorithm.Core;
using GeneticAlgorithm.Interfaces;
using Utils;
using Utils.Extensions;

namespace DomainModels.GeneticAlgorithm
{
    /// <summary>
    /// Generates the initial chromosome that describes the priority of the resource allocation
    /// </summary>
    public class InitialChromosomeGenerator : IInitialChromosomeGenerator<int>
    {
        public InitialChromosomeGenerator(List<Activity> activities)
        {
            _activities = activities;
            _activityMap = activities.ToDictionary(a => a.Id);
        }

        private readonly List<Activity> _activities;
        private readonly Dictionary<int, Activity> _activityMap;

        public Chromosome<int> Generate()
        {
            var chromosome = new Chromosome<int>();
            var shuffledList = _activities.Shuffle();

            foreach (var item in shuffledList)
            {
                var minIndex = GetMinInsertIndex(chromosome, item);
                var maxIndex = GetMaxInsertIndex(chromosome, item);

                if (maxIndex < minIndex)
                {
                    return null; // This shuffle combination cannot produce the valid chromosome.
                }

                var index = RandomHelper.GetInt(minIndex, maxIndex);
                chromosome.Genes.Insert(index, item.Id);                
            }

            return chromosome;
        }

        private int GetMinInsertIndex(
            Chromosome<int> chromosome,
            Activity activity)
        {
            var preActivityIds = GetAllPreActivityIds(activity)
                .Where(id => chromosome.Genes.Contains(id)).ToList();

            if (preActivityIds.IsNullOrEmpty())
            {
                return 0;
            }

            return preActivityIds.Max(id => chromosome.Genes.IndexOf(id)) + 1;
        }

        private int GetMaxInsertIndex(
            Chromosome<int> chromosome,
            Activity activity)
        {
            var dependentActivityIds = GetAllPostActivityIds(activity);
            dependentActivityIds = dependentActivityIds.Where(id => chromosome.Genes.SafeContains(id)).ToList();

            if (dependentActivityIds.IsNullOrEmpty())
            {
                return chromosome.Genes.Count;
            }

            return dependentActivityIds.Min(id => chromosome.Genes.IndexOf(id));
        }

        private List<int> GetAllPreActivityIds(Activity activity)
        {
            var result = activity.PreActivityIds.ToList();

            if (!activity.PreActivityIds.IsNullOrEmpty())
            {
                foreach (var preActivityId in activity.PreActivityIds)
                {
                    var preActivity = _activityMap[preActivityId];
                    result.AddRange(GetAllPreActivityIds(preActivity));
                }
            }

            return result.Distinct().ToList();
        }

        private List<int> GetAllPostActivityIds(Activity activity)
        {
            var result = new List<int>();

            var dependingActivities = _activities.Where(a => a.PreActivityIds.SafeContains(activity.Id));
            foreach (var item in dependingActivities)
            {
                result.Add(item.Id);
                result.AddRange(GetAllPostActivityIds(item));
            }

            return result.Distinct().ToList();
        }
    }
}
