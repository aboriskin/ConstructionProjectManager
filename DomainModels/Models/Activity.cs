using System;
using System.Collections.Generic;
using System.Linq;
using DomainModels.Models.Constraints;
using Utils.Extensions;

namespace DomainModels.Models
{
    public class Activity
    {
        public int Id { get; set; }
        public List<int> PreActivityIds { get; set; }
        public int Duration { get; set; }
        public List<ResourceConsumption> ResourceConsumptions { get; set; }
        public List<Constraint> Constraints { get; set; }

        #region Calculated properties

        public int ActivityIndex { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? FinishDate => StartDate?.AddDays(Duration);

        #endregion

        public bool Validate()
        {
            if (Constraints.IsNullOrEmpty())
            {
                return true;
            }

            return Constraints.All(c => c.Validate(this));
        }

    }
}
