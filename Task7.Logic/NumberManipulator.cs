using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7.Logic
{
    public static class NumberManipulator
    {
        public static int Insertion(this int x, int y, int start, int end)
        {
            int x1 = x;  
            for (int i = start; i <= end; i++)
            {
                x1 -= (x1 & (1 << i)); //reset bit in the x1
                x1 += (y & (1 << i)); //add value of bit in the y
            }
            return x1;
        }
    }
}
