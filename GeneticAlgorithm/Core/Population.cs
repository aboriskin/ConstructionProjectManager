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
    }
}
