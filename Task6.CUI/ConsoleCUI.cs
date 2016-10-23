using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task6.Logic;

namespace Task6.CUI
{
    class ConsoleCUI
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to StringManipulator testing program!");
            Console.WriteLine("Do you want to start?(y/n)");
            ConsoleKeyInfo ans = Console.ReadKey(true);
            Console.Clear();
            while (ans.Key == ConsoleKey.Y)
            {
                Console.WriteLine("Enter first string: ");
                string s1 = Console.ReadLine();
                Console.WriteLine("Enter second string: ");
                string s2 = Console.ReadLine();
                Console.WriteLine("ConcatUniqueAscending(s1, s2) = " +
                                    s1.ConcatUniqueAscending(s2));
                Console.WriteLine("ConcatUniqueAscending(s1, s1) = " +
                                    s1.ConcatUniqueAscending(s1));
                Console.WriteLine("ConcatUniqueAscending(s2, s2) = " +
                                    s2.ConcatUniqueAscending(s2));
                Console.WriteLine("Do you want to continue?(y/n)");
                ans = Console.ReadKey(true);
                Console.Clear();
            }
        }
    }
}
