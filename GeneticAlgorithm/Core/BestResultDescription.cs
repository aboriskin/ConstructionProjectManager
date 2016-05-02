using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm.Core
{
    public class BestResultDescription<TGene>
    {
        public Chromosome<TGene> Chromosome { get; set; } 
        public int Generation { get; set; }
        public double FitnessFunctionValue { get; set; }
    }
}
