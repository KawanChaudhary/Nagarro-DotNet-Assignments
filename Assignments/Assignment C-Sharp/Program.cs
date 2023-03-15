using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
        static void Exercise3()
        {
            // Write a program to print all prime numbers between two given numbers.
            Console.Write("Enter the first number: ");
            int start = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int end = int.Parse(Console.ReadLine());

            // first number entered should be smaller than larger number and if that’s not the case, ask the user to re-enter both the numbers. 
            // Until user enters valid input, show appropriate message, and keep asking for the input again
             
            if (start >= end)
            {
                Console.WriteLine("\n!First number entered should be smaller than second number. \n");
                Exercise3();
                return;
            }
            Console.WriteLine();
            int count = 0;
            for (int i = start; i <= end; i++)
            {
                if (IsPrime(i))
                {
                    Console.Write("{0} ", i);
                    count++;
                }
            }
            Console.WriteLine($"\n\nNo. of prime numbers between {start} and {end} : {count}\n");            
        }
        static void Exercise2()
        {
            /* 
             == check whether two values are equal or not

             object.Equals() method check whether two object instances are equal or not
             */

            // Example 1
            Console.WriteLine("\n----- Example 1 -----");
            string str1 = "Hello", str2 = "Hello", str3 = "hello";

            Console.WriteLine("\n --> == Example");
            Console.WriteLine(str1 == str2); // true
            Console.WriteLine(str1 == str3); // false

            Console.WriteLine("\n--> object.Equals() Example");

            Console.WriteLine(str1.Equals(str2));// true
            Console.WriteLine(str1.Equals(str3)); // false

            //.Equals() method by default checks whether two two object instances are equal or not but
            // for the string type, == and .Equals() method are implemented to compare values instead of the instance

            // Example 2
            Console.WriteLine("\n----- Example 2 -----");
            object obj1 = "Hello";
            object obj2 = "Hello";

            Console.WriteLine(obj1 == obj2); // true
            Console.WriteLine(obj1.Equals(obj2)); // true

            // == and Equals() method compares values and they compare instances as well

        }
        static void Exercise1()
        {
            // 1. Integer


            Console.WriteLine("----- Integer -----");
            Console.Write("Enter a Number: ");
            string str = Console.ReadLine();

            // Using Int-Parse
            int IntAns1 = Int32.Parse(str);
            Console.WriteLine();
            Console.WriteLine("String to Int using Parse");
            Console.Write("Using Int32.parse " + $"'{str}' --> ");
            Console.WriteLine(IntAns1);

            //Using Convert-To-Int
            int IntAns2 = Convert.ToInt32(str);
            Console.WriteLine();
            Console.WriteLine("String to Int using Convert.ToInt");
            Console.Write("Using Convert.ToInt32 " + $"'{str}' --> ");
            Console.WriteLine(IntAns2);

            //Using Int-Try-Parse
            int IntAns3;
            Console.WriteLine();
            Console.WriteLine("String to Int using Int32.TryParse");
            bool isParsable = Int32.TryParse(str, out IntAns3);

            if (isParsable)
            {
                Console.Write("Using Int32.TryParse " + $"'{str}' --> ");
                Console.WriteLine(IntAns3);
            }
            else
                Console.WriteLine("Could not be parsed.");

            // 2. Float

            Console.WriteLine("\n\n----- Float -----");
            Console.Write("Enter a Decimal Number: ");
            string str2 = Console.ReadLine();

            // Using Single-Parse:
            Console.WriteLine();
            Console.WriteLine("String to Float using Single.Parse");
            float FloatAns1 = Single.Parse(str2);
            Console.Write("Using Single.Parse " + $"'{str2}' --> ");
            Console.WriteLine(FloatAns1);

            // Using Float-Parse
            Console.WriteLine();
            Console.WriteLine("String to Float using float.Parse");
            float FloatAns2 = float.Parse(str2);
            Console.Write("Using float.Parse " + $"'{str2}' --> ");
            Console.WriteLine(FloatAns2);

            // Using Convert-To-Single
            Console.WriteLine();
            Console.WriteLine("String to Float using Convert.ToSingle");
            float FloatAns3 = Convert.ToSingle(str2);
            Console.Write("Using Convert.ToSingle " + $"'{str2}' --> ");
            Console.WriteLine(FloatAns3);

            //Boolean

            Console.WriteLine("\n\n----- Boolean -----");
            Console.Write("Enter a Bool Value(True/False): ");
            string str3 = Console.ReadLine();
            str3 = str3.ToLower();

            // Using bool-Parse
            bool BoolAns1 = bool.Parse(str3);
            Console.WriteLine();
            Console.WriteLine("String to Bool using Parse");
            Console.Write("Using bool.parse " + $"'{str3}' --> ");
            Console.WriteLine(BoolAns1);

            //Using Convert-To-Int
            bool BoolAns2 = Convert.ToBoolean(str3);
            Console.WriteLine();
            Console.WriteLine("String to Int using Convert.ToBoolean");
            Console.Write("Using Convert.ToBoolean " + $"'{str3}' --> ");
            Console.WriteLine(BoolAns2);

            //Using Int-Try-Parse
            bool BoolAns3;
            Console.WriteLine();
            Console.WriteLine("String to Int using bool.TryParse");
            bool isParsable1 = bool.TryParse(str3, out BoolAns3);

            if (isParsable1)
            {
                Console.Write("Using bool.TryParse " + $"'{str3}' --> ");
                Console.WriteLine(BoolAns3);
            }
            else
                Console.WriteLine("Could not be parsed.");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("---------------- Exercise 1 ----------------\n");
            Exercise1();

            Console.WriteLine("\n\n---------------- Exercise 2 ----------------\n");
            Exercise2();

            Console.WriteLine("\n\n---------------- Exercise 3 ----------------\n");
            Exercise3();

            Console.ReadLine();
        }
    }
}

namespace Assignemnt2
{
    class Equipment
    {
        public string Name = "";
        public string description = "";
        public int 
        static void Main(string[] args)
        {
                
        }
    }
}

