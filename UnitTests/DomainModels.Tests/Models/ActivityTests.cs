using System;
using System.Collections.Generic;
using DomainModels.Models;
using DomainModels.Models.Constraints;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DomainModels.Tests.Models
{
    [TestClass]
    public class ActivityTests
    {
        private readonly DateTime _fixedDatePoint = new DateTime(2016, 01, 01);

        [TestMethod]
        public void Test_001_Validate_Empty()
        {
            var activity = new Activity();
            var result = activity.Validate();

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test_002_Start_Earliest_Valid()
        {
            var activity = new Activity
            {
                StartDate = _fixedDatePoint,
                TimeConstraints = new List<TimeConstraint>
                {
                    new TimeConstraint(TimeConstraintActivityPointType.Start, TimeConstraintType.Earliest, _fixedDatePoint.AddDays(-1))
                }
            };
            var result = activity.Validate();

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test_003_Start_Earliest_Valid()
        {
            var activity = new Activity
            {
                StartDate = _fixedDatePoint,
                TimeConstraints = new List<TimeConstraint>
                {
                    new TimeConstraint(TimeConstraintActivityPointType.Start, TimeConstraintType.Earliest, _fixedDatePoint)
                }
            };
            var result = activity.Validate();

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test_004_Start_Earliest_Invalid()
        {
            var activity = new Activity
            {
                StartDate = _fixedDatePoint,
                TimeConstraints = new List<TimeConstraint>
                {
                    new TimeConstraint(TimeConstraintActivityPointType.Start, TimeConstraintType.Earliest, _fixedDatePoint.AddDays(1))
                }
            };
            var result = activity.Validate();

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Test_005_Start_Latest_Valid()
        {
            var activity = new Activity
            {
                StartDate = _fixedDatePoint,
                TimeConstraints = new List<TimeConstraint>
                {
                    new TimeConstraint(TimeConstraintActivityPointType.Start, TimeConstraintType.Latest, _fixedDatePoint.AddDays(1))
                }
            };
            var result = activity.Validate();

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test_006_Start_Latest_Valid()
        {
            var activity = new Activity
            {
                StartDate = _fixedDatePoint,
                TimeConstraints = new List<TimeConstraint>
                {
                    new TimeConstraint(TimeConstraintActivityPointType.Start, TimeConstraintType.Latest, _fixedDatePoint)
                }
            };
            var result = activity.Validate();

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test_007_Start_Latest_Invalid()
        {
            var activity = new Activity
            {
                StartDate = _fixedDatePoint,
                TimeConstraints = new List<TimeConstraint>
                {
                    new TimeConstraint(TimeConstraintActivityPointType.Start, TimeConstraintType.Latest, _fixedDatePoint.AddDays(-1))
                }
            };
            var result = activity.Validate();

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Test_008_Finish_Earliest_Valid()
        {
            var activity = new Activity
            {
                StartDate = _fixedDatePoint,
                Duration = 2,
                TimeConstraints = new List<TimeConstraint>
                {
                    new TimeConstraint(TimeConstraintActivityPointType.Finish, TimeConstraintType.Earliest, _fixedDatePoint.AddDays(1))
                }
            };
            var result = activity.Validate();

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test_009_Finish_Earliest_Valid()
        {
            var activity = new Activity
            {
                StartDate = _fixedDatePoint,
                Duration = 2,
                TimeConstraints = new List<TimeConstraint>
                {
                    new TimeConstraint(TimeConstraintActivityPointType.Finish, TimeConstraintType.Earliest, _fixedDatePoint.AddDays(2))
                }
            };
            var result = activity.Validate();

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test_010_Finish_Earliest_Invalid()
        {
            var activity = new Activity
            {
                StartDate = _fixedDatePoint,
                Duration = 2,
                TimeConstraints = new List<TimeConstraint>
                {
                    new TimeConstraint(TimeConstraintActivityPointType.Finish, TimeConstraintType.Earliest, _fixedDatePoint.AddDays(3))
                }
            };
            var result = activity.Validate();

            Assert.AreEqual(false, result);
        }


        [TestMethod]
        public void Test_011_Finish_Latest_Valid()
        {
            var activity = new Activity
            {
                StartDate = _fixedDatePoint,
                Duration = 2,
                TimeConstraints = new List<TimeConstraint>
                {
                    new TimeConstraint(TimeConstraintActivityPointType.Finish, TimeConstraintType.Latest, _fixedDatePoint.AddDays(3))
                }
            };
            var result = activity.Validate();

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test_012_Finish_Latest_Valid()
        {
            var activity = new Activity
            {
                StartDate = _fixedDatePoint,
                Duration = 2,
                TimeConstraints = new List<TimeConstraint>
                {
                    new TimeConstraint(TimeConstraintActivityPointType.Finish, TimeConstraintType.Latest, _fixedDatePoint.AddDays(2))
                }
            };
            var result = activity.Validate();

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Test_013_Finish_Latest_Invalid()
        {
            var activity = new Activity
            {
                StartDate = _fixedDatePoint,
                Duration = 2,
                TimeConstraints = new List<TimeConstraint>
                {
                    new TimeConstraint(TimeConstraintActivityPointType.Finish, TimeConstraintType.Latest, _fixedDatePoint.AddDays(1))
                }
            };
            var result = activity.Validate();

            Assert.AreEqual(false, result);
        }
    }
}
