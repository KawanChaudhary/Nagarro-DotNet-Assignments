    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_C_Sharp.Assignments.Assignment5.Exercise13
{
    class Delegates_Exercise13
    {
        private void Print(IEnumerable<int> list)
        {
            foreach (int num in list)
                Console.Write(num + " ");
            Console.WriteLine();
        }

        public Delegates_Exercise13()
        {
            System.Random random = new System.Random();
            // IEnumerable<int> Numbers = new List<int>() { 21, 69, 61, 27, 11, 18, 45, 29, 93, 67, 51, 5, 26, 66, 62, 50, 10, 8, 73, 40 };
            int size = 30;
            var Numbers = new int[size];
            Console.Write("\nAll Numbers: ");
            for (int i = 0; i < size; i++)

            {
                Numbers[i] = random.Next(0, 100);
                Console.Write($"{Numbers[i]} ");
            }
            // CustomAll - Should work as All operation of LINQ, with custom logic passed as delegate
            Console.Write("\n\nCustomAll (value > 5) - ");
            Console.WriteLine(Numbers.CustomAll(value => value > 5));

            // CustomAny - Should work as Any operation of LINQ, with custom logic passed as delegate
            Console.Write("CustomAny (value == 5) - ");
            Console.WriteLine(Numbers.CustomAny(value => value == 5));

            //  CustomMax - Should work as Max operation of LINQ, with custom logic passed as delegate
            Console.Write("CustomMax (Max Value) - ");
            Console.WriteLine(Numbers.CustomMax(value => value));

            //  CustomMin - Should work as Max operation of LINQ, with custom logic passed as delegate
            Console.Write("CustomMin (Min Value) - ");
            Console.WriteLine(Numbers.CustomMin(value => value));

            //  CustomWhere - Should work as Where operation of LINQ, with custom logic passed as delegate
            Console.Write("CustomWhere (Value > 5) - ");
            Print(Numbers.CustomWhere(value => value > 5));

            //  CustomSelect - Should work as Select operation of LINQ, with custom logic passed as delegate
            Console.Write("CustomSelect (Value < 50) - ");
            Print(Numbers.CustomSelect(value => value < 50));

        }
    }
}
