using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModels.Models.Constraints
{
    public class Constraint
    {
        public ConstraintActivityPointType PointType { get; set; }
        public ConstraintType ConstraintType { get; set; }
        public DateTime ConstraintDate { get; set; }

        public bool Validate(Activity activity)
        {
            if (PointType == ConstraintActivityPointType.Start)
            {
                return ValidatePoint(activity.StartDate);
            }

            return ValidatePoint(activity.FinishDate);
        }

        private bool ValidatePoint(DateTime? date)
        {
            if (date == null)
            {
                return true;
            }

            if (ConstraintType == ConstraintType.Earliest)
            {
                return ConstraintDate <= date;
            }

            return date <= ConstraintDate;
        }
    }
}
