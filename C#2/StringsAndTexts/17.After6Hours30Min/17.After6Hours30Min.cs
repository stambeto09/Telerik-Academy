using System;
using System.Globalization;

class DateWithSixAndHalfHour
{
    static void Main()
    {
        DateTime date = new DateTime(2013, 06, 15, 13, 45, 30, 90);//въведедена дата
        string fmt1 = "h \\h m \\m";
        string fmt2 = @"h \h m \m";
        Console.WriteLine("{0} -> {1}", date, date.ToString(fmt1));//изпритвам на конзолата

        DateTime later1 = date.AddHours(6);//прибавам 6 часа
        DateTime later2 = later1.AddMinutes(30);//прибавам 30минути

        Console.WriteLine("The time after 6 hour is {0} -> {1}", later1, later1.ToString(fmt1));//изпринтвам на конзолата на въведената дата + 6 часа
        Console.WriteLine("The time after 6 hour and 30 minutes {0} -> {1}", later2, later2.ToString(fmt2));
        //изпринтвам на конзолата на въведената дата + 6 часа и 30 минути 
    }
}