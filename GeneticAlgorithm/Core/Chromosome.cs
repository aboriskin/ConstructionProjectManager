using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm.Core
{
    public class Chromosome<TGene>        
    {
        public Chromosome(List<TGene> genes)
        {
            Genes = genes;
        }

        public List<TGene> Genes { get; private set; }
    }
}
