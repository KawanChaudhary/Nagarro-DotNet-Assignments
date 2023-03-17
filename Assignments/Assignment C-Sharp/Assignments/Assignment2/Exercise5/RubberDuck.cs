using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_C_Sharp.Assignments.Assignment2.Exercise5
{
    class RedheadDuck : Duck
    {
        public RedheadDuck(double weight, int totalWings, DuckType newDuck) : base(weight, totalWings, newDuck)
        {

        }
        public void showRedheadDuckDetails()
        {
            ShowDuckDetails();
            Console.WriteLine("\nRedhead duck fly slow and quack mild.");
        }
    }
}
