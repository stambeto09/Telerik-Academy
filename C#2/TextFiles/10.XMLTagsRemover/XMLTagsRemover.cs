using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;

//Write a program that extracts from given XML file all the text 
//without the tags. Example:
//<?xml version="1.0"><student><name>Pesho</name><age>21</age>
//<interests count="3"><interest> Games</instrest><interest>C#
//</instrest><interest> Java</instrest></interests></student>

class XMLFileWithoutTags
{
    static void RemovingTags(string line)
    {
        List<int> indexOpenTag = new List<int>();
        List<int> indexCloseTag = new List<int>();
        int indexOpen = line.IndexOf('<', 0);
        indexOpenTag.Add(indexOpen);
        int indexClose = line.IndexOf('>', 0);
        indexCloseTag.Add(indexClose);

        while (indexClose != -1)
        {
            indexOpen = line.IndexOf('<', indexOpen + 1);
            indexOpenTag.Add(indexOpen);
            indexClose = line.IndexOf('>', indexClose + 1);
            indexCloseTag.Add(indexClose);
        }

        int difference = 0;
        int currDifference = 0;
        for (int i = 0; i < indexOpenTag.Count - 1; i++)
        {
            indexOpenTag[i] = indexOpenTag[i] - difference;
            indexCloseTag[i] = indexCloseTag[i] - difference;
            currDifference = ((int)indexCloseTag[i]) - ((int)indexOpenTag[i]) + 1;
            difference += currDifference;
            line = line.Remove(indexOpenTag[i], currDifference);
        }

        Console.WriteLine(line);

        StreamReader reader = new StreamReader(@"../../XMLText.txt");
        string line = reader.ReadLine();
        using (reader)
        {
            while (line != null)
            {
                RemovingTags(line);
                line = reader.ReadLine();
            }
        }
    }
}