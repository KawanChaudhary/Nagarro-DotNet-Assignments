using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_C_Sharp.Assignments.Assignment4.Exercise8
{
    class Collection_Exercise8
    {
        public Collection_Exercise8()
        {
            Console.WriteLine("\nCreating priority queue of employees");
            var pq = new PriorityQueue<Employee>();


            var emp1 = new Employee("B", 2.0);
            var emp2 = new Employee("C", 3.0);
            var emp3 = new Employee("A", 1.0);
            var emp4 = new Employee("D", 4.0);
            var emp5 = new Employee("E", 5.0);
            var emp6 = new Employee("F", 1.5);


            Console.WriteLine($"Adding {emp1} to priority queue");
            pq.Enqueue(emp1);
            Console.WriteLine($"Adding {emp2} to priority queue");
            pq.Enqueue(emp2);
            Console.WriteLine($"Adding {emp3} to priority queue");
            pq.Enqueue(emp3);
            Console.WriteLine($"Adding {emp4} to priority queue");
            pq.Enqueue(emp4);
            Console.WriteLine($"Adding {emp5} to priority queue");
            pq.Enqueue(emp5);
            Console.WriteLine($"Adding {emp6} to priority queue");
            pq.Enqueue(emp6);


            Console.WriteLine("\nPriority queue elements are:");
            Console.WriteLine(pq.ToString());
            Console.WriteLine($"Priority queue size is: {pq.Count()}");
            Console.WriteLine();


            Console.WriteLine($"Peeking a employee from queue: {pq.Peek()}");


            Console.WriteLine("Removing a employee from priority queue");
            var emp = pq.Dequeue();
            Console.WriteLine($"Removed employee is {emp}");
            Console.WriteLine("\nPriority queue is now:");
            Console.WriteLine(pq.ToString());
            Console.WriteLine();


            Console.WriteLine("Removing a second employee from queue");
            emp = pq.Dequeue();
            Console.WriteLine($"Removed employee is {emp}");
            Console.WriteLine("\nPriority queue is now:");
            Console.WriteLine(pq.ToString());
            Console.WriteLine();
        }
    }
}
