using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6.Logic
{
    /// <summary>
    /// Class that represents methods to manipulate with strings
    /// </summary>
    public static class StringManipulator
    {
        /// <summary>
        /// const string variable containing alphabet
        /// </summary>
        private const string alphabet = "abcdefghijklmnopqrstuvwxyz";
        /// <summary>
        /// This method concats two strings, removes duplicate elements
        /// and sorts remaining elements ascending
        /// </summary>
        /// <param name="s1">first string to manipulate with</param>
        /// <param name="s2">second string to manipulate with</param>
        /// <returns>result string</returns>
        public static string Longest(this string s1, string s2)
        {
            string s = s1 + s2;
            return new string(s.Intersect(alphabet).OrderBy((c) => c).ToArray());
        }
    }
}
