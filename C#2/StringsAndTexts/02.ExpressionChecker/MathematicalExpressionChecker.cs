using System;

class MathematicalExpressionChecker
{
    static bool CheckForCorrectExpression(string mathExpression)
    {
        char leftBracket = '(';
        char rightBracket = ')';
        int leftBracketCounter = 0;
        int rightBracketCounter = 0;
        int substraction = 0;

        for (int index = 0; index < mathExpression.Length; index++)
        {
            if (mathExpression[index] == leftBracket)
            {
                leftBracketCounter++;
            }
            else if (mathExpression[index]==rightBracket)
            {
                rightBracketCounter++;
            }
        }

        substraction = leftBracketCounter - rightBracketCounter;
        if (substraction==0)
        {
            return true;
        }

        return false;
    }
    static void Main()
    {
        Console.Write("Enter your mathematical expression: ");
        string expression = Console.ReadLine();

        bool isCorrectExpression=CheckForCorrectExpression(expression);
        Console.WriteLine("Is your expression correct? {0}",isCorrectExpression);
        
    }
}
