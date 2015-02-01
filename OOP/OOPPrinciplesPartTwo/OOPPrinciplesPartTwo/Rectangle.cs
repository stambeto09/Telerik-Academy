using System;
using System.Linq;

namespace OopPrinciplesPartTwo
{
    public class Rectangle : Shape
    {
        public Rectangle()
        {

        }

        public Rectangle(decimal height):base(height)
        {
            
        }

        public Rectangle(decimal height, decimal width):base(height,width)
        {
            
        }

        public override decimal CalculateSurface()
        {
            decimal surface=1;
            surface = base.Height * base.Width;
            return surface;
        }
    }
}
