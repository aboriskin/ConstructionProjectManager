using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModels.Models.Constraints
{
    public class TimeConstraint
    {
        public TimeConstraint(
            TimeConstraintType constraintType,
            DateTime constraintDate)
        {
            ConstraintType = constraintType;
            ConstraintDate = constraintDate;
        }

        public TimeConstraintType ConstraintType { get; private set; }
        public DateTime ConstraintDate { get; private set; }

        public bool Validate(Activity activity)
        {
            return ValidatePoint(activity.StartDate);
        }

        private bool ValidatePoint(DateTime? date)
        {
            if (date == null)
            {
                return true;
            }

            if (ConstraintType == TimeConstraintType.Earliest)
            {
                return ConstraintDate <= date;
            }

            return date <= ConstraintDate;
        }
    }
}
