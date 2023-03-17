using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_C_Sharp.Assignments.Assignment1
{
    class Assignment1
    {
        private bool IsPrime(int number)
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
        void Exercise3()
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
        void Exercise2()
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

        // 1. Integer
        void StringToInteger()
        {
            Console.WriteLine("----- String To Integer -----");
            Console.Write("Enter a Number: ");
            string numberString = Console.ReadLine();

            try
            {
                // Using Int Parse
                int stringToIntegerParse = Int32.Parse(numberString);
                Console.WriteLine("\nUsing Int32.parse " + $"'{numberString}' --> {stringToIntegerParse}");

                //Using Convert-To-Int
                int stringToIntegerConvert = Convert.ToInt32(numberString);
                Console.WriteLine("\nUsing Convert.ToInt32 " + $"'{numberString}' --> {stringToIntegerConvert}");

                // Using Try Parse
                int stringToIntegerTryParse;
                bool isParsable = Int32.TryParse(numberString, out stringToIntegerTryParse);

                if (isParsable)
                {
                    Console.Write("\nUsing Int32.TryParse " + $"'{numberString}' --> {stringToIntegerTryParse}");
                }
                else
                    Console.WriteLine("\nCould not be parsed.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Please enter a valid number. " + e.Message);
                StringToInteger();
            }
        }

        void StringToFloat()
        {
            // 2. Float
            Console.WriteLine("\n\n----- String To Float -----");
            Console.Write("Enter a float number: ");
            string floatString = Console.ReadLine();

            try
            {
                // Using Single-Parse:
                float stringToFloatSingleParse = Single.Parse(floatString);
                Console.Write("\nUsing Single.Parse " + $"'{floatString}' --> {stringToFloatSingleParse}");

                // Using Float-Parse

                float stringToFloatParseFloat = float.Parse(floatString);
                Console.Write("\nUsing float.Parse " + $"'{floatString}' --> {stringToFloatParseFloat}");

                // Using Convert-To-Single
                float stringToFloatConvert = Convert.ToSingle(floatString);
                Console.Write("\nUsing Convert.ToSingle " + $"'{floatString}' --> {stringToFloatConvert}");
            }
            catch (Exception e)
            {
                Console.WriteLine("Please enter a valid number. " + e.Message);
                StringToFloat();
            }
        }

        void StringToBool()
        {
            //Boolean

            Console.WriteLine("\n\n----- Boolean -----");
            Console.Write("Enter a Bool Value(True/False): ");
            string boolString = Console.ReadLine();
            boolString = boolString.ToLower();

            try
            {
                // Using bool-Parse
                bool stringToBooParse = bool.Parse(boolString);
                Console.Write("\nUsing bool.parse " + $"'{boolString}' --> {stringToBooParse}");

                //Using Convert-To-Int
                bool stringToBoolConvert = Convert.ToBoolean(boolString);

                Console.Write("\nUsing Convert.ToBoolean " + $"'{boolString}' --> {stringToBoolConvert}");

                //Using Int-Try-Parse
                bool stringToBoolTryParse;
                bool isParsable1 = bool.TryParse(boolString, out stringToBoolTryParse);

                if (isParsable1)
                {
                    Console.Write("\nUsing bool.TryParse " + $"'{boolString}' --> {stringToBoolTryParse}");
                }
                else
                    Console.WriteLine("\n\nCould not be parsed.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Please enter a valid bool value. " + e.Message);
                StringToBool();
            }
        }

        void Exercise1()
        {
            Console.Write("1 for Integer Conversion " +
                "\n2 for float Cnversion" +
                "\n3 for boolean conversion\n");
            Console.Write("\nEnter a number (1 | 2 | 3): ");
            string inputNumber = Console.ReadLine();

            if (inputNumber == "1")
            {
                StringToInteger();
            }
            else if (inputNumber == "2")
            {
                StringToFloat();
            }
            else if (inputNumber == "3")
            {
                StringToBool();
            }
            else
            {
                Console.WriteLine("Enter a valid input.");
                Exercise1();
            }

        }
        public Assignment1()
        {
            Console.Write("1 for Exercise 1 " +
                "\n2 for Exercise 2" +
                "\n3 for Exercise 3\n");
            Console.Write("\nEnter a number (1 | 2 | 3): ");
            string inputNumber = Console.ReadLine();

            if (inputNumber == "1")
            {
                Console.WriteLine("---------------- Exercise 1 ----------------\n");
                Exercise1();
            }
            else if (inputNumber == "2")
            {
                Console.WriteLine("\n\n---------------- Exercise 2 ----------------\n");
                Exercise2();
            }
            else if (inputNumber == "3")
            {
                Console.WriteLine("\n\n---------------- Exercise 3 ----------------\n");
                Exercise3();
            }
            else
            {
                Console.WriteLine("Enter a valid input.");
            }
        }
    }
}
