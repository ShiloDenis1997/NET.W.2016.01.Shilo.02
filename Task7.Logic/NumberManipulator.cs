using System;
using System.CodeDom;

namespace Task7.Logic
{
    /// <summary>
    /// Class that represents methods to manipulate with numbers
    /// </summary>
    public static class NumberManipulator
    {
        /// <summary>
        /// Inserts y in x. As result takes the position from start to end
        /// </summary>
        /// <param name="x">Number in which to insert</param>
        /// <param name="y">Number which is inserting</param>
        /// <param name="start"> Start pos to insert from</param>
        /// <param name="end"> End pos to insert to</param>
        /// <returns></returns>
        public static int Insertion(this int x, int y, int start, int end)
        {
            if (start > end)
                throw new ArgumentException("start > end");
            if (end > 31)
                throw new ArgumentException("end > 31");
            uint x1 = (uint)x;
            uint mask = ((uint)(((long)1 << end - start + 1) - 1));
            uint insertion = ((uint)y) & mask;
            insertion <<= start;
            mask <<= start;
            x1 -= x1 & mask;
            x1 |= insertion;
            return (int)x1;
        }
    }
}
