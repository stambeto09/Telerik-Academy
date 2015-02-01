using System;
using System.Linq;


namespace OopPrinciplesPartTwo
{
    public class Triangle : Shape
    {

        public Triangle()
        {

        }

        public Triangle(decimal height, decimal width):base(height,width)
        {

        }


        public override decimal CalculateSurface()
        {
            decimal surface = 1;
            surface = base.Height * (base.Width * 2);
            return surface;
            //height*width/2
        }
    }
}
