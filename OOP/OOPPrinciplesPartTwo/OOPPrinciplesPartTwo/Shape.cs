using System;
using System.Linq;

namespace OopPrinciplesPartTwo
{
    public abstract class Shape
    {
        private decimal width;
        private decimal height;

        public decimal Width 
        { 
            get
            {
                return this.width;
            }
            set
            {
                if ((value==null) || (value<=0))
                {
                    throw new ArgumentException("Please, enter a valid value for width.");
                }

                this.width = value;
            }
 
        }

        public decimal Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if ((value==null)||(value<0))
                {
                    throw new ArgumentException("Please, enter a valid value for height!");
                }

                this.height = value;
            }
        }

        public Shape()
        {

        }

        public Shape(decimal height):this()
        {
            this.Height = height;
        }

        public Shape(decimal height, decimal width):this()
        {
            this.Width = width;
            this.Height = height;
        }

        public abstract decimal CalculateSurface();
       


        public static void Main()
        {
            Triangle triangle = new Triangle();
            triangle.Height = 15;
            triangle.width = 13;
            Console.WriteLine(triangle.CalculateSurface());

            Rectangle rectangle = new Rectangle();
            rectangle.Width = 15;
            rectangle.Height = 13;
            Console.WriteLine(rectangle.CalculateSurface());

            Rectangle testRect = new Rectangle(15, 13);
            Console.WriteLine(testRect.Width);
            Console.WriteLine(testRect.Height);

            Circle circle = new Circle(12.3);
            Console.WriteLine(circle.CalculateSurface());
        }
    }
}
