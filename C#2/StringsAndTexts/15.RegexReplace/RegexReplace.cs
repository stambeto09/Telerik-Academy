using System;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;

class RegexReplace
{
    static void Main(string[] args)
    {
        string Text = "<p>Please visit <a href=\"http://academy.telerik. com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";
        string strat = "<a href=\"";
        string strartEND = "\">";
        string End = "</a>";
        string replace = Regex.Replace(Text, strat, "[URL=http:");
        replace = Regex.Replace(replace, strartEND, "]");
        replace = Regex.Replace(replace, End, "[/URL]:");
        Console.WriteLine(replace);
    }
}