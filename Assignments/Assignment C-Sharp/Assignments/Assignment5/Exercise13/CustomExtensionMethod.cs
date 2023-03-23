using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_C_Sharp.Assignments.Assignment5.Exercise13
{
    public static class CustomExtensionMethod
    {
        // CustomALL
        public static bool CustomAll<T>(this IEnumerable<T> list, Func<T, bool> condition)
        {
            return list.All(condition);
        }

        // CustomAny
        public static bool CustomAny<T>(this IEnumerable<T> list, Func<T, bool> condition)
        {
            return list.Any(condition);
        }

        // CustomMax
        public static TResult CustomMax<T, TResult>(this IEnumerable<T> list, Func<T, TResult> func)
        {
            return list.Max(func);
        }

        // CustomMin
        public static TResult CustomMin<T, TResult>(this IEnumerable<T> list, Func<T, TResult> func)
        {
            return list.Min(func);
        }

        //CustomWhere
        public static IEnumerable<T> CustomWhere<T>(this IEnumerable<T> list, Func<T, bool> condition)
        {
            return list.Where(condition);
        }

        //CustomSelect
        public static IEnumerable<T> CustomSelect<T>(this IEnumerable<T> list, Func<T, bool> condition)
        {
            return list.Where(condition);
        }
    }
}
