using System;
using Assignment_C_Sharp.Assignments.Assignment2.Exercise4;
using Assignment_C_Sharp.Assignments.Assignment2.Exercise5;

namespace Assignment_C_Sharp.Assignments.Assignment2
{
    public class Assignment2
    {
        public Assignment2()
        {
            Console.Write("4 for Exercise 4" +
                "\n5 for Exercise 5\n" +
                "\nWhich exercise: ");
            int response = Int32.Parse(Console.ReadLine());

            switch (response)
            {
                case 4:
                    // Exercise 4
                    Console.WriteLine("---- Exercise 4 ----");
                    OOPS_Exercise4 exercise4 = new OOPS_Exercise4();
                    break;
                case 5:
                    // Exercise 5
                    Console.WriteLine("---- Exercise 5 ----");
                    OOPS_Exercise5 exercise5 = new OOPS_Exercise5();
                    break;
                default:
                    Console.WriteLine("Invalid input.");
                    break;
            }

        }
    }
}
