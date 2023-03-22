using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_C_Sharp.Assignments.Assignment5.Exercise12
{
    class Exercise12_LambdaAndDelegates
    {
        private void Print(string message, IEnumerable<int> list)
        {
            Console.Write(message + " : ");
            foreach (int num in list)
                Console.Write(num + " ");
            Console.WriteLine();
        }

        // All Conditions
        private bool Condition_GreaterThanFive(int value)
        {
            return value > 5;
        }
        private bool Condition_LessThanFive(int value)
        {
            return value < 5;
        }
        private bool Condition_Anything(int value)
        {
            return value % 3 == 0 || value % 5 == 0 || value % 7 == 0 || value % 9 == 0;
        }

        private void OddNumbers(List<int> Numbers)
        {
            Console.WriteLine("\n\nAll Odd Numbers");
            IEnumerable<int> odd = Numbers.Where(value => value % 2 == 1);
            Print("Odd Numbers", odd);
        }

        private void EvenNumbers(List<int> Numbers)
        {
            Console.WriteLine("\nAll Even Numbers");
            IEnumerable<int> even = Numbers.Where(value => value % 2 == 0);
            Print("Even Numbers", even);
        }

        private void PrimeNumbers(List<int> Numbers)
        {
            // Prime Numbers using Anonymous method
            Console.WriteLine("\nAll prime numbers");
            IEnumerable<int> primeUsingAM = Numbers.Where(delegate (int value)
            {
                if (value <= 1) return false;
                else if (value == 2) return true;
                else
                {
                    double boundry = Math.Floor(Math.Sqrt(value));

                    for (int j = 2; j <= boundry; ++j)
                    {
                        if ((value % j) == 0) return false;
                    }
                    return true;
                }
            });
            Print("Prime numbers using Anonymous Method: ", primeUsingAM);

            // Prime Numbers using Lambda
            IEnumerable<int> primeUSingLambda = Numbers.Where(value =>
            {
                double boundry = Math.Floor(Math.Sqrt(value));

                for (int j = 2; j <= boundry; ++j)
                {
                    if ((value % j) == 0) return false;
                }
                return true;
            });
            Print("Prime numbers using Lambda: ", primeUSingLambda);
        }

        private void GreaterThanFive(List<int> Numbers)
        {
            Console.WriteLine("\nAll number greater than five");
            Func<int, bool> conditionGreaterThanFive = Condition_GreaterThanFive;
            IEnumerable<int> greaterThanFiveList = Numbers.Where(conditionGreaterThanFive);
            Print("Greater than five:", greaterThanFiveList);
        }    
        private void LessThanFive(List<int> Numbers)
        {
            Console.WriteLine("\nAll numbers less than five");
            Func<int, bool> conditionLessThanFive = new Func<int, bool>(Condition_LessThanFive);
            IEnumerable<int> lessThanFiveList = Numbers.Where(conditionLessThanFive);
            Print("Less than five:", lessThanFiveList);
        }
        private void _3k(List<int> Numbers)
        {
            Console.WriteLine("\nAll numbers divisible by 3");
            Func<int, bool> condition3k = new Func<int, bool>(value => value % 3 == 0);
            IEnumerable<int> _3kList = Numbers.Where(condition3k);
            Print("Divisible by 3:", _3kList);
        }
        private void _3kPlus1(List<int> Numbers)
        {
            Console.WriteLine("\n1 Reminder when integers are divide by 3.");
            Func<int, bool> condition3kPlus1 = new Func<int, bool>(delegate (int value) { return value % 3 == 1; });
            IEnumerable<int> _3kPlus1List = Numbers.Where(condition3kPlus1);
            Print("1 Remainder:", _3kPlus1List);
        }
        private void _3kPlus2(List<int> Numbers)
        {
            Console.WriteLine("\n2 Reminder when integers are divide by 3.");
            Func<int, bool> condition3kPlus2 = (value => value % 3 == 2);
            IEnumerable<int> _3kPlus2List = Numbers.Where(condition3kPlus2);
            Print("2 Remainder:", _3kPlus2List);
        }
        private void FindAnything_1(List<int> Numbers)
        {
            Console.WriteLine("\nAny number - Anonymous Method Assignment ");
            Func<int, bool> anything_1 = delegate(int value) {
                return (value % 3 == 0 || value % 5 == 0 || value % 7 == 0 || value % 9 == 0);
            };
            IEnumerable<int> anything_1List = Numbers.Where(anything_1);
            Print("Any Number:", anything_1List);
        }
        private void FindAnything_2(List<int> Numbers)
        {
            Console.WriteLine("\nAny number - Method Group Conversion Assignment");
            Func<int, bool> anything_2 = Condition_Anything;
            IEnumerable<int> anything_2List = Numbers.Where(anything_2);
            Print("Any Number:", anything_2List);
        }

        public Exercise12_LambdaAndDelegates()
        {
            System.Random random = new System.Random();
            List<int> Numbers = new List<int>();

            int size = 30;
            Console.Write("All Numbers: ");
            for (int i = 0; i < size; i++)
            {
                Numbers.Add(random.Next(0, 100));
                Console.Write($"{Numbers[i]} ");
            }

            // Odd Numbers using Lambda
            OddNumbers(Numbers);

            // Even Numbers using Lambda
            EvenNumbers(Numbers);

            // Prime Numbers
            PrimeNumbers(Numbers);

            // Find Elements Greater Than Five – Method Group Conversion Syntax
            GreaterThanFive(Numbers);

            // Find Less than Five – Delegate Object in Where – Method Group Conversion Syntax in Constructor of Object
            LessThanFive(Numbers);

            // Find 3k – Delegate Object in Where –Lambda Expression in Constructor of Object
            _3k(Numbers);

            // Find 3k + 1 - Delegate Object in Where –Anonymous Method in Constructor of Object
            _3kPlus1(Numbers);

            // Find 3k + 2 - Delegate Object in Where –Lambda Expression Assignment
            _3kPlus2(Numbers);

            // Any Number (value % 3 == 0 || value % 5 == 0 || value % 7 == 0 || value % 9 == 0)
            Console.WriteLine("\nAny number (value % 3 == 0 || value % 5 == 0 || value % 7 == 0 || value % 9 == 0)");

            // Find anything - Delegate Object in Where – Anonymous Method Assignment
            FindAnything_1(Numbers);

            // Find anything - Delegate Object in Where – Method Group Conversion Assignment 
            FindAnything_2(Numbers);
        }
    }
}
