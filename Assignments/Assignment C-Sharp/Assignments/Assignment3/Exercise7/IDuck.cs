using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_C_Sharp.Assignments.Assignment3.Exercise7{
    
    interface IDuck    {

        void ShowDuckDetails();

        DuckType Type { get; set; }

        double Weight { get; set; }

        int Wings { get; set; }
    }
}
