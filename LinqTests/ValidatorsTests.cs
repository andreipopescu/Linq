using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Linq;

namespace LinqTests
{
    [TestClass]
    public class ValidatorsTests
    {
        [TestMethod]
        public void Any_NoParameters_ReturnsTrue()
        {
            List<int> numbers = GetNumbers();

            bool hasNumbers = numbers.Any();

            Assert.AreEqual(true, hasNumbers);
        }

        [TestMethod]
        public void Any_NoParameters_ReturnsFalse()
        {
            List<int> numbers = new List<int>(0);

            bool hasNumbers = numbers.Any();

            Assert.AreEqual(false, hasNumbers);
        }

        [TestMethod]
        public void AnyParameterized_ReturnsTrue()
        {
            List<int> numbers = GetNumbers();

            bool foundNumber = numbers.Any(x => x == 1);

            Assert.AreEqual(true, foundNumber);
        }

        private List<int> GetNumbers()
        {
            return new List<int>
            {
                1,2,3,4,5,6,7,8,9
            };
        }
    }
}
