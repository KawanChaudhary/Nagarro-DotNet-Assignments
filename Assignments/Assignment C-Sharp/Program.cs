using Assignment_C_Sharp.Assignments.Assignment1;
using Assignment_C_Sharp.Assignments.Assignment2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignments
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("---------- Assignments ----------");
            Console.Write("\n1 for Assignment 1");
            Console.Write("\n2 for Assignment 2");
            Console.Write("\n3 for Assignment 3");
            Console.Write("\n4 for Assignment 4");
            Console.Write("\n5 for Assignment 5");
            Console.Write("\n6 for Assignment 6");
            Console.Write("\n7 for Assignment 7");
            Console.Write("\n0 to Exit.");

            try
            {
                Console.Write("\n\nEnter the assignment No. : ");
                int assignmentNumber = Int32.Parse(Console.ReadLine());

                switch (assignmentNumber)
                {
                    case 0:
                        // exit
                        Environment.Exit(1);
                        break;
                    case 1:
                        Console.WriteLine("---- Assignment 1 ----");
                        Assignment1 assignment1 = new Assignment1();
                        break;
                    case 2:
                        Console.WriteLine("---- Assignment 2 ----");
                        Assignment2 assignment2 = new Assignment2();
                        break;
                    default:
                        Console.WriteLine("Sorry, not yet done. :(");
                        break;

                }

                Console.Write("\nWant to review any other assignment? (y/n): ");
                string response = Console.ReadLine().ToLower();

                if(response == "y" || response == "yes")
                {
                    Main();
                }
                else
                {
                    Environment.Exit(1);
                }

            }
            catch(Exception e)
            {
                Console.WriteLine("Please enter a valid number. " + e.Message);
                Main();
            }

            Console.ReadLine();
        }
    }
}
