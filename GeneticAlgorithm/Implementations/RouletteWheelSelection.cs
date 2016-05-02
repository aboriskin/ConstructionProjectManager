using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticAlgorithm.Core;
using GeneticAlgorithm.Interfaces;
using Utils;

namespace GeneticAlgorithm.Implementations
{
    public class RouletteWheelSelection<TGene> : ISelectionStrategy<TGene>
    {        
        public Population<TGene> NextPopulation(Population<TGene> currentPopulation)
        {
            var nextPopulation = currentPopulation.GenerateEmptyNext();

            var rouletteWheel = new RouletteWheel<Chromosome<TGene>>();

            FillTheWheelWithOptions(currentPopulation, rouletteWheel);

            for (int i = 0; i < currentPopulation.Chromosomes.Count; i++)
            {
                nextPopulation.Chromosomes.Add(rouletteWheel.GetNext());
            }

            return nextPopulation;
        }

        private static void FillTheWheelWithOptions(Population<TGene> currentPopulation, RouletteWheel<Chromosome<TGene>> rouletteWheel)
        {
            var minValue = currentPopulation.Chromosomes.Min(c => c.FitnessFunctionValue);
            var maxValue = currentPopulation.Chromosomes.Max(c => c.FitnessFunctionValue);

            var dispersion = maxValue - minValue;

            foreach (var chromosome in currentPopulation.Chromosomes)
            {
                rouletteWheel.AddOption(chromosome, GetWheelNormalizedValue(maxValue, dispersion, chromosome));
            }
        }

        private static double GetWheelNormalizedValue(double maxValue, double dispersion, Chromosome<TGene> chromosome)
        {
            return maxValue +dispersion - chromosome.FitnessFunctionValue;
        }
    }
}
