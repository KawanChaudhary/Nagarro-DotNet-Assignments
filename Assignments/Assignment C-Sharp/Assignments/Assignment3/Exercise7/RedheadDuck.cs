using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_C_Sharp.Assignments.Assignment3.Exercise7
{
    class RubberDuck : Duck
    {
        public RubberDuck(double weight, int totalWings, DuckType newDuck) : base(weight, totalWings, newDuck)
        {

        }
        public override void ShowDuckDetails()
        {
            base.ShowDuckDetails();
            Console.WriteLine("\nRubber duck don't fly and squeak.");
        }
    }
}
