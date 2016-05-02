using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModels.Models;
using GeneticAlgorithm.Core;
using GeneticAlgorithm.Interfaces;
using Utils.Extensions;

namespace DomainModels.GeneticAlgorithm
{
    public class ChromosomeValidator : IChromosomeValidator<int>
    {
        public ChromosomeValidator(List<Activity> activities)
        {
            _activityMap = activities.ToDictionary(a => a.Id);
        }

        private readonly Dictionary<int, Activity> _activityMap; 

        public bool IsValid(Chromosome<int> chromosome)
        {
            for (int i = 0; i < chromosome.Genes.Count; i++)
            {
                var activityId = chromosome.Genes[i];
                var activity = _activityMap[activityId];

                if (activity.PreActivityIds.IsNullOrEmpty())
                {
                    continue;
                }

                foreach (var preActivityId in activity.PreActivityIds)
                {
                    var index = chromosome.Genes.IndexOf(preActivityId);
                    if (index > i)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
