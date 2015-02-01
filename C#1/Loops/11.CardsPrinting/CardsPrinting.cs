using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.CardsPrinting
{
    class CardsPrinting
    {
        static void Main()
        {

            for (int card = 2; card <= 14; card++)
            {
                for (int paint = 1; paint <= 4; paint++)
                {
                    if (card <= 10)
                    {
                        Console.Write(card + " ");
                    }
                    else
                    {
                        switch (card)
                        {
                            case 11: Console.Write("Jack "); break;
                            case 12: Console.Write("Queen "); break;
                            case 13: Console.Write("King "); break;
                            case 14: Console.Write("Ace "); break;

                        }
                    }
                    switch (paint)
                    {
                        case 1: Console.WriteLine("spade"); break;
                        case 2: Console.WriteLine("heart"); break;
                        case 3: Console.WriteLine("diamond"); break;
                        case 4: Console.WriteLine("club"); break;
                    }

                }
            }
        }
    }
}
