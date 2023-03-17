using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_C_Sharp.Assignments.Assignment2.Exercise5
{
    // Exercise 5 Code

    enum DuckType
    {
        RubberDuck,
        MallhardDuck,
        RedheadDuck
    }

    class OOPS_Exercise5
    {
        // Exercise 5

        // Rubber Duck
        public OOPS_Exercise5()
        {
            RubberDuck duck1 = new RubberDuck(12.34, 2, DuckType.RubberDuck);
            duck1.ShowDuckDetails();

            // Redhead Duck
            RedheadDuck duck2 = new RedheadDuck(6.45, 4, DuckType.RedheadDuck);
            duck2.ShowDuckDetails();

            // Mallhard Duck
            MallhardDuck duck3 = new MallhardDuck(10.5, 3, DuckType.MallhardDuck);
            duck3.ShowDuckDetails();
        }
    }
}
