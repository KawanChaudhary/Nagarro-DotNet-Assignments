using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_C_Sharp.Assignments.Assignment2.Exercise5
{
    interface IShowEveryDetail
    {
        void ShowDuckDetails();
    }
    class Duck: IShowEveryDetail
    {
        private double weightOfDuck;
        private int wingsOfDuck;
        private DuckType typeOfDuck;

        // Constructor
        public Duck(double weightOfDuck, int wingsOfDuck, DuckType typeOfDuck)
        {
            this.weightOfDuck = weightOfDuck;
            this.wingsOfDuck = wingsOfDuck;
            this.typeOfDuck = typeOfDuck;
        }

        public virtual void ShowDuckDetails()
        {

            if (typeOfDuck == DuckType.RubberDuck)
            {
                Console.WriteLine("\n\nRubber DucK:");
            }
            else if (typeOfDuck == DuckType.RedheadDuck)
            {
                Console.WriteLine("\n\nRedhead DucK:");
            }
            else if (typeOfDuck == DuckType.MallhardDuck)
            {
                Console.WriteLine("\n\nMallhard DucK:");
            }

            Console.WriteLine($"\nWeight of the duck: {this.weightOfDuck}");
            Console.WriteLine($"\nWings of the Duck: {this.wingsOfDuck}");
        }
    }
}
