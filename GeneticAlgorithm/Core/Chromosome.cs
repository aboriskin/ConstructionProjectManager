using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm.Core
{
    public class Chromosome<TGene>        
    {
        public List<TGene> Genes { get; private set; } = new List<TGene>();

        public double FitnessFunctionValue { get; set; }
    }
}
