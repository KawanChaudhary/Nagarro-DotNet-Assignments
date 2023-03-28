using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_DataStructures.DataStructures.LinkedList
{
    class Node
    {
        private int data;
        private Node next;
        public Node(int data)
        {
            this.data = data;
            this.next = null;
        }

        public int Data
        {
            get { return data; }
            set { data = value; }
        }

        public Node Next
        {
            get { return next; }
            set { next = value; }
        }

    }
}
