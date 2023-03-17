using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_C_Sharp.Assignments.Assignment2.Exercise5
{
    class Duck: ShowEveryDetail
    {
        private double weight;
        private int totalWings;
        private DuckType newDuck;

        // Constructor
        public Duck(double weight, int totalWings, DuckType newDuck)
        {
            this.weight = weight;
            this.totalWings = totalWings;
            this.newDuck = newDuck;
        }

        public virtual void ShowDuckDetails()
        {

            if (newDuck == DuckType.RubberDuck)
            {
                Console.WriteLine("\n\nRubber DucK:");
            }
            else if (newDuck == DuckType.RedheadDuck)
            {
                Console.WriteLine("\n\nRedhead DucK:");
            }
            else if (newDuck == DuckType.MallhardDuck)
            {
                Console.WriteLine("\n\nMallhard DucK:");
            }

            Console.WriteLine($"\nWeight of the duck: {this.weight}");
            Console.WriteLine($"\nWings of the Duck: {this.totalWings}");
        }
    }
}
