using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm.Core
{
    public class GeneticAlgorithm<TGene>
    {
        public GeneticAlgorithm(
            int populationSize,
            double crossoverProbability,
            double mutationProbability)
        {
            _populationSize = populationSize;
            _crossoverProbability = crossoverProbability;
            _mutationProbability = mutationProbability;
        }

        private readonly int _populationSize;
        private readonly double _crossoverProbability;
        private readonly double _mutationProbability;


    }
}
