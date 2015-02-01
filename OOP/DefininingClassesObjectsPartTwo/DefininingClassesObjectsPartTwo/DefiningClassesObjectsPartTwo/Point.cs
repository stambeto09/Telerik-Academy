using System;
using System.Linq;


namespace DefiningClassesObjectsPartTwo
{

        public struct Point
        {
            public int X { get; set; }
            public int Y { get; set; }
            public int Z{ get; set; }
            private static readonly Point startCoordinate = new Point(0, 0, 0);
           
            public override string ToString()
            {
                string output = "X="+X+"\nY="+Y+"\nZ="+Z;
                return output;
            }

            //Constructors
            public Point(int x, int y, int z):this()
            {
                this.X = x;
                this.Y = y;
                this.Z = z;
            }

            public static Point ZeroCoordinate()
            {
                return startCoordinate;
            }
        }
    
}
