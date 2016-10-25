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
        public void GetCenterIndex_()
        {
            Debug.WriteLine(AppDomain.CurrentDomain.GetData("APPBASE"));
            //arrange
            //var source = TestContext.DataRow["Array"];
            int expected = Convert.ToInt32(TestContext.DataRow["ExpectedResult"]);
            //act
            int actual = IndexFinder.GetCenterIndex(new int[]{ 1, 2});
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
