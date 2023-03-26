using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_C_Sharp.Assignments.Assignment2.Exercise5
{
    class RedheadDuck : IDuck
    {
        private double weightOfDuck;
        private int wingsOfDuck;
        private DuckType typeOfDuck;

        // Constructor
        public RedheadDuck(double weightOfDuck, int wingsOfDuck, DuckType typeOfDuck)
        {
            this.weightOfDuck = weightOfDuck;
            this.wingsOfDuck = wingsOfDuck;
            this.typeOfDuck = typeOfDuck;
        }

        public void ShowDuckDetails()
        {
            Console.WriteLine("\n\nRedhead DucK:");

            Console.WriteLine($"\nWeight of the duck: {this.weightOfDuck}");
            Console.WriteLine($"\nWings of the Duck: {this.wingsOfDuck}");
            Console.WriteLine("\nRedhead duck fly slow and quack mild.");
        }
        public DuckType Type
        {
            get { return typeOfDuck; }
            set { typeOfDuck = value; }
        }

        public double Weight
        {
            get { return weightOfDuck; }
            set { weightOfDuck = value; }
        }

        public int Wings
        {
            get { return wingsOfDuck; }
            set { wingsOfDuck = value; }
        }
    }
}
