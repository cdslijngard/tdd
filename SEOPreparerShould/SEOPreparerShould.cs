using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SEO;

namespace SEOPreparerShould
{
    [TestClass]
    public class SEOPreparerShould
    {
        private SEOPreparer seoPreparer = new SEOPreparer();

        private void ShouldParseInto(string queryString, params String[] expected)
        {
            String[] result = seoPreparer.PrepareQuery(queryString);
            for (int i = 0; i < result.Count(); i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }

        [TestCategory("SEOTests"), TestMethod]
        public void ToLowerCase()
        {
            // Arrange
            String searchString = "TABLE";

            // Act
            String[] resultQuery = seoPreparer.PrepareQuery(searchString);

            // Assert
            Assert.AreEqual("table", resultQuery[0]);
        }

        [TestCategory("SEOTests"), TestMethod]
        public void RemoveWhiteSpace()
        {
            // Arrange
            String searchString = "chris     eats";

            // Act
            String[] resultQuery = seoPreparer.PrepareQuery(searchString);

            // Assert
            Assert.IsFalse(resultQuery.Contains(" "));
        }

        [TestCategory("SEOTests"), TestMethod]
        public void RemoveUnnecessaryWords()
        {
            // Arrange
            String searchString = "Marc likes this and this";

            // Act
            String[] resultQuery = seoPreparer.PrepareQuery(searchString);

            // Assert
            Assert.IsTrue(resultQuery.Length == 2);
        }

        [TestCategory("SEOTests"), TestMethod]
        public void RemoveDuplicates()
        {
            // Arrange
            String searchString = "so many many bugs";

            // Act & Assert
            ShouldParseInto(searchString, "so", "many", "bugs");
        }

        [TestCategory("SEOTests"), TestMethod]
        public void Singularize()
        {
            // Arrange
            String searchString = "tables footers headers";

            // Act & Assert
            ShouldParseInto(searchString, "table", "footer", "header");
        }





    }
}
