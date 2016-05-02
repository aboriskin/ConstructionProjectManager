using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm.Core
{
    class Population<TGene>
    {
        public int Generation { get; private set; } = 1;
        public List<Chromosome<TGene>> Chromosomes { get; private set; } = new List<Chromosome<TGene>>();
    }
}
