using System;
using System.Linq;

namespace VariablesDataExpressionsConstants
{
    public class Size
    {
        private double width;
        private double height;
        public Size(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The width can't be non-positive number.");
                }
                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The height can't be non-positive number.");
                }
                this.height = value;
            }
        }

        public static Size GetRotatedSize(Size s, double angleOfTheFigureThatWillBeRotaed)
        {
            double rotatedWidth = Math.Abs(Math.Cos(angleOfTheFigureThatWillBeRotaed)) * s.Width +
                Math.Abs(Math.Sin(angleOfTheFigureThatWillBeRotaed)) * s.Height;
            double rotatedHeight = Math.Abs(Math.Sin(angleOfTheFigureThatWillBeRotaed)) * s.Width +
                Math.Abs(Math.Cos(angleOfTheFigureThatWillBeRotaed)) * s.Height;
            Size rotatedSize = new Size(rotatedWidth, rotatedHeight);

            return rotatedSize;
        }

        static void Main(string[] args)
        {

        }
    }
}
