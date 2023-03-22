using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_C_Sharp.Assignments.Assignment5.Exercise11
{
    public static class ExternsionMethod
    {

        public static void IsEven(this int num)
        {
            Console.WriteLine(num % 2 == 0 ? "Yes" : "No");
        }

        public static void IsOdd(this int num)
        {
            Console.WriteLine(num % 2 == 0 ? "No" : "Yes");
        }

        public static void IsPrime(this int num)
        {
            if (num == 1)
            {
                Console.WriteLine("No");
            }
            else if (num == 2)
            {
                Console.WriteLine("Yes");
            }
            else
            {

                double boundry = Math.Floor(Math.Sqrt(num));

                for (int j = 2; j <= boundry; ++j)
                {
                    if ((num % j) == 0)
                    {
                        Console.WriteLine("No");
                        return;
                    }
                }

                Console.WriteLine("Yes");
            }

        }

        public static void IsDivisible(this int num)
        {
            Console.Write($"Enter a number to divide {num}: ");
            int divider = -1;
            if(!int.TryParse(Console.ReadLine(), out divider) || divider == 0)
            {
                Console.WriteLine("Enter a valid number");
            }
            else
            {
                Console.Write($"{num} is divisble by {divider}: ");
                Console.WriteLine(num % divider == 0 ? "Yes" : "No");
            }
        }
    }
}
