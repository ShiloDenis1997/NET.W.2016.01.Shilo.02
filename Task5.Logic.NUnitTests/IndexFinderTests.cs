using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.Logic.NUnitTests
{
    [TestFixture]
    public class IndexFinderTests
    {
        [TestCase(new int[] { 1, 2, 3, 2, 1 }, 2,
            Description = "Center element test")]
        [TestCase(new int[] { 2, 0, 0 }, 0,
            Description = "Left boundary test")]
        [TestCase(new int[] { 0, 0, 5 }, 2,
            Description = "Right boundary test")]
        [TestCase(new int[] { 5, 5, 1, 2, 2}, 1,
            Description = "After first element test")]
        [TestCase(new int[] { 1, 2, 3, 4, 6 }, 3,
            Description = "Before last boundary test")]
        [TestCase(new int[] { 5 }, 0,
            Description = "One element test")]
        [TestCase(new int[] { 1, 2, 3, 4 }, -1,
            Description = "Even array without center element")]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, -1,
            Description = "Odd array without center element")]
        [TestCase(new int[] { -10, 20, -5, -15 }, 0,
            Description = "Array with negatives. Left boundary test")]
        [TestCase(new int[] { -20, 5, 10, -10, -20 }, 1,
            Description = "Array with negatives. After first element test")]
        [TestCase(new int[] { -15, -5, 20, -10 }, 3,
            Description = "Array with negatives. Right boundary")]
        [TestCase(new int[] { -20, -10, 10, 5, -20 }, 3,
            Description = "Array with negatives. Before last element test")]
        [TestCase(new int[] { -20, -10, -5, -10, -20 }, 2,
            Description = "Array with negatives. Center element test")]
        [TestCase(new int[] { -1, -2, -3, -4 }, -1,
            Description = "Even array with negatives without center element")]
        [TestCase(new int[] { -1, -2, -3 }, -1,
            Description = "Odd array with negatives without center element")]
        [TestCase(new int[] { -2 }, 0,
            Description = "One negative element test")]
        [TestCase(null, 0, ,
            Description = "Null array exception expected")]
        [Test]
        public void GetCenterIndex_Array_ExcpectedArg2
            (int[] array, int expected)
        {
            int actual;
            //act
            actual = IndexFinder.GetCenterIndex(array);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
