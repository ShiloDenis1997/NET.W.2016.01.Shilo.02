using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Task6.Logic.Tests
{
    [TestFixture]
    public class StringManipulatorTests
    {
        [TestCase("abc", "def", "abcdef",
            Description = "Two strings only to concat")]
        [TestCase("aaabbc", "deefff", "abcdef",
            Description = "Two strings with not unique" +
            " elements and without intersection")]
        [TestCase("abcd", "cdef", "abcdef",
            Description = "Two strings with intersection")]
        [TestCase("dcbaa", "ghhdc", "abcdgh",
            Description = "Two strings to sort, concat and get unique")]
        [TestCase("abcdsafdefghijkasflmnaosdijqweopqrstuvwxyz",
            "abcasfdesdffsgdfhijklfmnopgqhrsteuvwxyassfaz",
            "abcdefghijklmnopqrstuvwxyz",
            Description = "Full alphabet test")]
        [TestCase("","","",
            Description = "Empty strings test")]
        [TestCase(null, "aabbbcdd", "abcd",
            Description = "null + string test")]
        [TestCase("abcabcabbab", null, "abc",
            Description = "string + null test")]
        [TestCase(null, null, "",
            Description = "null + null test")]
        [Test]
        public void Longest_Str1Str2_ExpectedReturn
            (string str1, string str2, string expected)
        {
            //act
            string actual = str1.Longest(str2);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
