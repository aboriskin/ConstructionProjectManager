using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using GeneticAlgorithm.Core;
using GeneticAlgorithm.Interfaces;
using Utils;
using Utils.Extensions;

namespace GeneticAlgorithm.Managers
{
    class CrossoverManager<TGene>
    {
        private const int MaxCrossoverIterationsCount = 10;

        public CrossoverManager(
            ICrossoverStrategy<TGene> crossoverStrategy,
            IFitnessFunction<TGene> fitnessFunction)
        {
            _crossoverStrategy = crossoverStrategy;
            _fitnessFunction = fitnessFunction;
        }

        private readonly ICrossoverStrategy<TGene> _crossoverStrategy;
        private readonly IFitnessFunction<TGene> _fitnessFunction;

        public void Perform(Population<TGene> population)
        {
            var pairs = GeneratePairs(population);

            foreach (var pair in pairs)
            {
                bool item1Valid = false, item2Valid = false;
                int iteration = 0;

                Tuple<Chromosome<TGene>, Chromosome<TGene>> newPair = null;

                while (iteration < MaxCrossoverIterationsCount
                    && !item1Valid && !item2Valid)
                {
                    newPair = _crossoverStrategy.Do(pair.Item1, pair.Item2);
                    newPair.Item1.FitnessFunctionValue = _fitnessFunction.Calculate(newPair.Item1, out item1Valid);
                    newPair.Item2.FitnessFunctionValue = _fitnessFunction.Calculate(newPair.Item2, out item2Valid);

                    iteration++;
                }

                if (item1Valid && item2Valid)
                {
                    population.ReplacePair(pair, newPair);
                }                
            }            
        }

        private List<Tuple<Chromosome<TGene>, Chromosome<TGene>>> GeneratePairs(Population<TGene> population)
        {
            var crossoverList = new List<Chromosome<TGene>>();

            foreach (var chromosome in population.Chromosomes.Shuffle())
            {
                if (RandomHelper.IsEventHappened(_crossoverStrategy.Probability))
                {
                    crossoverList.Add(chromosome);
                }
            }

            var result = new List<Tuple<Chromosome<TGene>, Chromosome<TGene>>>();
            for (int i = 0; i < crossoverList.Count / 2; i++)
            {
                result.Add(new Tuple<Chromosome<TGene>, Chromosome<TGene>>(crossoverList[2 * i], crossoverList[2 * i + 1]));
            }

            return result;
        }
    }
}
