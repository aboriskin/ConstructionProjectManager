using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm.Exceptions
{
    public class GeneticAlgorithmException : Exception
    {
        public GeneticAlgorithmException(string message):
            base(message)
        {            
        }
    }
}
