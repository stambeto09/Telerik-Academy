using System;

namespace Methods
{
    class Methods
    {
        static double CalculateTriangleArea(double firstSide, double secondSide, double thirdSide)
        {
            bool areSidesPositive = (firstSide >= 0) || (secondSide >= 0) || (thirdSide >= 0);
            bool isSumGreater = (firstSide + secondSide > thirdSide) && (firstSide + thirdSide > secondSide) && (secondSide + thirdSide > firstSide);
            if (areSidesPositive && isSumGreater)
            {
                double halfOfPerimeter = (firstSide + secondSide + thirdSide) / 2;
                double surface = Math.Sqrt(halfOfPerimeter * (halfOfPerimeter - firstSide) * 
                    (halfOfPerimeter - secondSide) * (halfOfPerimeter - thirdSide));

                return surface;
            }

            throw new ArgumentException("Non-positive or sum of every 2 sides is not greater than the third one.");
        }

        static string ConvertDigitIntoWord(int number)
        {
            switch (number)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
            }

            return "Invalid number!";
        }

        static int FindMaxValue(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentException("The array parameter is not defined.");
            }

            int maxValue = int.MinValue;
            for (int index = 0; index < elements.Length; index++)
            {
                if (elements[index] > maxValue)
                {
                    maxValue = elements[index];
                }
            }
            return maxValue;
        }

        static void PrintNumberWithFormat(double number, string format)
        {
            if (format == "f")
            {
                Console.WriteLine("{0:f2}", number);
            }
            else if (format == "%")
            {
                Console.WriteLine("{0:p0}", number);
            }
            else if (format == "r")
            {
                Console.WriteLine("{0,8}", number);
            }
        }


        static double CalculateDistanceBetweenPoints(double firstPointX, double firstPointY, 
            double secondPointX, double secondPointY, out bool areHorizontal, out bool areVertical)
        {
            areHorizontal = (firstPointY == secondPointY);
            areVertical = (firstPointX == secondPointX);

            double distance = Math.Sqrt((secondPointX - firstPointX) * (secondPointX - firstPointX) + 
                (secondPointY - firstPointY) * (secondPointY - firstPointY));

            return distance;
        }

        static void Main()
        {
            Console.WriteLine(CalculateTriangleArea(3, 4, 5));
            
            Console.WriteLine(ConvertDigitIntoWord(5));
            
            Console.WriteLine(FindMaxValue(5, -1, 3, 2, 14, 2, 3));
            
            PrintNumberWithFormat(1.3, "f");
            PrintNumberWithFormat(0.75, "%");
            PrintNumberWithFormat(2.30, "r");

            bool areHorizontal = false; 
            bool areVertical = false;
            Console.WriteLine(CalculateDistanceBetweenPoints(3, -1, 3, 2.5, out areHorizontal, out areVertical));
            Console.WriteLine("Are points horizontal: " + areHorizontal);
            Console.WriteLine("Are points vertical: " + areVertical);

            Student peter = new Student() { FirstName = "Peter", LastName = "Ivanov" };
            peter.AdditionalInformation = "From Sofia, born at 17.03.1992";

            Student stella = new Student() { FirstName = "Stella", LastName = "Markova" };
            stella.AdditionalInformation = "From Vidin, gamer, high results, born at 03.11.1993";

            Console.WriteLine("{0} older than {1} -> {2}",
                peter.FirstName, stella.FirstName, peter.CompareByDateOfBirth(stella));
        }
    }
}
