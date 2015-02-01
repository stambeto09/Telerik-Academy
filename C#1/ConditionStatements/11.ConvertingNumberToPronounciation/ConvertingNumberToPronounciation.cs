using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ConvertingNumberToPronounciation
{
    class ConvertingNumberToPronounciation
    {
        static void Main()
        {
            Console.Write(" Enter a number in interval of [0;999]  : ");
            int number = int.Parse(Console.ReadLine());
            int hundred = 0;
            int tens = 0;
            int units = 0;

            hundred = number / 100;
            tens = (number % 100) / 10;
            units = (number % 100) % 10;

            if (hundred==0)
            {
                Console.WriteLine("zero");
            }
            
           

            if (number<0 || number>999)
            {
                Console.WriteLine("The number is not in interval [0;999] !");
            }
            else
            {
                //Converting hundreds
                switch (hundred)
                {
                    case 1: Console.Write(" One hundred"); break;
                    case 2: Console.Write(" Two hundred"); break;
                    case 3: Console.Write(" Three hundred"); break;
                    case 4: Console.Write(" Four hundred"); break;
                    case 5: Console.Write(" Five hundred"); break;
                    case 6: Console.Write(" Six hundred"); break;
                    case 7: Console.Write(" Seven hundred"); break;
                    case 8: Console.Write(" Eight hundred"); break;
                    case 9: Console.Write(" Nine hundred"); break;
                
                }
                //End of converting hundreds

                //Converting tens

                    //Converting situation, when tens are equal to 0 and units are different to 0
                if (tens==0 && units!=0)
                {
                    
                    switch (units)
                    {
                        case 1:Console.WriteLine(" one");break;
                        case 2: Console.WriteLine(" two"); break;
                        case 3: Console.WriteLine(" three"); break;
                        case 4: Console.WriteLine(" four"); break;
                        case 5: Console.WriteLine(" five"); break;
                        case 6: Console.WriteLine(" six"); break;
                        case 7: Console.WriteLine(" seven"); break;
                        case 8: Console.WriteLine(" eight"); break;
                        case 9: Console.WriteLine(" nine"); break;

                    }
                    }
                    //Converting situation, when tens are equal to 0 and units are equal to 0
                    if (tens==0 && units==0)
                    {
                        Console.WriteLine(".");
                    }
                    
                    //Converting the situation, when we have tens=1

                    if (tens == 1)
                    {
                        switch (units)
                        {
                            case 0: Console.WriteLine(" and ten"); break;
                            case 1: Console.WriteLine(" and eleven"); break;
                            case 2: Console.WriteLine(" and twelve"); break;
                            case 3: Console.WriteLine(" and thirteen"); break;
                            case 4: Console.WriteLine(" and fourteen"); break;
                            case 5: Console.WriteLine(" and fifteen"); break;
                            case 6: Console.WriteLine(" and sixteen"); break;
                            case 7: Console.WriteLine(" and seventeen"); break;
                            case 8: Console.WriteLine(" and eighteen"); break;
                            case 9: Console.WriteLine(" and nineteen"); break;

                        }
                    }

                    //Converting the situation when we have tens=2

                    if (tens==2)
                    {
                        Console.Write(" twenty ");
                        switch (units)
                        {
                            case 0: Console.WriteLine(); break;
                            case 1: Console.WriteLine(" one"); break;
                            case 2: Console.WriteLine(" two"); break;
                            case 3: Console.WriteLine(" three"); break;
                            case 4: Console.WriteLine(" four"); break;
                            case 5: Console.WriteLine(" five"); break;
                            case 6: Console.WriteLine(" six"); break;
                            case 7: Console.WriteLine(" seven"); break;
                            case 8: Console.WriteLine(" eight"); break;
                            case 9: Console.WriteLine(" nine"); break;
                        }

                    }
                    //Converting the situation when we have tens=3
                    if (tens == 3)
                    {
                        Console.Write(" thirty ");
                        switch (units)
                        {
                            case 0: Console.WriteLine(); break;
                            case 1: Console.WriteLine(" one"); break;
                            case 2: Console.WriteLine(" two"); break;
                            case 3: Console.WriteLine(" three"); break;
                            case 4: Console.WriteLine(" four"); break;
                            case 5: Console.WriteLine(" five"); break;
                            case 6: Console.WriteLine(" six"); break;
                            case 7: Console.WriteLine(" seven"); break;
                            case 8: Console.WriteLine(" eight"); break;
                            case 9: Console.WriteLine(" nine"); break;
                        }
                    }
                        //Converting the situation when we have tens=4
                        if (tens == 4)
                        {
                            Console.Write(" fourty ");
                            switch (units)
                            {
                                case 0: Console.WriteLine(); break;
                                case 1: Console.WriteLine(" one"); break;
                                case 2: Console.WriteLine(" two"); break;
                                case 3: Console.WriteLine(" three"); break;
                                case 4: Console.WriteLine(" four"); break;
                                case 5: Console.WriteLine(" five"); break;
                                case 6: Console.WriteLine(" six"); break;
                                case 7: Console.WriteLine(" seven"); break;
                                case 8: Console.WriteLine(" eight"); break;
                                case 9: Console.WriteLine(" nine"); break;
                            }
                        }

                        //Converting the situation when we have tens=5
                        if (tens == 5)
                        {
                            Console.Write(" fifty ");
                            switch (units)
                            {
                                case 0: Console.WriteLine(); break;
                                case 1: Console.WriteLine(" one"); break;
                                case 2: Console.WriteLine(" two"); break;
                                case 3: Console.WriteLine(" three"); break;
                                case 4: Console.WriteLine(" four"); break;
                                case 5: Console.WriteLine(" five"); break;
                                case 6: Console.WriteLine(" six"); break;
                                case 7: Console.WriteLine(" seven"); break;
                                case 8: Console.WriteLine(" eight"); break;
                                case 9: Console.WriteLine(" nine"); break;
                            }
                        }

                        //Converting the situation when we have tens=6
                        if (tens == 6)
                        {
                            Console.Write(" sixty ");
                            switch (units)
                            {
                                case 0: Console.WriteLine(); break;
                                case 1: Console.WriteLine(" one"); break;
                                case 2: Console.WriteLine(" two"); break;
                                case 3: Console.WriteLine(" three"); break;
                                case 4: Console.WriteLine(" four"); break;
                                case 5: Console.WriteLine(" five"); break;
                                case 6: Console.WriteLine(" six"); break;
                                case 7: Console.WriteLine(" seven"); break;
                                case 8: Console.WriteLine(" eight"); break;
                                case 9: Console.WriteLine(" nine"); break;
                            }
                        }

                        //Converting the situation when we have tens=7
                        if (tens == 7)
                        {
                            Console.Write(" seventy ");
                            switch (units)
                            {
                                case 0: Console.WriteLine(); break;
                                case 1: Console.WriteLine(" one"); break;
                                case 2: Console.WriteLine(" two"); break;
                                case 3: Console.WriteLine(" three"); break;
                                case 4: Console.WriteLine(" four"); break;
                                case 5: Console.WriteLine(" five"); break;
                                case 6: Console.WriteLine(" six"); break;
                                case 7: Console.WriteLine(" seven"); break;
                                case 8: Console.WriteLine(" eight"); break;
                                case 9: Console.WriteLine(" nine"); break;
                            }
                        }
                        //Converting the situation when we have tens=8
                        if (tens == 8)
                        {
                            Console.Write(" eighty ");
                            switch (units)
                            {
                                case 0: Console.WriteLine(); break;
                                case 1: Console.WriteLine(" one"); break;
                                case 2: Console.WriteLine(" two"); break;
                                case 3: Console.WriteLine(" three"); break;
                                case 4: Console.WriteLine(" four"); break;
                                case 5: Console.WriteLine(" five"); break;
                                case 6: Console.WriteLine(" six"); break;
                                case 7: Console.WriteLine(" seven"); break;
                                case 8: Console.WriteLine(" eight"); break;
                                case 9: Console.WriteLine(" nine"); break;
                            }
                        }
                        //Converting the situation when we have tens=9
                        if (tens == 9)
                        {
                            Console.Write(" ninety ");
                            switch (units)
                            {
                                case 0: Console.WriteLine(); break;
                                case 1: Console.WriteLine(" one"); break;
                                case 2: Console.WriteLine(" two"); break;
                                case 3: Console.WriteLine(" three"); break;
                                case 4: Console.WriteLine(" four"); break;
                                case 5: Console.WriteLine(" five"); break;
                                case 6: Console.WriteLine(" six"); break;
                                case 7: Console.WriteLine(" seven"); break;
                                case 8: Console.WriteLine(" eight"); break;
                                case 9: Console.WriteLine(" nine"); break;
                            }
                        }




                    }
                }
            }
        }
    

