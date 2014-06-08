using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Linq;

namespace LinqTests
{
    /// <summary>
    /// Summary description for SinglesTests
    /// </summary>
    [TestClass]
    public class GettersTests
    {
        private readonly List<string> _namesList;
        private readonly List<double> _numbersList;

        public GettersTests() 
        {
            _namesList = GetNamesList();
            _numbersList = GetNumbersList();
        }
         
        #region SingleOrDefault Tests

        [TestMethod]
        public void SingleOrDefault_Parameterized_ReturnsValue()
        {
            // Arrange
            List<string> names = _namesList;
            
            // Act 
            string name = names.SingleOrDefault(x => x == "Mr Bean");

            // Assert
            Assert.IsNotNull(name);
            Assert.AreEqual(names[0], name);
        }

        [TestMethod]
        public void SingleOrDefault_Parameterized_ReturnsNull()
        {
            List<string> names = _namesList;

            string name = names.SingleOrDefault(x => x == "Steve Balmer");

            Assert.IsNull(name);
        }

        [TestMethod]
        public void SingleOrDefault_Parameterized_ReturnsZero()
        {
            List<double> numbers = _numbersList;

            double number = numbers.SingleOrDefault(x => x == 0.1);

            Assert.AreEqual(0, number);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void SingleOrDefault_Parameterized_ThrowExceptions()
        {
            List<string> names = new List<string>(0);

            string name = names.Single(x => x == "Bill Gates");
        }

        #endregion SingleOrDefault Tests

        #region Single Tests

        [TestMethod]
        public void Single_Parameterized_ReturnsValue()
        {
            List<string> names = _namesList;

            string name = names.Single(x => x == "Mr Bean");

            Assert.IsNotNull(name);
            Assert.AreEqual(names[0], name);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Single_Parameterized_ThrowExceptions()
        {
            List<string> names = _namesList;

            string name = names.Single(x => x == "Steve Balmer");
        } 

        #endregion Single Tests

        #region FirstOrDefault Tests

        [TestMethod]
        public void FirstOrDefault_Parameterized_ReturnsValue()
        {
            List<string> names = _namesList;
            names.Add("Chuck Norris");

            string firstName = names.FirstOrDefault(x => x == "Chuck Norris");

            Assert.IsNotNull(firstName);
            Assert.AreEqual("Chuck Norris", firstName);
        }

        [TestMethod]
        public void FirstOrDefault_Parameterized_ReturnsNull()
        {
            List<string> names = _namesList;

            string firstName = names.FirstOrDefault(x => x == "Pamela Anderson");

            Assert.IsNull(firstName);
        }

        [TestMethod]
        public void FirstOrDefault_NoParameters_ReturnValue()
        {
            List<string> names = _namesList;

            string firstName = names.FirstOrDefault();

            Assert.IsNotNull(firstName);
            Assert.AreEqual("Mr Bean", firstName);
        }

        [TestMethod]
        public void FirstOrDefault_NoParameters_ReturnNull()
        {
            List<string> emptyList = new List<string>(0);

            string empty = emptyList.FirstOrDefault();

            Assert.IsNull(empty);
        }

        #endregion FirstOrDefault Tests

        #region First Tests

        [TestMethod]
        public void First_Parameterized_ReturnsValue()
        {
            List<string> names = _namesList;
            names.Add("Chuck Norris");

            string firstName = names.First(x => x == "Chuck Norris");

            Assert.IsNotNull(firstName);
            Assert.AreEqual("Chuck Norris", firstName);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void First_ThrowException()
        {
            List<string> names = _namesList;

            string firstName = names.First(x => x == "Pamela Anderson");
        }

        [TestMethod]
        public void First_NoParameters_ReturnValue()
        {
            List<string> names = _namesList;
            names.Add("Mr Bean");

            string firstName = names.First();

            Assert.IsNotNull(firstName);
            Assert.AreEqual("Mr Bean", firstName);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void First_NoParameters_ThrowException()
        {
            List<string> emptyList = new List<string>(0);

            string empty = emptyList.First();
        }

        #endregion First Tests

        #region Private Methods

        private List<string> GetNamesList()
        {
            return new List<string> 
            {
                "Mr Bean",
                "Chuck Norris",
                "Jon Skeet",
                "Scott Hanselman",
                "Steve Jobs",
                "Linus Torvalds",
                "Bill Gates",
            };
        }

        private List<double> GetNumbersList()
        {
            return new List<double> 
            {
                1.0,
                1.1,
                2.0,
                3.0,
                3.5,
                4.0,
                4.5,
            };
        }

        #endregion Private Methods
    }
}
