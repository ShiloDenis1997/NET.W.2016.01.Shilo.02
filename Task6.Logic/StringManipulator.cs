using System;
using System.Linq;

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
        private const string Alphabet = "abcdefghijklmnopqrstuvwxyz";
        /// <summary>
        /// This method concats two strings, removes duplicate elements
        /// and sorts remaining elements ascending
        /// </summary>
        /// <param name="s1">first string to manipulate with</param>
        /// <param name="s2">second string to manipulate with</param>
        /// <returns>result string</returns>
        /// <exception cref="ArgumentException"> Throws when <paramref name="s1"/> 
        /// or <paramref name="s2"/> is
        /// empty or null.</exception>
        /// <exception cref="ArgumentIllegalCharactersException">Throws when
        /// <paramref name="s1"/> or <paramref name="s2"/> contains characters
        /// which are not in [a-z]</exception>
        public static string Longest(this string s1, string s2)
        {
            if (s1.IsNullOrEmpty())
                throw new ArgumentException
                    ($"{nameof(s1)} is empty or null");
            if (s2.IsNullOrEmpty())
                throw new ArgumentException
                    ($"{nameof(s2)} is empty or null");
            foreach (char c in s1)
            {
                if (!Alphabet.Contains(c))
                    throw new ArgumentIllegalCharactersException
                        ($"{nameof(s1)} containts characters which are not in [a-z]");
            }
            foreach (char c in s2)
            {
                if (!Alphabet.Contains(c))
                    throw new ArgumentIllegalCharactersException
                        ($"{nameof(s2)} containts characters which are not in [a-z]");
            }
            string s = s1 + s2;
            return new string(s.Intersect(Alphabet).OrderBy(c => c).ToArray());
        }
        
        private static bool IsNullOrEmpty(this string s)
        {
            return string.IsNullOrEmpty(s);
        }
    }
}
