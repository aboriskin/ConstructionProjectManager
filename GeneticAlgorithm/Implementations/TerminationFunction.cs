using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticAlgorithm.Core;
using GeneticAlgorithm.Interfaces;
using Utils.Extensions;

namespace GeneticAlgorithm.Implementations
{
    public class TerminationFunction<TGene> : ITerminationFunction<TGene>
    {
        private const double Eps = 1e-3;

        public TerminationFunction(
            int generationLimit)
        {
            _generationLimit = generationLimit;
            _rangeSizeToCheckFitnessValue = generationLimit / 2;
        }

        private readonly int _generationLimit;
        private readonly int _rangeSizeToCheckFitnessValue;

        public bool ShouldTerminate(
            Population<TGene> currentPopulation, 
            List<Population<TGene>> allPopulations)
        {
            if (currentPopulation.Generation >= _generationLimit)
            {
                return true;
            }

            if (allPopulations.Count < _rangeSizeToCheckFitnessValue)
            {
                return false;
            }

            var avgPrevResult = allPopulations.GetLastN(_rangeSizeToCheckFitnessValue).Average(p => p.GetAverageFitnessValue());
            return avgPrevResult - Eps < currentPopulation.GetAverageFitnessValue(); //If the results do not become significantly better
        }
    }
}
