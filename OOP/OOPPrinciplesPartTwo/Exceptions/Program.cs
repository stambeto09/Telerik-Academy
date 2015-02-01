using System;
using System.Linq;
namespace Exceptions
{
    class InvalidException<T> : ApplicationException
    {
        private T start;
        private T end;

        public T Start 
        {
            get
            {
                return this.start;
            }
            set
            {
                this.start = value;
            }
        }

        public T End
        {
            get
            {
                return this.end;
            }
            set
            {
                this.end = value;
            }
        }

        public InvalidException(string msg, T min, T max):base(msg)
        {
            this.Start = min;
            this.End = max;
        }
        
    }
}
