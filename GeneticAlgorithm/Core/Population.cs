using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm.Core
{
    public class Population<TGene>
    {
        public int Generation { get; private set; } = 1;
        public List<Chromosome<TGene>> Chromosomes { get; private set; } = new List<Chromosome<TGene>>();

        public Population<TGene> GenerateEmptyNext()
        {
            return new Population<TGene>() { Generation = this.Generation + 1 };
        }

        public void ReplacePair(
            Tuple<Chromosome<TGene>, Chromosome<TGene>> currentPair,
            Tuple<Chromosome<TGene>, Chromosome<TGene>> newPair)
        {
            Chromosomes.Remove(currentPair.Item1);
            Chromosomes.Remove(currentPair.Item2);
            Chromosomes.Add(newPair.Item1);
            Chromosomes.Add(newPair.Item2);
        }

        public void ReplaceChromosome(Chromosome<TGene> current, Chromosome<TGene> newChromosome)
        {
            var index = Chromosomes.IndexOf(current);
            Chromosomes[index] = newChromosome;            
        }

        private double? _averageFitnessValue;

        public double GetAverageFitnessValue()
        {
            if (_averageFitnessValue == null)
            {
                _averageFitnessValue = Chromosomes.Average(c => c.FitnessFunctionValue);
            }
            return _averageFitnessValue.Value;
        }
    }
}
