using System;

namespace CohesionAndCoupling
{
    static class Utils
    {
        public static double Width { get; set; }
        public static double Height { get; set; }
        public static double Depth { get; set; }

        public static double Calculate2DDistance(double firstPointX, double firstPointY, double secondPointX, double secondPointY)
        {
            double distance = Math.Sqrt((secondPointX - firstPointX) * (secondPointX - firstPointX) + (secondPointY - firstPointY) * (secondPointY - firstPointY));
            return distance;
        }

        public static double Calculate3DDistance(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
            return distance;
        }

        public static double CalculateVolume()
        {
            double volume = Width * Height * Depth;
            return volume;
        }

        public static double CalculateDiagonalXYZ()
        {
            double distance = Calculate3DDistance(0, 0, 0, Width, Height, Depth);
            return distance;
        }

        public static double CalculateDiagonalXY()
        {
            double distance = Calculate2DDistance(0, 0, Width, Height);
            return distance;
        }

        public static double CalculateDiagonalXZ()
        {
            double distance = Calculate2DDistance(0, 0, Width, Depth);
            return distance;
        }

        public static double CalculateDiagonalYZ()
        {
            double distance = Calculate2DDistance(0, 0, Height, Depth);
            return distance;
        }
    }
}
