using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task7.Logic;

namespace Task7.CUI
{
    class ConsoleCUI
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to NumberManipulator testing program!");
            Console.WriteLine("Do you want to start?(y/n)");
            ConsoleKeyInfo ans = Console.ReadKey(true);
            Console.Clear();
            int x, y, start, end;
            while (ans.Key == ConsoleKey.Y)
            {
                Console.WriteLine("Enter first element: ");
                x = GetIntFromUser();
                Console.WriteLine("Enter second element: ");
                y = GetIntFromUser();
                Console.WriteLine("Enter start position: ");
                start = GetIntFromUser();
                Console.WriteLine("Enter end position: ");
                end = GetIntFromUser();
                Console.WriteLine(
                    $"Insertion({x}, {y}, {start}, {end}) = " + 
                        $"{x.Insertion(y, start, end)}");
                Console.WriteLine("Do you want to continue?(y/n)");
                ans = Console.ReadKey(true);
                Console.Clear();
            }
        }

        public static int GetIntFromUser()
        {
            int ret = 0;
            bool correct = false;
            while (!correct)
            {
                string userInputString = Console.ReadLine();
                if (!int.TryParse(userInputString, out ret))
                {
                    Console.WriteLine("Incorrect input. Try again: ");
                    continue;
                }
                correct = true;
            }
            return ret;
        }
    }
}
