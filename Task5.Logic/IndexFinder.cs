using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.Logic
{
    /// <summary>
    /// Class that represents methods to search items in the array
    /// </summary>
    public static class IndexFinder
    {
        /// <summary>
        /// Method finds array index 'i', for which sum of the
        /// elements from 0 to i - 1 is equal to the sum of the elements
        /// from i + 1 to array.Length - 1
        /// </summary>
        /// <param name="array">An array in which to search</param>
        /// <returns>Index of the found element of -1 if there is no 
        /// such element</returns>
        public static int GetCenterIndex(this int[] array)
        {
            long sum = 0;
            long leftSum = 0;
            foreach (int x in array)
                sum += x;
            for (int i = 0; i < array.Length; i++)
            {
                if (sum - leftSum - array[i] == leftSum)
                    return i;
                leftSum += array[i];
            }
            return -1;
        }
    }
}
