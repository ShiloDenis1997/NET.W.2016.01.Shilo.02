using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace Task5.Logic.Tests
{
    [TestClass]
    public class IndexFinderTests
    {
        public TestContext TestContext { get; set; }

        [DataSource(
            "Microsoft.VisualStudio.TestTools.DataSource.XML",
            "|DataDirectory|\\TestCases.xml",
            "TestCase",
            DataAccessMethod.Sequential)]
        [DeploymentItem(@"Task5.Logic.Tests\TestCases.xml")]
        [TestMethod]
        public void GetCenterIndex_Array_ExpectedResultReturned()
        {
            //Arrange
            int[] testArray = ParseToArrayHelper
                ((string)TestContext.DataRow["Array"]);
            int? expected = ParseToNullableIntHelper
                ((string)TestContext.DataRow["ExpectedResult"]);
            string exceptionName = (string)TestContext.DataRow["Exception"];
            string comment = (string)TestContext.DataRow["Comment"];
            //Act
            int? actual = null;
            try
            {
                actual = testArray.GetCenterIndex();
            }
            catch (Exception ex)
            {
                if (string.CompareOrdinal(ex.GetType().Name, exceptionName) == 0)
                {
                    Assert.IsTrue(true);
                    return;
                }
                Assert.Fail($"{ex.GetType().Name}: {comment}");
            }
            Assert.AreEqual(expected, actual, comment);
        }

        private int? ParseToNullableIntHelper(string numberAsString)
        {
            if (string.CompareOrdinal(numberAsString, "null") == 0)
                return null;
            int ret;
            bool parseResult = int.TryParse
                (numberAsString, out ret);
            if (!parseResult)
                throw new Exception($"{nameof(numberAsString)} = {numberAsString} " +
                                $"isn't a string representation of nullable int.");
            return ret;
        }

        private int[] ParseToArrayHelper(string arrayAsString)
        {
            if (string.CompareOrdinal(arrayAsString, "null") == 0)
                return null;
            string[] source = arrayAsString.Split(new [] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);
           return Array.ConvertAll(source, int.Parse);
        }
    }
}
