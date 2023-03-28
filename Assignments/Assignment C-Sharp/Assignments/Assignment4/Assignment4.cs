using Assignment_C_Sharp.Assignments.Assignment4.Exercise8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_C_Sharp.Assignments.Assignment4
{
    class Assignment4
    {
        public Assignment4()
        {
            Console.Write("8 for Exercise 8" +
                "\n9 for Exercise 9" +
                "\n10 for Exercise 10\n" +
                "\nWhich exercise: ");
            int response = Int32.Parse(Console.ReadLine());

            switch (response)
            {
                case 8:
                    // Exercise 8
                    Console.WriteLine("---- Exercise 8 ----");
                    Collection_Exercise8 exercise8 = new Collection_Exercise8();
                    break;
                case 9:
                    // Exercise 9
                    Console.WriteLine("---- Exercise 9 ----");
                    break;
                case 10:
                    //Exercise 10
                    Console.WriteLine("---- Exercise 10 ----");
                    break;
                default:
                    Console.WriteLine("Invalid input.");
                    break;
            }
        }
    }
}
