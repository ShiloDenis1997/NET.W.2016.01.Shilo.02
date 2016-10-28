using System;
using NUnit.Framework;
using NUnitExtension;

namespace Task5.Logic.NUnitTests
{
    [TestFixture]
    public class IndexFinderTests
    {
        [TestCase(new[] { 1, 2, 3, 2, 1 }, 2,
            Description = "Center element test")]
        [TestCase(new[] { 2, 0, 0 }, 0,
            Description = "Left boundary test")]
        [TestCase(new[] { 0, 0, 5 }, 2,
            Description = "Right boundary test")]
        [TestCase(new[] { 5, 5, 1, 2, 2}, 1,
            Description = "After first element test")]
        [TestCase(new[] { 1, 2, 3, 4, 6 }, 3,
            Description = "Before last boundary test")]
        [TestCase(new[] { 5 }, 0,
            Description = "One element test")]
        [TestCase(new[] { 1, 2, 3, 4 }, -1,
            Description = "Even array without center element")]
        [TestCase(new[] { 1, 2, 3, 4, 5 }, -1,
            Description = "Odd array without center element")]
        [TestCase(new[] { -10, 20, -5, -15 }, 0,
            Description = "Array with negatives. Left boundary test")]
        [TestCase(new[] { -20, 5, 10, -10, -20 }, 1,
            Description = "Array with negatives. After first element test")]
        [TestCase(new[] { -15, -5, 20, -10 }, 3,
            Description = "Array with negatives. Right boundary")]
        [TestCase(new[] { -20, -10, 10, 5, -20 }, 3,
            Description = "Array with negatives. Before last element test")]
        [TestCase(new[] { -20, -10, -5, -10, -20 }, 2,
            Description = "Array with negatives. Center element test")]
        [TestCase(new[] { -1, -2, -3, -4 }, -1,
            Description = "Even array with negatives without center element")]
        [TestCase(new[] { -1, -2, -3 }, -1,
            Description = "Odd array with negatives without center element")]
        [TestCase(new[] { -2 }, 0,
            Description = "One negative element test")]
        [Test]
        public void GetCenterIndex_Array_ExcpectedArg2
            (int[] array, int expected)
        {
            //act
            int? actual = array.GetCenterIndex();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(null, Description = "Array null reference test")]
        [Test]
        public void GetCenterIndex_Null_ExcpectedArgumentNullException(int[] array)
        {
            Assert.Throws(typeof(ArgumentNullException), 
                () => { array.GetCenterIndex(); });
        }
    }
}
