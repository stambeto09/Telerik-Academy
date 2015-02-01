using System;

namespace CohesionAndCoupling
{
    class UtilsExamples
    {
        static void Main()
        {
            Console.WriteLine(File.GetFileExtension("example"));
            Console.WriteLine(File.GetFileExtension("example.pdf"));
            Console.WriteLine(File.GetFileExtension("example.new.pdf"));

            Console.WriteLine(File.GetFileName("example"));
            Console.WriteLine(File.GetFileName("example.pdf"));
            Console.WriteLine(File.GetFileName("example.new.pdf"));

            Console.WriteLine("Distance in the 2D space = {0:f2}",
                Utils.Calculate2DDistance(1, -2, 3, 4));
            Console.WriteLine("Distance in the 3D space = {0:f2}",
                Utils.Calculate3DDistance(5, 2, -1, 3, -6, 4));

            Utils.Width = 3;
            Utils.Height = 4;
            Utils.Depth = 5;
            Console.WriteLine("Volume = {0:f2}", Utils.CalculateVolume());
            Console.WriteLine("Diagonal XYZ = {0:f2}", Utils.CalculateDiagonalXYZ());
            Console.WriteLine("Diagonal XY = {0:f2}", Utils.CalculateDiagonalXY());
            Console.WriteLine("Diagonal XZ = {0:f2}", Utils.CalculateDiagonalXZ());
            Console.WriteLine("Diagonal YZ = {0:f2}", Utils.CalculateDiagonalYZ());
        }
    }
}
