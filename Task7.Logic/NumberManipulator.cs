using System;

namespace Task7.Logic
{
    /// <summary>
    /// Class that represents methods to manipulate with numbers
    /// </summary>
    public static class NumberManipulator
    {
        /// <summary>
        /// Inserts <paramref name="y"/> in <paramref name="x"/>
        /// to the position from <paramref name="start"/> to <paramref name="end"/>
        /// </summary>
        /// <param name="x">Number in which to insert</param>
        /// <param name="y">Number which is inserting</param>
        /// <param name="start"> Start pos to insert from</param>
        /// <param name="end"> End pos to insert to</param>
        /// <returns>result number <paramref name="x"/> after insertion 
        /// of <paramref name="y"/></returns>
        /// <exception cref="ArgumentException">Throws when <paramref name="start"/>
        /// greater than <paramref name="end"/> or when <paramref name="end"/>
        /// greater than <paramref name="x"/> number of bits</exception>
        public static int Insertion(this int x, int y, int start, int end)
        {
            if (start > end)
                throw new ArgumentException("start > end");
            if (end >= sizeof(int) * 8)
                throw new ArgumentException($"end >= {sizeof(int) * 8}");
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
