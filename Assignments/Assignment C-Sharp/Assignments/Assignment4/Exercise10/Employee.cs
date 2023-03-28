using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_C_Sharp.Assignments.Assignment4.Exercise10
{
    class Employee
    {
        private string name;
        private string department;
        private float performance;

        public Employee(string name, string department, float performance)
        {
            this.name = name;
            this.department = department;
            this.performance = performance;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Department
        {
            get { return department; }
            set { department = value; }
        }
        public float Performance
        {
            get { return performance; }
            set { performance = value; }
        }

    }
}
