﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticAlgorithm.Core;

namespace GeneticAlgorithm.Interfaces
{
    public interface IChromosomeValidator<TGene>
    {
        bool IsValid(Chromosome<TGene> chromosome);
    }
}
