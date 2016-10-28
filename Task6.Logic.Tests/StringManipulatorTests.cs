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
        [Test]
        public void Longest_Str1Str2_ExpectedReturn
            (string str1, string str2, string expected)
        {
            //act
            string actual = str1.Longest(str2);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("", "", typeof(ArgumentException),
             Description = "Empty strings test")]
        [TestCase(null, null, typeof(ArgumentException),
             Description = "null + null test")]
        [TestCase(null, "aabbbcdd", typeof(ArgumentException),
            Description = "null + string test")]
        [TestCase("abcabcabbab", null, typeof(ArgumentException),
            Description = "string + null test")]
        [TestCase("1kj2h3ksld", "laksfj", typeof(ArgumentIllegalCharactersException),
            Description = "First string contains illegal characters")]
        [TestCase("ashflk", "12jk3h24kj", typeof(ArgumentIllegalCharactersException),
            Description = "Second string contains illegal characters")]
        [TestCase(";;'fd", "dfj'k,", typeof(ArgumentIllegalCharactersException),
            Description = "Both strings contain illegal characters")]
        [Test]
        public void Longest_Str1Str2_ExceptionExpected
            (string s1, string s2, Type expectedExceptionType)
        {
            Assert.Throws(expectedExceptionType, () => s1.Longest(s2));
        }
    }
}
