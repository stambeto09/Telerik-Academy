using System;
using System.Collections.Generic;
namespace DefiningClassesObjectsPartTwo
{
    public class Path
    {
        public List<Point> path = new List<Point>();

        public List<Point> PathConstructor 
        { 
            get
            {
               return this.path; 
            }
            set
            {
                this.path = value;
            }
        }

        public void AddPoint(Point newPoint)
        {
            PathConstructor.Add(newPoint);
        }

    }
}
