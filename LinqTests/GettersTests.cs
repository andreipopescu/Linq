﻿using System;
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
        private TestContext _testContextInstance;
        private readonly List<string> _namesList;
        private readonly List<double> _numbersList;

        public GettersTests() 
        {
            _namesList = GetNamesList();
            _numbersList = GetNumbersList();
        }
         
        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return _testContextInstance;
            }
            set
            {
                _testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

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
