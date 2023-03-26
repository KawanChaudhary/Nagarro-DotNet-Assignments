using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_C_Sharp.Assignments.Assignment2.Exercise5
{
    class RubberDuck : IDuck
    {
        private double weightOfDuck;
        private int wingsOfDuck;
        private DuckType typeOfDuck;

        // Constructor
        public RubberDuck(double weightOfDuck, int wingsOfDuck, DuckType typeOfDuck)
        {
            this.weightOfDuck = weightOfDuck;
            this.wingsOfDuck = wingsOfDuck;
            this.typeOfDuck = typeOfDuck;
        }

        public void ShowDuckDetails()
        {
            Console.WriteLine("\n\nRubber DucK:");

            Console.WriteLine($"\nWeight of the duck: {this.weightOfDuck}");
            Console.WriteLine($"\nWings of the Duck: {this.wingsOfDuck}");
            Console.WriteLine("\nRubber duck don't fly and squeak.");
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
