using System.Text.RegularExpressions;

namespace Extract_Emails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();


            string path = @"\b[A-Za-z0-9]+(?:[_\-\.][A-Za-z0-9]+)*@[A-Za-z0-9]+(?:[A-Za-z\-][A-Za-z0-9]+)*\.[A-Za-z]{2,}(?:\.[A-Za-z]{2,})?\b";
            Regex regex = new Regex(path);
            MatchCollection matches = regex.Matches(text);
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}