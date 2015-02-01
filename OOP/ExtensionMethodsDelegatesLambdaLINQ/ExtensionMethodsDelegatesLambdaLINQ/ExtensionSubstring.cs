using System;
using System.Linq;
using System.Text;

namespace ExtensionMethods
{
    public static class ExtensionSubstring
    {
        public static StringBuilder Substring(this StringBuilder stringBuilder, int position, int length)
        {
            StringBuilder result = new StringBuilder();

            while (length >= 1)
            {
                try
                {
                    result.Append(stringBuilder[position]);
                }
                catch (IndexOutOfRangeException)
                {
                    Console.Error.WriteLine("Index was outside of the range!");
                }
                position++;
                length--;
            }
            return result;
        }
    }
}
