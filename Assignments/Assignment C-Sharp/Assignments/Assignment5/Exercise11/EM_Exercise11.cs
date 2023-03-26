using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_C_Sharp.Assignments.Assignment5.Exercise11
{
    class EM_Exercise11
    {
        public EM_Exercise11()
        {
            Console.Write("Enter a positive number: ");
            int num = -1;
            if(!int.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("Invalid Number.");
            }
            else
            {
                Console.Write("Even: ");
                num.IsEven();
                Console.Write("Odd: ");
                num.IsOdd();
                Console.Write("Prime: ");
                num.IsPrime();

                againDivide:  Console.Write("\nEnter a number to divide {0}: ", num);
                int div = -1;
                if (!int.TryParse(Console.ReadLine(), out div)){
                    Console.WriteLine("Invalid Input");
                    goto againDivide;
                }

                num.IsDivisible(div);
            }
        }

    }
}
