using System;
using System.Linq;

namespace DefiningClassesObjectsPartTwo
{
    public class GenericList<T>
    {
        const int DefaultCapacity = 12;
        private T[] elements;
        private int count;

        public GenericList(int capacity)
        {
            if (capacity<2)
            {
                throw new IndexOutOfRangeException("Index was outside of the range!");
            }
            this.count = 0;
            this.elements = new T[capacity];
        }

        public GenericList()
            : this(DefaultCapacity)
        {
        }

        public int Count
        {
            get
            {
                return this.count;
            }
        }

        public void AddElement(T element)
        {
            if (count == elements.Length)
            {
               this.elements=ResizingArray();
            }
            this.elements[count] = element;
            count++;
        }

        public T this [int index]
        {
            get
            {
                if ((index<0)||(index>this.count))
                {
                    throw new IndexOutOfRangeException("Index was outside of the range.");
                }
                return this.elements[index];
            } 
        }
        public int Capacity
        {
            get
            {
                return this.elements.Length;
            }
        }
        public void DeleteElement(T element, int indexOfElement)
        {
            if (indexOfElement >= DefaultCapacity)
            {
                throw new IndexOutOfRangeException("Index was outside of array's range.");
            }
            else
            {
                T[] cloneArray = new T[elements.Length - 1];
                for (int index = 0; index < cloneArray.Length; index++)
                {
                    if (index > indexOfElement)
                    {
                        cloneArray[index] = elements[index + 1];
                    }
                    else if (indexOfElement < indexOfElement)
                    {
                        cloneArray[index] = elements[index];
                    }
                    else if (index == indexOfElement)
                    {
                    }
                }
            }
        }

        public void InsertingElement(T element, int indexOfElement)
        {
            T[] newArray = new T[elements.Length + 1];
            for (int index = 0; index < newArray.Length; index++)
            {
                if (index < indexOfElement)
                {
                    newArray[index] = elements[index];
                }
                else if (index == indexOfElement)
                {
                    newArray[index] = element;
                }
                else
                {
                    newArray[index] = elements[index - 1];
                }
            }
        }

        //public T FindningElementByValue(T element)
        //{

        //    for (int index = 0; index < elements.Length; index++)
        //    {
        //        if (elements[index] ==element)
        //        {
        //            element = elements[index];
        //        }
        //    }
        //    return element;
        //}
        public override string ToString()
        {
            string concatenated = string.Join(",", elements.Select(x => x.ToString()).ToArray());
            return concatenated;
        }
        public void ClearTheList()
        {
            elements = new T[elements.Length];
        }

        public T[] ResizingArray()
        {
            T[] newArray=new T[elements.Length*2];
            for (int index = 0; index < elements.Length; index++)
			{
			    newArray[index]=elements[index];
			}
            return newArray;
        }

        public T Min<T>() where T : IComparable<T>, IComparable
        {
            dynamic min = elements.Min();
            return min;
        }

        public T Max<T>() where T: IComparable<T>,IComparable
        {
            dynamic max = elements.Max();
            return max;
        }
    }
}
