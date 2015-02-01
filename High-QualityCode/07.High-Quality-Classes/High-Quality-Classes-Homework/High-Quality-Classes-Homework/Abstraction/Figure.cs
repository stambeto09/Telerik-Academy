using System;

namespace Abstraction
{
    abstract class Figure 
    {
        public Figure()
        {
        }

        public virtual double CalculatePerimeter()
        {
            return double.MinValue;
        }

        public virtual double CalculateSurface()
        {
            return double.MinValue;
        }
        

    }
}
