using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_DataStructures.DataStructures.LinkedList
{
    class RootLinkedList
    {
        public RootLinkedList()
        {
            LinkedList MyLinkedList = new LinkedList();

            MyLinkedList.InsertAtBeginning(10);
            MyLinkedList.PrintLinkedList();
            MyLinkedList.InsertAtBeginning(11);
            MyLinkedList.PrintLinkedList();
            MyLinkedList.InsertAtBeginning(20);
            MyLinkedList.PrintLinkedList();
            MyLinkedList.InsertAtEnd(30);
            MyLinkedList.PrintLinkedList();
            MyLinkedList.InsertAtEnd(40);
            MyLinkedList.PrintLinkedList();
            MyLinkedList.InsertAtEnd(50);
            MyLinkedList.PrintLinkedList();
            MyLinkedList.InsertAtPosition(3, 100);
            MyLinkedList.PrintLinkedList();
            MyLinkedList.InsertAtPosition(5, 200);
            MyLinkedList.PrintLinkedList();
            MyLinkedList.DeleteFromBeginning();
            MyLinkedList.PrintLinkedList();
            MyLinkedList.DeleteFromEnd();
            MyLinkedList.PrintLinkedList();
            MyLinkedList.DeleteAtPosition(1);
            MyLinkedList.PrintLinkedList();
            MyLinkedList.PrintCentreNode();
            MyLinkedList.PrintReversedList();
            MyLinkedList.SizeofLinkedList();
        }
    }
}
