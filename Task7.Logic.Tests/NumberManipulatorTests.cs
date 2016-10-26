using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Task7.Logic.Tests
{
    [TestFixture]
    public class NumberManipulatorTests
    {
        [TestCase(8, 15, 0 ,0, 9,
            Description = "Single pos zero bit insertion test")]
        [TestCase(0, 15, 30, 30, 1073741824,
            Description = "Single pos 30 bit insertion test")]
        [TestCase(0, 15, 0, 30, 15,
            Description = "First 30 bits insertion test")]
        [TestCase(15, -15, 0, 4, 17,
            Description = "Negative number insertion test")]
        [TestCase(15, int.MaxValue, 3, 5, 63,
            Description = "int.MaxValue insertion test")]
        [TestCase(0, 1, 31, 31, int.MinValue,
            Description = "Insert 1 to sign bit test")]
        [TestCase(0, int.MinValue, 0, 31, int.MinValue,
            Description = "Insert full int.MinValue test")]
        [Test]
        public void Insertion_drivenData_ExpectedReturn
            (int x, int y, int start, int end, int expected)
        {
            //act
            int actual = x.Insertion(y, start, end);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
