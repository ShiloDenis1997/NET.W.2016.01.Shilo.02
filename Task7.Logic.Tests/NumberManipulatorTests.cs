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
