using Assignment_C_Sharp.Assignments.Assignment5.Exercise11;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_C_Sharp.Assignments.Assignment5
{
    class Assignment5
    {
        public Assignment5()
        {
            Console.Write("11 for Exercise 11" +
                "\n12 for Exercise 12" +
                "\n13 for Exercise 13\n" +
                "\nWhich exercise: ");
            int response = Int32.Parse(Console.ReadLine());

            switch (response)
            {
                case 11:
                    // Exercise 11
                    Console.WriteLine("---- Exercise 6 ----");
                    EM_Exercise11 obj = new EM_Exercise11();
                    break;
                /*case 12:
                    // Exercise 12
                    Console.WriteLine("---- Exercise  7----");
                    break;*/
                default:
                    Console.WriteLine("Invalid input.");
                    break;
            }
        }
    }
}
