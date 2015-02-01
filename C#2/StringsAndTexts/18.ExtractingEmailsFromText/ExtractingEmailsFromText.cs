using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

class ExtractEmailsFromText
{
    //Write a program for extracting all email addresses from given text. All substrings that match the format <identifier>@<host>…<domain> should be recognized as emails.

    static void Main()
    {
        string text = @"niceandsimple@example.com very.common@example.com a.little.lengthy.but.fine@dept.example.com disposable.style.email.with+symbol@example.com user@[IPv6:2001:db8:1ff::a0b:dbd0] ""much.more unusual""@example.com ""very.unusual.@.unusual.com""@example.com ""very.(),:;<>[]\"".VERY.\""very@\\ \""very\"".unusual""@strange.example.com postbox@com (top-level domains are valid hostnames) admin@mailserver1 (local domain name with no TLD) !#$%&'*+-/=?^_`{}|~@example.org ""()<>[]:,;@\\\""!#$%&'*+-/=?^_`{}| ~.a""@example.org "" ""@example.org (space between the quotes)";

        string[] splitText = text.Split(' ');
        List<string> emailsList = new List<string>();

        for (int i = 0; i < splitText.Length; i++)
        {
            if (Regex.IsMatch(splitText[i], @"[\w.!#$%&'*=?^_`{|}~""(),:;<>@[\]]{1,64}@[\w]{1,253}"))
            {
                emailsList.Add(splitText[i]);
            }
        }

        foreach (string email in emailsList)
        {
            Console.WriteLine(email);
        }
    }
}