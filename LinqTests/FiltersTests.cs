using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Linq;

namespace LinqTests
{
    [TestClass]
    public class FiltersTests
    {
        private readonly List<KeyValuePair<int, string>> _names;

        public FiltersTests()
        {
            _names = GetNamesList();
        }

        #region Where Tests

        [TestMethod]
        public void Where_ReturnItems()
        {
            List<KeyValuePair<int, string>> names = _names;

            var filteredNames = (IList<KeyValuePair<int, string>>)names.Where(x => x.Key == 2);

            Assert.IsNotNull(filteredNames);
            Assert.AreEqual(2, filteredNames.Count);
            Assert.AreEqual("Megan Fox", filteredNames[0].Value);
            Assert.AreEqual("Mila Kunis", filteredNames[1].Value);
        }

        #endregion Where Tests

        #region Select Tests

        [TestMethod]
        public void Select_returnsItems()
        {
            List<KeyValuePair<int, string>> names = _names;

            var selectedNames = (IList<int>)names.Select(x => x.Key);

            Assert.IsNotNull(selectedNames);
            Assert.AreEqual(8, selectedNames.Count);
            Assert.AreEqual(1, selectedNames[0]);
        }

        #endregion Select Tests

        #region GroupBy Tests

        [TestMethod]
        public void GroupBy_Test()
        {
            List<KeyValuePair<int, string>> names = _names;

            var groupedNames = names.GroupBy(x => x.Key);

            Assert.IsNotNull(groupedNames);
            Assert.AreEqual(4, groupedNames.Count);
            Assert.AreEqual(3, groupedNames[1].Count);
        }

        #endregion GroupBy Tests

        private List<KeyValuePair<int, string>> GetNamesList()
        {
            return new List<KeyValuePair<int, string>>
            {
                new KeyValuePair<int, string>(1, "Angelina Jolie"),
                new KeyValuePair<int, string>(2, "Megan Fox"),
                new KeyValuePair<int, string>(3, "Kristen Bell"),
                new KeyValuePair<int, string>(3, "Scarlett Johansson"),
                new KeyValuePair<int, string>(4, "Charlize Theron"),
                new KeyValuePair<int, string>(2, "Mila Kunis"),
                new KeyValuePair<int, string>(1, "Kate Beckinsale"),
                new KeyValuePair<int, string>(1, "Milla Jovovich")
            };
        }
    }
}
