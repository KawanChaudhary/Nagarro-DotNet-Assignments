using Assignment_C_Sharp.Assignments.Assignment3.Exercise6;
using Assignment_C_Sharp.Assignments.Assignment3.Exercise7;
using System;

namespace Assignment_C_Sharp.Assignments.Assignmnet3
{
    class Assignment3
    {
        public Assignment3()
        {

            Console.Write("6 for Exercise 6" +
                "\n7 for Exercise 7\n" +
                "\nWhich exercise: ");
            int response = Int32.Parse(Console.ReadLine());

            switch (response)
            {
                case 6:
                    // Exercise 6
                    Console.WriteLine("---- Exercise 6 ----");
                    OOPS_Exercise6 exercise6 = new OOPS_Exercise6();
                    break;
                case 7:
                    // Exercise 7
                    Console.WriteLine("---- Exercise  7----");
                    OOPS_Exercise7 exercise5 = new OOPS_Exercise7();
                    break;
                default:
                    Console.WriteLine("Invalid input.");
                    break;
            }
        }
    }
}
