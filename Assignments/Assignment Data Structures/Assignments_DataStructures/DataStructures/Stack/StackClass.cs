using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_DataStructures.DataStructures.Stack
{
    class StackClass
    {
        static readonly int MAX = 1000;
        private int sizeOfTheStack = 0;
        private int top;
        private int[] newStack = new int[MAX];
        List<int> reversedStack = new List<int>();


        public StackClass(int Size)
        {
            top = -1;
        }
        bool IsEmpty()
        {
            return (top < 0);
        }

        //PUSH OPERATION
        public void PushData(int data)
        {
            try
            {
                if (top >= MAX)
                {
                    Console.WriteLine("Stack Is Already Full");
                    return;
                }
                else
                {
                    newStack[++top] = data;
                    Console.WriteLine($"Sucesfully Inserted {data} at the top");
                    sizeOfTheStack += 1;

                }
                Console.WriteLine("\n");
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        //POP OPERATION
        public void PopData()
        {
            try
            {
                if (top < 0)
                {
                    Console.WriteLine("The Stack is Already Empty");
                    return;
                }
                else
                {
                    int popedvalue = newStack[top--];
                    Console.WriteLine($"The data {popedvalue} is removed from the top");
                    sizeOfTheStack -= 1;

                }
                Console.WriteLine("\n");
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        //PEEK OPERATION
        public void Peek()
        {
            try
            {
                if (top < 0)
                {
                    Console.WriteLine("Stack is Already Empty");
                    return;
                }
                else
                {
                    Console.WriteLine($"The top most Element of the Stack is : {newStack[top]}");
                }
                Console.WriteLine("\n");
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        //PRINT ALL THE ELEMENTS IN STACK
        public void PrintStack()
        {
            try
            {
                if (top < 0)
                {
                    Console.WriteLine("Stack is Already Empty");
                    return;
                }
                else
                {
                    Console.WriteLine("Items in the stack are : ");
                    for (int i = top; i >= 0; i--)
                    {
                        Console.Write(newStack[i] + " ");
                    }
                }
                Console.WriteLine("\n");
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        //CONTAINS OPERATION
        public void ContainsData(int data)
        {
            try
            {
                bool doesContains = false;
                if (top < 0)
                {
                    Console.WriteLine("Stack is Already Empty");
                    return;
                }
                else
                {
                    for (int index = 0; index <= top; index++)
                    {
                        if (newStack[index] == data)
                        {
                            Console.WriteLine($"The data {data} is Present at Position {index} in the stack");
                            doesContains = true;
                        }
                    }
                    if (!doesContains)
                    {
                        Console.WriteLine($"The data {data} is not present in the stack");

                    }
                    Console.WriteLine("\n");
                }
            }
            catch (Exception e)
            {
                throw e;
            }



        }


        //REVERSING THE STACK
        public void PrintReversedStack()
        {
            try
            {
                for (int i = top; i >= 0; i--)
                {
                    reversedStack.Add(newStack[i]);
                }

                Console.WriteLine("The Reversed Stack is: ");
                for (int i = reversedStack.Count - 1; i >= 0; i--)
                {

                    Console.Write(reversedStack[i] + " ");
                }
                Console.WriteLine("\n");
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        //SIZE OF STACK
        public void SizeOfStack()
        {
            try
            {
                Console.WriteLine($"The Size is: {sizeOfTheStack}");
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
