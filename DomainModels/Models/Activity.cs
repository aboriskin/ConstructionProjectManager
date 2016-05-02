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
        public string Name { get; set; }
        public List<int> PreActivityIds { get; set; }
        public int Duration { get; set; }
        public List<ResourceConsumptionPerDay> ResourceConsumptionsPerDay { get; set; }
        public List<TimeConstraint> TimeConstraints { get; set; }

        #region Calculated properties

        public int ActivityDayIndex { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? FinishDate => StartDate?.AddDays(Duration);

        #endregion

        public bool Validate()
        {
            if (TimeConstraints.IsNullOrEmpty())
            {
                return true;
            }

            return TimeConstraints.All(c => c.Validate(this));
        }

    }
}
