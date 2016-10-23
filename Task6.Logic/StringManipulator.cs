using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6.Logic
{
    public static class StringManipulator
    {
        private static string alphabet = "abcdefghijklmnopqrstuvwxyz";
        public static string ConcatUniqueAscending(this string s1, string s2)
        {
            string s = s1 + s2;
            return new string(s.Intersect(alphabet).OrderBy((c) => c).ToArray());
        }
    }
}
