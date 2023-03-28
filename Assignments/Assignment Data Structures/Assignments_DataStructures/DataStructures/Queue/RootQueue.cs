using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_DataStructures.DataStructures.Queue
{
    class RootQueue
    {
        public RootQueue()
        {
            QueueClass MyQueue = new QueueClass(5);
            MyQueue.EnQueue(10);
            MyQueue.EnQueue(11);
            MyQueue.EnQueue(12);
            MyQueue.EnQueue(13);
            MyQueue.EnQueue(14);
            MyQueue.EnQueue(15);
            MyQueue.EnQueue(21);
            MyQueue.DeQueue();
            MyQueue.DeQueue();
            MyQueue.PrintQueue();
            MyQueue.Peek();
            MyQueue.ElementContains(12);
            MyQueue.ReverseQueue();
            MyQueue.Size();
        }
    }
}
