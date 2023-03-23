using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_C_Sharp.Assignments.Assignment7.Exercise17
{
    class Exception_Exercise17
    {
        private bool isPrime(int number)
        {
            if (number == 1) return false;
            if (number == 2) return true;


            for (int i = 2; i <= Math.Ceiling(Math.Sqrt(number)); ++i)
                if (number % i == 0)
                    return false;
            return true;
        }
        public Exception_Exercise17()
        {

            int timesPlayed = 0;
            //you have played this game for 5 times. 
            while (timesPlayed < 5)
            {

                int number = -1;
                Console.Write("Enter any number from 1-5: ");
                //If user does not enter correct number from 1-5 show error message. and then -> GOTO step 1

                if (!int.TryParse(Console.ReadLine(), out number) && number <= 0 && number >= 6)
                {
                    throw new InvalidNumberException(string.Format(" Error: enter any integer number from {0}-{1}!", 1, 5));
                }
                else
                {
                    timesPlayed++;
                    if (number == 1)
                    {
                        int anotherNumber = -1;
                        Console.Write("Enter a even number: ");
                        if (!int.TryParse(Console.ReadLine(), out anotherNumber) || anotherNumber % 2 == 1)
                        {
                            throw new InvalidNumberException(string.Format(" Error: Enter a even number!"));
                        }
                        else
                        {
                            Console.WriteLine("It is a correct answer.");
                        }

                    }
                    else if (number == 2)
                    {
                        int anotherNumber = -1;
                        Console.Write("Enter a odd Number: ");
                        if (!int.TryParse(Console.ReadLine(), out anotherNumber) || anotherNumber % 2 == 0)
                        {
                            throw new InvalidNumberException(string.Format(" Error: Enter a odd number!"));
                        }
                        else
                        {
                            Console.WriteLine("It is a correct answer.");
                        }

                    }
                    else if (number == 3)
                    {
                        int anotherNumber = -1;
                        Console.Write("Enter a prime number: ");
                        if (!int.TryParse(Console.ReadLine(), out anotherNumber) || !isPrime(anotherNumber))
                        {
                            throw new InvalidNumberException(string.Format(" Error: Enter a prime number!"));
                        }
                        else
                        {
                            Console.WriteLine("It is a correct answer.");
                        }

                    }
                    else if (number == 4)
                    {
                        int anotherNumber = -1;
                        Console.Write("Enter a negative Number: ");
                        if (!int.TryParse(Console.ReadLine(), out anotherNumber) || anotherNumber >= 0)
                        {
                            throw new InvalidNumberException(string.Format(" Error: Enter a negative number!"));
                        }
                        else
                        {
                            Console.WriteLine("It is a correct answer.");
                        }

                    }
                    else if (number == 5)
                    {
                        int anotherNumber = -1;
                        Console.Write("Enter zero: ");
                        if (!int.TryParse(Console.ReadLine(), out anotherNumber) || anotherNumber != 0)
                        {
                            throw new InvalidNumberException(string.Format(" Error: Enter zero!"));
                        }
                        else
                        {
                            Console.WriteLine("It is a correct answer.");
                        }
                    }
                }
            }
            Console.WriteLine("\nYou have played this game for 5 times.\n");
        }
    }
}
