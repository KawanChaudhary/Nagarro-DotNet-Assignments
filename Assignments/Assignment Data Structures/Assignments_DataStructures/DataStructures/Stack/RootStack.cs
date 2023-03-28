using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_DataStructures.DataStructures.Stack
{
    class RootStack
    {
        public RootStack()
        {
            StackClass MyStack = new StackClass(10);
            MyStack.PushData(1);
            MyStack.PushData(2);
            MyStack.PushData(3);
            MyStack.PushData(4);
            MyStack.PushData(5);
            MyStack.PushData(6);
            MyStack.PopData();
            MyStack.PopData();
            MyStack.ContainsData(10);
            MyStack.Peek();
            MyStack.SizeOfStack();
            MyStack.PrintStack();
            MyStack.PrintReversedStack();
        }
    }
}
