using System;
using System.Collections.Generic;
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
    public class InitialChromosomeGenerator : IInitialChromosoneGenerator<int>
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

                var index = RandomHelper.GetRandomNumber(minIndex, maxIndex);
                chromosome.Genes.Insert(index, item.Id);
            }

            return chromosome;
        }

        private int GetMinInsertIndex(
            Chromosome<int> chromosome,
            Activity activity)
        {
            if (activity.PreActivityIds.IsNullOrEmpty() ||
                !chromosome.Genes.Any(id => activity.PreActivityIds.SafeContains(id)))
            {
                return 0;
            }

            return activity.PreActivityIds.Max(id => chromosome.Genes.IndexOf(id)) + 1;
        }

        private int GetMaxInsertIndex(
            Chromosome<int> chromosome,
            Activity activity)
        {
            var dependentActivityIds =
                chromosome.Genes.Where(id => _activityMap[id].PreActivityIds.SafeContains(activity.Id)).ToList();

            if (dependentActivityIds.IsNullOrEmpty())
            {
                return chromosome.Genes.Count;
            }

            return dependentActivityIds.Min(id => chromosome.Genes.IndexOf(id));
        }
    }
}
