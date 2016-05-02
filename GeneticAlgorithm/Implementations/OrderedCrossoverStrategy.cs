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
    public class OrderedCrossoverStrategy<TGene> : ICrossoverStrategy<TGene>
    {
        public OrderedCrossoverStrategy(double probability)
        {
            Probability = probability;
        }

        public double Probability { get; private set; }

        public Tuple<Chromosome<TGene>, Chromosome<TGene>> Cross(Chromosome<TGene> left, Chromosome<TGene> right)
        {
            var delimiterIndex = RandomHelper.GetInt(1, left.Genes.Count - 1);

            var item1 = Cross(left, right, delimiterIndex);
            var item2 = Cross(right, left, delimiterIndex);

            return new Tuple<Chromosome<TGene>, Chromosome<TGene>>(item1, item2);
        }

        private Chromosome<TGene> Cross(Chromosome<TGene> left, Chromosome<TGene> right, int delimiterIndex)
        {
            var result = new Chromosome<TGene>();
            var rightCopy = right.Genes.ToList();

            for (int i = 0; i < delimiterIndex; i++)
            {
                var leftGene = left.Genes[i];
                result.Genes.Add(leftGene);
                rightCopy.Remove(leftGene);
            }

            result.Genes.AddRange(rightCopy);
            return result;
        }

    }
}
