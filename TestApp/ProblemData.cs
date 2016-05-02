using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModels.Models;
using DomainModels.Models.Constraints;

namespace TestApp
{
    class ProblemData
    {
        public List<Resource> Resources { get; set; }
        public List<Activity> Activities { get; set; }                  
    }
}
