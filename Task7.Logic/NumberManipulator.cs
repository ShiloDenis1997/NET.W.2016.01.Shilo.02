using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            int x1 = x;  
            for (int i = start, j = 0; i <= end; i++, j++)
            {
                x1 -= (x1 & (1 << i)); //reset bit in the x1
                x1 += (y & (1 << j)) << start; //add value of bit in the y
            }
            return x1;
        }
    }
}
