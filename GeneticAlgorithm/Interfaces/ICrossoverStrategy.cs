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
        double Probability { get; }

        Tuple<Chromosome<TGene>, Chromosome<TGene>> Cross(Chromosome<TGene> left, Chromosome<TGene> right);
    }
}
