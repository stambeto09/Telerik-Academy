using System;
using System.Linq;

namespace _04.CalcuatingTheSurfaceOfATriangle
{
	class CalculatingTheSurfaceOfATriangle
	{
		static void CalculateSurfaceByThreeSides()
		{
			//Intializing the sides;
			Console.Write("Enter your first side: ");
			decimal firstSide = decimal.Parse(Console.ReadLine());
			Console.Write("Enter your second side: ");
			decimal secondSide = decimal.Parse(Console.ReadLine());
			Console.Write("Enter your third side: ");
			decimal thirdSide = decimal.Parse(Console.ReadLine());

			//Checking if they are available for triangle sides;
			if ((firstSide+secondSide<thirdSide) || (firstSide+thirdSide<secondSide) || (secondSide+thirdSide<firstSide))
			{

				Console.WriteLine("The sum of each two sides must be greater than the third one. ");

			}


			else if ((firstSide<=0)||(secondSide<=0)||(secondSide<=0))
			{ 

				Console.WriteLine("The sides in the triangle must be positive numbers.");

			}

			else
			{
				decimal halfPerimeter = (firstSide + secondSide + thirdSide) / 2;
				decimal surface =(decimal) Math.Sqrt((double)(halfPerimeter * (halfPerimeter - firstSide) * (halfPerimeter - secondSide) * (halfPerimeter - thirdSide)));

				Console.WriteLine("The surface is equal to: {0}",surface);
			}

		}

		static void CalculateSurfaceBySideAndAltitude()
		{
			Console.Write("Enter a length of the side: ");
			decimal side = decimal.Parse(Console.ReadLine());
			Console.Write("Enter a length of the altitude: ");
			decimal altitude = decimal.Parse(Console.ReadLine());

			if ((side <= 0) || (altitude <= 0))
			{

				Console.WriteLine("The side or altitude must be postive number.");

			}
			else
			{

				decimal surface = ((side * altitude) / 2);
				Console.WriteLine("The surface of the triangle is equal to: {0}.",surface);

			}

		}

		static void CalculateSurfaceByTwoSidesAndAngle()
		{
			Console.Write("Enter your first side: ");
			decimal firstSide = decimal.Parse(Console.ReadLine());
			Console.Write("Enter your second side: ");
			decimal secondSide = decimal.Parse(Console.ReadLine());
			Console.Write("Enter your angle in degrees: ");
			decimal angleInDegree = decimal.Parse(Console.ReadLine());

			if ((firstSide<=0)||(secondSide<=0))
			{

				Console.WriteLine("The sides of the trianlge must be positive values. ");

			}

			decimal surfaceOfTriangle = 0;
			decimal numerator = firstSide * secondSide * Math.Sin((double)(angleInDegree));
			surfaceOfTriangle = numerator / 2;

			Console.WriteLine(" The surface of the triangle is equal to: {0}",surfaceOfTriangle);
		}


		static void Main()
		{
			//Choose your destiny;
			Console.WriteLine("Enter 1, 2 or 3 to for: ");
			Console.WriteLine("1) calculating the surface of the triangle by given three sides.");
			Console.WriteLine("2) calculating the surface ot the triangle by side and altitude to it." );
			Console.WriteLine("3) calculating the surface of the triangle by two sides and agle between them.");

			Console.Write("Enter your choice here: ");
			int choice = int.Parse(Console.ReadLine());



			if (choice==1)
			{
				CalculateSurfaceByThreeSides();
			}
			else if (choice==2)
			{
				CalculateSurfaceBySideAndAltitude();
			}
			else if (choice==3)
			{
				CalculateSurfaceByTwoSidesAndAngle();
			}
			else
			{
				Console.WriteLine("Enter a valid number.");
			}
	 

		}
	}
}
