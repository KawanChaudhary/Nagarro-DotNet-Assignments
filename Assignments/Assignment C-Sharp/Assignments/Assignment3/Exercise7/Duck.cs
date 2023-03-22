using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_C_Sharp.Assignments.Assignment3.Exercise7
{
    public interface IShowEveryDuckDetail
    {
        void ShowDuckDetails();
    }
    class Duck: IShowEveryDuckDetail
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
