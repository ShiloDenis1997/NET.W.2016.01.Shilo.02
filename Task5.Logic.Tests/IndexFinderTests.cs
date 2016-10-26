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
            var testRow = ((string)TestContext.DataRow["Array"]);
            string[] source = testRow.Split(new char[] { ' ' }, 
                StringSplitOptions.RemoveEmptyEntries);
            int[] testArray;
            if (string.Compare(testRow, "") == 0)
                testArray = null;
            else
                testArray = Array.ConvertAll(source, (s) => int.Parse(s));
            int expected;
            bool parseResult = int.TryParse
                ((string)TestContext.DataRow["ExpectedResult"], out expected);
            string exceptionName = (string)TestContext.DataRow["Exception"];
            string comment = (string)TestContext.DataRow["Comment"];
            //Act
            try
            {
                int actual = IndexFinder.GetCenterIndex(testArray);
                //Assert
                if (parseResult)
                    Assert.AreEqual(expected, actual, comment);
                else
                    Assert.Fail("ExpectedResult has wrong value");
            }
            catch (AssertFailedException afex)
            {
                Assert.Fail($"{afex.Message}: {comment}");
            }
            catch (Exception ex)
            {
                if (string.Compare(ex.GetType().Name,exceptionName) == 0)
                    Assert.IsTrue(true);
                else
                    Assert.Fail($"{ex.GetType().Name}: {comment}");
            }            
        }
    }
}
