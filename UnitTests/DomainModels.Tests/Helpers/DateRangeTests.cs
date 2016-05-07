using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModels.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DomainModels.Tests.Helpers
{
    [TestClass]
    public class DateRangeTests
    {
        [TestMethod]
        public void Test_001_Finite()
        {
            var range = new DateRange(0, 5);

            var list = range.Enumerate().ToList();
            Assert.AreEqual(6, list.Count());

            for (int i = 0; i <= 5; i++)
            {
                Assert.AreEqual(i, list[i]);
            }
        }

        [TestMethod]
        public void Test_002_Infinite()
        {
            var range = DateRange.Infinite();

            Assert.AreEqual(null, range.StartIndex);
            Assert.AreEqual(null, range.EndIndex);
        }
    }
}
