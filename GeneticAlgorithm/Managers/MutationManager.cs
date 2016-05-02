using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticAlgorithm.Core;
using GeneticAlgorithm.Interfaces;

namespace GeneticAlgorithm.Managers
{
    public class MutationManager<TGene>
    {
        private const int MaxMutationIterationsCount = 10;

        public MutationManager(
            IMutationStrategy<TGene> mutationStrategy,
            IFitnessFunction<TGene> fitnessFunction)
        {
            _mutationStrategy = mutationStrategy;
            _fitnessFunction = fitnessFunction;
        }

        private readonly IMutationStrategy<TGene> _mutationStrategy;
        private readonly IFitnessFunction<TGene> _fitnessFunction; 

        public void Perform(Population<TGene> population)
        {
            foreach (var chromosome in population.Chromosomes)
            {
                MutateChromosome(population, chromosome);
            }
        }

        private void MutateChromosome(
            Population<TGene> population, 
            Chromosome<TGene> chromosome)
        {
            var isValid = false;
            var iteration = 0;

            Chromosome<TGene> mutatedChromosome = null;

            while (iteration < MaxMutationIterationsCount && !isValid)
            {
                bool mutated;
                mutatedChromosome = _mutationStrategy.Mutate(chromosome, out mutated);

                if (mutated)
                {
                    mutatedChromosome.FitnessFunctionValue = _fitnessFunction.Calculate(mutatedChromosome, out isValid);
                }
                else
                {
                    isValid = true;
                    mutatedChromosome.FitnessFunctionValue = chromosome.FitnessFunctionValue;
                }

                iteration++;
            }

            if (isValid)
            {
                population.ReplaceChromosome(chromosome, mutatedChromosome);
            }
        }
    }
}
