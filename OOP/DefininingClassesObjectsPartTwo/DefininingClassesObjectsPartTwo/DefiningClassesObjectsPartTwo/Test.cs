using System;
using System.Linq;


namespace DefiningClassesObjectsPartTwo
{
    public class Test
    {
        static void Main()
        {
            GenericList<int> list = new GenericList<int>(10);
            for (int index = 0; index < 10; index++)
            {
                list.AddElement(index);
            }
            Console.WriteLine();
            Console.WriteLine(list.Capacity);
            Console.WriteLine();
            for (int index = 0; index < list.Count; index++)
            {
                Console.WriteLine(list[index]);
            }

            list.AddElement(5);
            list.AddElement(10);

            for (int index = 0; index < list.Count; index++)
            {
                Console.WriteLine(list[index]);
            }

            Console.WriteLine();
            Console.WriteLine(list.Capacity);
            Console.WriteLine();


        }
    }
}
