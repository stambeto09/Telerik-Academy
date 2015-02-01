using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CommonTypeSystem
{
    public class BitArray64 : IEnumerable<int>
    {
        private ulong value;

        public ulong Value
        {
            get
            {
                return this.value;
            }
            set
            {
                this.value = value;
            }
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public IEnumerator<int> GetEnumerator()
        {
            int[] bits = this.ConvertToBits();

            for (int i = 0; i < bits.Length; i++)
            {
                yield return bits[i];
            }
        }

        public static bool operator ==(BitArray64 firstNumber, BitArray64 secondNumber)
        {

            return BitArray64.Equals(firstNumber, secondNumber);
        }

        public static bool operator !=(BitArray64 firstNumber, BitArray64 secondNumber)
        {
            return BitArray64.Equals(firstNumber, secondNumber);
        }

        private int[] ConvertToBits()
        {
            ulong value = this.value;

            int[] bits = new int[64];
            int counter = 63;

            while (value != 0)
            {
                bits[counter] = (int)value % 2;
                value /= 2;
                counter--;
            }

            do
            {
                bits[counter] = 0;
                counter--;
            }
            while (counter != 0);

            return bits;
        }

        private bool IndexChecker(int index)
        {
            //Checking if indexer is in range;
            if (index < 0 || index > 63)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int this[int index]
        {
            get
            {
                if (IndexChecker(index))
                {
                    throw new System.IndexOutOfRangeException();
                }

                int[] bits = this.ConvertToBits();
                return bits[index];
            }
        }

    }
}
