using Assignments_DataStructures.DataStructures.LinkedList;
using Assignments_DataStructures.DataStructures.Queue;
using Assignments_DataStructures.DataStructures.Stack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_DataStructures
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("---------- Data Structures ----------");
            Console.Write("\n1 for Linked List");
            Console.Write("\n2 for Stack");
            Console.Write("\n3 for Queue");
            Console.Write("\n4 for Priority Queue");
            Console.Write("\n5 for Hash Table");
            Console.Write("\n0 to Exit.");

            try
            {
                Console.Write("\n\nEnter the assignment No. : ");
                int assignmentNumber = Int32.Parse(Console.ReadLine());
                Console.WriteLine("");
                switch (assignmentNumber)
                {
                    case 0:
                        // exit
                        Environment.Exit(1);
                        break;
                    case 1:
                        Console.WriteLine("---- Linked List ----");
                        RootLinkedList linkedlist = new RootLinkedList();
                        break;
                    case 2:
                        Console.WriteLine("---- Stack ----");
                        RootStack stack = new RootStack();
                        break;
                    case 3:
                        Console.WriteLine("---- Queue ----");
                        RootQueue queue = new RootQueue();
                        break;
                    /*case 4:
                        Console.WriteLine("---- Priority Queue ----");
                        break;
                    case 5:
                        Console.WriteLine("---- Hash Table ----");
                        break;*/
                    default:
                        Console.WriteLine("Sorry, not yet done. :(");
                        break;
                }

                Console.Write("\nWant to review any other data structure? (y/n): ");
                string response = Console.ReadLine().ToLower();

                if (response == "y" || response == "yes")
                {
                    Main();
                }
                else
                {
                    Environment.Exit(1);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Please enter a valid number. " + e.Message);
                Main();
            }
        Console.ReadLine();
        }        
    }
}
