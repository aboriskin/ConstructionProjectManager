using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticAlgorithm.Core;

namespace GeneticAlgorithm.Managers
{
    public class BestChromosomesKeeper<TGene>
    {
        public BestChromosomesKeeper(int amount)
        {
            _amount = amount;
            _bestResults = new List<BestResultDescription<TGene>>();
        }

        private readonly int _amount;
        private List<BestResultDescription<TGene>> _bestResults;

        public void Process(Population<TGene> population)
        {
            foreach (var chromosome in population.Chromosomes)
            {
                _bestResults.Add(GenerateBestResultDescription(population, chromosome));
            }

            _bestResults = _bestResults.OrderBy(r => r.FitnessFunctionValue).Take(_amount).ToList();
        }

        public List<BestResultDescription<TGene>> GetBestResults()
        {
            return _bestResults;            
        } 

        private static BestResultDescription<TGene> GenerateBestResultDescription(
            Population<TGene> population, 
            Chromosome<TGene> chromosome)
        {
            return new BestResultDescription<TGene>
            {
                Chromosome = chromosome,
                FitnessFunctionValue = chromosome.FitnessFunctionValue,
                Generation = population.Generation
            };
        }
    }
}
