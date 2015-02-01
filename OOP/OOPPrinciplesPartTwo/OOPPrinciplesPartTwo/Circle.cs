using System;
using System.Linq;

namespace OopPrinciplesPartTwo
{
    public class Circle : Shape
    {
        private double r;   
        private const double Pi = Math.PI;

        public double R 
        {
            get
            {
                return this.r;
            }
            set
            {
                if (value<=0)
                {
                    throw new ArgumentException("The radius can not be non-positive number");
                }

                this.r = value;
            }
        }

        public Circle()
        {

        }

        public Circle(double r)
        {
            this.R = r;
        }
        public override decimal CalculateSurface()
        {
            double surface = 1;
            surface = Pi * (Math.Pow(r, 2));
            return (decimal)surface;
        }
    }
}
