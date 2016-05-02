using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticAlgorithm.Core;

namespace GeneticAlgorithm.Interfaces
{
    public interface IMutationStrategy<TGene>
    {
        Chromosome<TGene> Do(Chromosome<TGene> chromosome, out bool mutated);
    }
}
