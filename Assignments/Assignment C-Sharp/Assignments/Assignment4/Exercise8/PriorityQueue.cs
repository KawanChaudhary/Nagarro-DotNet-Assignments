using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_C_Sharp.Assignments.Assignment4.Exercise8
{
    class PriorityQueue<T> where T : IComparable<T>
    {
        private readonly List<T> data;

        public PriorityQueue()
        {
            data = new List<T>();
        }


        public void Enqueue(T item)
        {
            data.Add(item);


            var ci = data.Count - 1; // child index; start at end
            while (ci > 0)
            {
                var pi = (ci - 1) / 2; // parent index


                if (data[ci].CompareTo(data[pi]) >= 0)
                    break; // child item is larger than (or equal) parent so we're done


                Swap(ci, pi);


                ci = pi;
            }
        }

        public T Dequeue()
        {
            // assumes pq is not empty; up to calling code
            var li = data.Count - 1; // last index (before removal)
            var frontItem = data[0]; // fetch the front
            data[0] = data[li];
            data.RemoveAt(li);


            li--; // last index (after removal)
            var pi = 0; // parent index. start at front of pq
            while (true)
            {
                var ci = pi * 2 + 1; // left child index of parent
                if (ci > li) break; // no children so done


                var rc = ci + 1; // right child
                if (rc <= li && data[rc].CompareTo(data[ci]) < 0) // if there is a rc (ci + 1), and it is smaller than left child, use the rc instead
                    ci = rc;


                if (data[pi].CompareTo(data[ci]) <= 0)
                    break; // parent is smaller than (or equal to) smallest child so done


                Swap(pi, ci); // swap parent and child


                pi = ci;
            }


            return frontItem;
        }


        public T Peek() => data[0];


        public int Count() => data.Count;


        public override string ToString()
        {
            var s = default(string);


            foreach (var elem in data)
                s += elem + " ";


            return s;
        }


        private void Swap(int firstIndex, int secondIndex)
        {
            var tmp = data[firstIndex];
            data[firstIndex] = data[secondIndex];
            data[secondIndex] = tmp;
        }
    }
}
