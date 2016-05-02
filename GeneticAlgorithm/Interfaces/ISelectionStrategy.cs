using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticAlgorithm.Core;

namespace GeneticAlgorithm.Interfaces
{
    public interface ISelectionStrategy<TGene>
    {
        Population<TGene> NextPopulation(Population<TGene> currentPopulation);
    }
}
