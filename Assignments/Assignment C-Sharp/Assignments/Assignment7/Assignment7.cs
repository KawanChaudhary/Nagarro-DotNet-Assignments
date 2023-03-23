using Assignment_C_Sharp.Assignments.Assignment7.Exercise17;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_C_Sharp.Assignments.Assignment7
{
    class Assignment7
    {
        public Assignment7()
        {
            Console.Write("\n16 for Exercise 16" +
                "\n17 for Exercise 17" +
                "\nWhich exercise: ");
            int response = Int32.Parse(Console.ReadLine());

            switch (response)
            {
                case 16:
                    // Exercise 16
                    Console.WriteLine("\n---- Exercise 16 ----");
                    File_Exercise16 exercise16 = new File_Exercise16();
                    break;
                case 17:
                    // Exercise 17
                    Console.WriteLine("\n---- Exercise  15 ----");
                    Exception_Exercise17 exercise17 = new Exception_Exercise17();
                    break;

                default:
                    Console.WriteLine("Invalid input.");
                    break;
            }
        }
    }
}
