using System;


namespace DefiningClassesObjectsPartTwo
{
    public static class DistanceBetweenPoints
    {
        public static double CalculateDistanceBetweenPoints(Point firstPoint, Point secondPoint)
        {
            double result = 0;
            result = Math.Sqrt(Math.Pow((secondPoint.X - firstPoint.X), 2)
                    + Math.Pow((secondPoint.Y - firstPoint.Y), 2));
            return result;
        }
    }
}
