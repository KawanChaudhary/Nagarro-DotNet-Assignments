using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_C_Sharp.Assignments.Assignment4.Exercise9
{
    class Employee : IComparable<Employee>
    {
        public string Name { get; }
        public double Priority { get; set; } // smaller values are higher priority


        public Employee(string firstName, double priority)
        {
            this.Name = firstName;
            this.Priority = priority;
        }


        public override string ToString() => "(" + this.Name + ", " + this.Priority.ToString("F1") + ")";


        public int CompareTo(Employee other)
        {
            if (this.Priority < other.Priority) return -1;
            if (this.Priority > other.Priority) return 1;
            return 0;
        }
    
    }
}
