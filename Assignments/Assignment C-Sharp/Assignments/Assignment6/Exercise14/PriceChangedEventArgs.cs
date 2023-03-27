using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_C_Sharp.Assignments.Assignment6.Exercise14
{
    class PriceChangedEvent : EventArgs
    {
        public int Difference { get; set; }
        public PriceChangedEvent(int difference)
        {
            Difference = difference;
        }
            
    }
}
