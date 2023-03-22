using Assignment_C_Sharp.Assignments.Assignment6.Exercise14;
using Assignment_C_Sharp.Assignments.Assignment6.Exercise15;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_C_Sharp.Assignments.Assignment6
{
    class Assignment6
    {
        public Assignment6()
        {
            Console.Write("\n14 for Exercise 14" +
                "\n15 for Exercise 15" +
                "\nWhich exercise: ");
            int response = Int32.Parse(Console.ReadLine());

            switch (response)
            {
                case 14:
                    // Exercise 14
                    Console.WriteLine("\n---- Exercise 14 ----");
                    OOPS_Exercise14 exercise14 = new OOPS_Exercise14();
                    break;
                case 15:
                    // Exercise 15
                    Console.WriteLine("\n---- Exercise  15 ----");
                    Event_Exercise15 exercise15 = new Event_Exercise15();
                    break;                
                default:
                    Console.WriteLine("Invalid input.");
                    break;
            }
        }    
    }
}
