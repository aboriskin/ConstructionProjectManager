using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticAlgorithm.Core;
using GeneticAlgorithm.Exceptions;
using GeneticAlgorithm.Interfaces;

namespace GeneticAlgorithm.Managers
{
    class InitialPopulationGenerator<TGene>
    {
        private const int MaxIterationsCoef = 100;

        public InitialPopulationGenerator(
            IInitialChromosomeGenerator<TGene> chromosomeGenerator,
            IFitnessFunction<TGene> fitnessFunction)
        {
            _chromosomeGenerator = chromosomeGenerator;
            _fitnessFunction = fitnessFunction;
        }

        private readonly IInitialChromosomeGenerator<TGene> _chromosomeGenerator;
        private readonly IFitnessFunction<TGene> _fitnessFunction;

        public Population<TGene> GeneratePopulation(int populationSize)
        {
            var result = new Population<TGene>();

            var maxIterations = populationSize * MaxIterationsCoef;

            var currentIteration = 0;
            bool isValid;

            while (currentIteration < maxIterations &&
                result.Chromosomes.Count < populationSize)
            {
                var chromosome = _chromosomeGenerator.Generate();
                chromosome.FitnessFunctionValue = _fitnessFunction.Calculate(chromosome, out isValid);

                if (isValid)
                {
                    result.Chromosomes.Add(chromosome);                    
                }

                currentIteration++;
            }

            if (currentIteration == maxIterations)
            {
                throw new GeneticAlgorithmException("Cannot generate the initial population. It seems the data contains some circular dependencies. Please fix it and try one more time.");
            }

            return result;
        }
    }
}
