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
        public DateTime? FinishDate => StartDate?.AddDays(Math.Max(Duration - 1, 0));

        public void ClearCalculatedValues()
        {
            ActivityDayIndex = 0;
            StartDate = null;
        }

        public int GetActivityFinalIndex()
        {
            return ActivityDayIndex + Math.Max(Duration - 1, 0);
        }

        #endregion

        public bool Validate()
        {
            if (TimeConstraints.IsNullOrEmpty())
            {
                return true;
            }

            return TimeConstraints.All(c => c.Validate(this));
        }


        private Dictionary<int, decimal> _consumption = null;
        public Dictionary<int, decimal> GetResourceConsumption(List<Resource> resources)
        {
            if (_consumption == null)
            {
                _consumption = new Dictionary<int, decimal>();
                foreach (var resource in resources)
                {
                    var rcpd = ResourceConsumptionsPerDay.FirstOrDefault(r => r.ResourceId == resource.Id);
                    if (rcpd == null)
                    {
                        _consumption.Add(resource.Id, 0);                        
                    }
                    else
                    {
                        _consumption.Add(resource.Id, rcpd.Amount);
                    }
                }
            }
            return _consumption;
        } 
    }
}
