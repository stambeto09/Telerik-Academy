using System;
using System.Collections.Generic;
using System.Linq;

namespace ExtensionMethods
{
    public static class ExtensionsIEnumerable
    {
        public static T CalculateSum<T>(this IEnumerable<T> list)
        {
            dynamic sumResult = 0;
            foreach (var item in list)
            {
                sumResult += item;
            }
            return sumResult;
        }

        public static T CalculateProduct<T>(this IEnumerable<T> list)
        {
            dynamic product = 1;
            foreach (var item in list)
            {
                product *= item;
            }
            return product;
        }

        public static T FindMinValue<T>(this IEnumerable<T> list)
        {
            T[] array=list.ToArray();
            Array.Sort(array);
            return array[0];
        }

        public static T FindMaxValue<T>(this IEnumerable<T> list)
        {
            T[] array = list.ToArray();
            Array.Sort(array);
            return array[array.Length - 1];
        }

        public static T CalculateAverage<T>(this IEnumerable<T>list)
        {
            T[] array = list.ToArray();
            int length = array.Length;
            dynamic numerator = 0;
            for (int index = 0; index < length; index++)
            {
                numerator += array[index];
            }
            return numerator / length;
        }

    }
}
