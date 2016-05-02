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
    public class MutationStrategy<TGene> : IMutationStrategy<TGene>
    {
        public MutationStrategy(
            double probability)
        {
            _probability = probability;
        }

        private readonly double _probability;

        public Chromosome<TGene> Mutate(Chromosome<TGene> chromosome, out bool mutated)
        {
            var mutatedChromosome = chromosome;
            mutated = false;

            for (int i = 0; i < chromosome.Genes.Count - 1; i++)
            {
                if (RandomHelper.IsEventHappened(_probability))
                {
                    mutatedChromosome = GetMutatedChromosome(mutatedChromosome, mutatedIndex: i);
                    mutated = true;
                }
            }

            return mutatedChromosome;
        }

        private Chromosome<TGene> GetMutatedChromosome(Chromosome<TGene> chromosome, int mutatedIndex)
        {
            var result = new Chromosome<TGene>();

            for (int i = 0; i < mutatedIndex; i++)
            {
                result.Genes.Add(chromosome.Genes[i]);
            }

            result.Genes.Add(chromosome.Genes[mutatedIndex + 1]); //Permutate the genes
            result.Genes.Add(chromosome.Genes[mutatedIndex]);

            for (int i = mutatedIndex + 2; i < chromosome.Genes.Count; i++)
            {
                result.Genes.Add(chromosome.Genes[i]);
            }

            return result;
        }
    }
}
