using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_DataStructures.DataStructures.Queue
{
    class QueueClass
    {
        private readonly int[] queueImplementation;
        private int front;
        private int rear;
        private readonly int max;
        private int queueElementCount = 0;
        private int dequeueCount = 0;


        public QueueClass(int size)
        {
            queueImplementation = new int[size];
            front = 0;
            rear = -1;
            max = size;
        }

        //ENQUEUE
        public void EnQueue(int item)
        {
            try
            {
                if (rear == max - 1)
                {
                    Console.WriteLine("Queue is Already Full");
                    Console.WriteLine("\n");
                    return;
                }
                else
                {
                    Console.WriteLine($"{item} is Inserted at Queue");
                    Console.WriteLine("\n");
                    queueImplementation[++rear] = item;
                    queueElementCount += 1;
                }
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        //DEQUEUE
        public int DeQueue()
        {
            try
            {
                if (front == rear + 1)
                {
                    Console.WriteLine("Queue is Empty");
                    return -1;
                }
                else
                {
                    Console.WriteLine("Dequeued element is: " + queueImplementation[front]);
                    Console.WriteLine("\n");
                    queueElementCount -= 1;
                    dequeueCount += 1;
                    return queueImplementation[front++];

                }
            }
            catch (Exception e)
            {
                throw e;

            }


        }

        //PEEK
        public void Peek()
        {
            try
            {
                Console.WriteLine($"The element at front is: {queueImplementation[front]}");
                Console.WriteLine("\n");
                return;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        //CONTAINS
        public void ElementContains(int element)
        {
            try
            {
                bool foundElement = false;
                if (front == rear + 1)
                {
                    Console.WriteLine("Queue is Already Empty");

                }
                else
                {
                    for (int i = dequeueCount; i < queueImplementation.Length; i++)
                    {
                        if (queueImplementation[i] == element)
                        {
                            Console.WriteLine($"Found {element} at index {i} in the queue");
                            foundElement = true;
                            Console.WriteLine("\n");
                        }

                    }
                    if (!foundElement)
                    {
                        Console.WriteLine($"{element} is not present in the queue");
                        Console.WriteLine("\n");

                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        //SIZE
        public void Size()
        {
            try
            {
                Console.WriteLine($"The Size of the queue is: {queueElementCount}");
                Console.WriteLine("\n");
                return;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        //PRINT
        public void PrintQueue()
        {
            try
            {
                if (front == rear + 1)
                {
                    Console.WriteLine("Queue is Empty");
                    Console.WriteLine("\n");
                    return;
                }
                else
                {
                    for (int i = front; i <= rear; i++)
                    {
                        Console.WriteLine("Item[" + (i + 1) + "]: " + queueImplementation[i]);
                    }
                }
                Console.WriteLine("\n");
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        //REVERSE
        public void ReverseQueue()
        {
            try
            {
                int[] reverseQueue = Enumerable.Reverse(queueImplementation).ToArray();
                Console.WriteLine("\nReverse Queue\n");
                for (int i = 0; i < queueElementCount; i++)
                {
                    Console.WriteLine("Item[" + (i + 1) + "]: " + reverseQueue[i]);

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
