﻿using System.Text.RegularExpressions;
namespace Match_Dates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var regex = @"\b(?<day>\d{2})([-.\/])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";
            var datesStrings = Console.ReadLine();
            var dates = Regex.Matches(datesStrings, regex);
            foreach(Match date in dates) 
            {
                string day = date.Groups["day"].Value;
                string month = date.Groups["month"].Value;
                string year = date.Groups["year"].Value;
                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");    
            }

        }
    }
}