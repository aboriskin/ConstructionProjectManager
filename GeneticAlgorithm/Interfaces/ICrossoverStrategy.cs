using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticAlgorithm.Core;

namespace GeneticAlgorithm.Interfaces
{
    public interface ICrossoverStrategy<TGene>
    {
        Tuple<Chromosome<TGene>, Chromosome<TGene>> Do(Chromosome<TGene> left, Chromosome<TGene> right);
    }
}
