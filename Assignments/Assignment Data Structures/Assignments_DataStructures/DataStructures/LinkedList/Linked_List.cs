using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_DataStructures.DataStructures.LinkedList
{
    class LinkedList
    {
        private Node head;
        private int counter;
        private int centreNode;
        public int iteratorPosition = 0;

        public LinkedList()
        {
            head = null;
            counter = 0;
        }

        //INSERT AT  THE START
        public void InsertAtBeginning(int newData)
        {
            try
            {
                Console.WriteLine($"Inserting {newData} at the Front");
                Node NewNode = new Node(newData);
                NewNode.Next = head;
                head = NewNode;
                counter++;
                Console.WriteLine("\n");
            }
            catch (Exception e)
            {
                throw e;

            }

        }

        //INSERT AT END
        public void InsertAtEnd(int newData)
        {
            try
            {
                Console.WriteLine($"Inserting {newData} at the End");
                Node NewNode = new Node(newData);
                //ITERATOR
                Node pointer = head;
                while (pointer != null)
                {

                    if (pointer.Next == null)
                    {
                        pointer.Next = NewNode;
                        NewNode.Next = null;
                        counter++;
                        break;
                    }
                    pointer = pointer.Next;
                }
                Console.WriteLine("\n");
            }
            catch (Exception e)
            {
                throw e;
            }


        }

        //DELETE FROM START
        public void DeleteFromBeginning()
        {
            try
            {
                Console.WriteLine("Removing first element");
                //ITERATOR
                Node pointer = head;
                head = pointer.Next;
                pointer = null;
                counter--;

                Console.WriteLine("\n");
            }
            catch (Exception e)
            {
                throw e;
            }


        }

        //DELETE FROM THE END
        public void DeleteFromEnd()
        {
            try
            {
                Console.WriteLine("Removing last element");
                //ITERATOR
                Node pointer = head;
                pointer = pointer.Next;
                while (pointer != null)
                {
                    if (pointer.Next.Next == null)
                    {
                        pointer.Next = null;
                        counter--;
                        break;
                    }
                    pointer = pointer.Next;
                }
                Console.WriteLine("\n");
            }
            catch (Exception e)
            {
                throw e;
            }


        }

        //INSERTING AT GIVEN POSITION(INDEX)
        public void InsertAtPosition(int index, int newData)
        {
            try
            {
                Console.WriteLine($"Inserting {newData} at the Position {index}");
                Node NewNode = new Node(newData);
                //ITERATOR
                Node pointer = head;
                int PositionCount = 0;
                while (pointer.Next != null)
                {
                    if (PositionCount == index - 1)
                    {
                        NewNode.Next = pointer.Next;
                        pointer.Next = NewNode;
                        counter++;
                        break;


                    }
                    else if (index == 0)
                    {
                        NewNode.Next = head;
                        head = NewNode;
                        counter++;
                        break;

                    }
                    else
                    {

                        pointer = pointer.Next;
                        PositionCount += 1;
                    }
                }
                PositionCount += 1;
                if (pointer.Next == null && PositionCount == index)
                {
                    pointer.Next = NewNode;
                    NewNode.Next = null;
                    counter++;

                }

                Console.WriteLine("\n");
            }
            catch (Exception e)
            {
                throw e;
            }



        }

        //DELETING FROM THE GIVEN POSITION(INDEX)
        public void DeleteAtPosition(int index)
        {
            try
            {
                Console.WriteLine($"Deleting Node from the Position {index}");
                //ITERATOR
                Node pointer = head;
                int PositionCount = 0;
                while (pointer.Next != null)
                {
                    if (index == 0)
                    {
                        head = pointer.Next;
                        pointer = null;
                        counter--;
                        break;

                    }
                    else if (PositionCount == index - 1)
                    {

                        pointer.Next = pointer.Next.Next;
                        counter--;
                        break;

                    }
                    else
                    {
                        pointer = pointer.Next;
                        PositionCount += 1;
                    }
                }
                Console.WriteLine("\n");
            }
            catch (Exception e)
            {
                throw e;
            }



        }

        //TRAVERSING THE LINKED LIST
        public void PrintLinkedList()
        {
            try
            {

                Node pointer = head;
                int PositionCount = 0;
                Console.WriteLine($"The Elements in the Linked List are : ");
                while (pointer != null)
                {

                    Console.Write(pointer.Data + "  ");
                    pointer = pointer.Next;
                    PositionCount += 1;
                }
                Console.WriteLine("\n");
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        //REVERSE OF A LINKED LIST
        public Node ReverseLinkedList(Node head)
        {
            Node CurrentNode = head;
            Node PreviousNode = null;
            Node TempNext;
            while (CurrentNode != null)
            {
                TempNext = CurrentNode.Next;
                CurrentNode.Next = PreviousNode;
                PreviousNode = CurrentNode;
                CurrentNode = TempNext;
            }
            //PreviousNode = CurrentNode;
            return PreviousNode;
        }

        //PRINTING THE REVERSE OF A LINKED LIST
        public void PrintReversedList()
        {
            try
            {
                Node CurrentNode = ReverseLinkedList(head);
                Console.WriteLine("The Reversed Linked List is: ");
                while (CurrentNode != null)
                {
                    Console.Write(CurrentNode.Data + "  ");
                    CurrentNode = CurrentNode.Next;
                }
                Console.WriteLine("\n");
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        //SIZE OF THE LINKED LIST
        public void SizeofLinkedList()
        {
            try
            {
                Console.WriteLine($"The Size of the Linked List is: {counter}");
                Console.WriteLine("\n");
            }
            catch (Exception e)
            {
                throw e;
            }

        }


        //PRINTING THE CENTRE NODE OF THE LINKED LIST
        public void PrintCentreNode()
        {
            try
            {

                Node pointer = head;
                int PositionCount = 0;
                int MidIndex = counter / 2;
                while (pointer.Next != null)
                {
                    if (PositionCount == MidIndex)
                    {
                        centreNode = pointer.Data;
                        Console.WriteLine($"The Centre Node in the Linked List is {centreNode}");
                        break;

                    }

                    PositionCount += 1;
                    pointer = pointer.Next;

                }

                Console.WriteLine("\n");
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
