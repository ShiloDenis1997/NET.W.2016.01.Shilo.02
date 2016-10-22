using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task5.Logic;

namespace Task5.CUI
{
    class ConsoleCUI
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to IndexFinder testing program!");
            Console.WriteLine("Do you want to start?(y/n)");
            ConsoleKeyInfo ans = Console.ReadKey(true);
            Console.Clear();
            while (ans.Key == ConsoleKey.Y)
            {
                Console.WriteLine("Enter array elements: ");
                string arrayLine = Console.ReadLine();
                string[] elements = arrayLine.Split(new string[] { " " },
                    StringSplitOptions.RemoveEmptyEntries);
                int[] array = new int[elements.Length];
                bool correct = true;
                for (int i = 0; i < array.Length; i++)
                {
                    if (!int.TryParse(elements[i], out array[i]))
                    {
                        correct = false;
                    }
                }
                if (!correct)
                {
                    Console.WriteLine("Incorrect input. Try again");
                    continue;
                }
                Console.WriteLine("Founded index is: " 
                    + IndexFinder.GetCenterIndex(array));
                Console.WriteLine("Do you want to continue?(y/n)");
                ans = Console.ReadKey(true);
                Console.Clear();
            }

        }
    }
}
