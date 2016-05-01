using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModels.Models.Constraints
{
    public class Constraint
    {
        public Constraint(
            ConstraintActivityPointType pointType,
            ConstraintType constraintType,
            DateTime constraintDate)
        {
            PointType = pointType;
            ConstraintType = constraintType;
            ConstraintDate = constraintDate;
        }

        public ConstraintActivityPointType PointType { get; private set; }
        public ConstraintType ConstraintType { get; private set; }
        public DateTime ConstraintDate { get; private set; }

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
