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
            TimeConstraintActivityPointType pointType,
            TimeConstraintType constraintType,
            DateTime constraintDate)
        {
            PointType = pointType;
            ConstraintType = constraintType;
            ConstraintDate = constraintDate;
        }

        public TimeConstraintActivityPointType PointType { get; private set; }
        public TimeConstraintType ConstraintType { get; private set; }
        public DateTime ConstraintDate { get; private set; }

        public bool Validate(Activity activity)
        {
            if (PointType == TimeConstraintActivityPointType.Start)
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

            if (ConstraintType == TimeConstraintType.Earliest)
            {
                return ConstraintDate <= date;
            }

            return date <= ConstraintDate;
        }
    }
}
