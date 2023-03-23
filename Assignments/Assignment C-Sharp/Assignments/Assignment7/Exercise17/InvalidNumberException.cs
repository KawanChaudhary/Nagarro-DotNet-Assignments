using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_C_Sharp.Assignments.Assignment7.Exercise17
{
    class InvalidNumberException : Exception
    {
        public InvalidNumberException(string message)
            : base(message) { }
    }
}
