using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticAlgorithm.Core;
using GeneticAlgorithm.Interfaces;
using Utils.Logging;

namespace GeneticAlgorithm.Managers
{
    public class MutationManager<TGene>
    {
        private const int MaxMutationIterationsCount = 10;

        public MutationManager(
            IMutationStrategy<TGene> mutationStrategy,
            IFitnessFunction<TGene> fitnessFunction,
            IChromosomeValidator<TGene> chromosomeValidator)
        {
            _mutationStrategy = mutationStrategy;
            _fitnessFunction = fitnessFunction;
            _chromosomeValidator = chromosomeValidator;
        }

        private readonly IMutationStrategy<TGene> _mutationStrategy;
        private readonly IFitnessFunction<TGene> _fitnessFunction;
        private readonly IChromosomeValidator<TGene> _chromosomeValidator; 

        public void Perform(Population<TGene> population)
        {
            for (int i = 0; i < population.Chromosomes.Count; i++)
            {
                MutateChromosome(population, population.Chromosomes[i]);
            }
        }

        private void MutateChromosome(
            Population<TGene> population,
            Chromosome<TGene> chromosome)
        {
            var iteration = 0;
            bool mutated = false, isValid = false;

            Chromosome<TGene> mutatedChromosome = null;

            while (iteration < MaxMutationIterationsCount && !isValid)
            {
                mutatedChromosome = _mutationStrategy.Mutate(chromosome, out mutated);

                if (mutated)
                {
                    isValid = _chromosomeValidator.IsValid(mutatedChromosome);
                    if (isValid)
                    {
                        mutatedChromosome.FitnessFunctionValue = _fitnessFunction.Calculate(mutatedChromosome, out isValid);
                    }                    
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
                if (mutated)
                {
                    population.ReplaceChromosome(chromosome, mutatedChromosome);
                }
            }
            else
            {
                Logger.Log(String.Format("Mutation has been failed {0} times for the following item: {1}", MaxMutationIterationsCount, chromosome));
            }
        }
    }
}
