//Write a program that extracts from a given text all dates that match the format DD.MM.YYYY. Display them in the standard date format for Canada.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        string text = "Begin date 05.04.2013 end date 04.10.2013  is not date 55.66.8974";

        string pattern = @"\b\d{2}(.)\d{2}(.)\d{4}";
        Match m = Regex.Match(text, pattern);
        Regex r = new Regex(pattern);
        MatchCollection matches = r.Matches(text);
        foreach (Match ma in matches)
        {
            Console.WriteLine(ma.ToString());
            try
            {
                DateTime dt = DateTime.ParseExact(ma.ToString(), "dd.mm.yyyy", new CultureInfo("en-CA"));
                Console.WriteLine(dt.ToString());
            }
            catch (System.FormatException fe)
            {
                Console.WriteLine(fe.Message);
            }
        }

    }
}