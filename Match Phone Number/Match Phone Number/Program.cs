using System.Text.RegularExpressions;
namespace Match_Phone_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var regex = @"(\+359([ -])2(\2)(\d{3})(\2)(\d{4}))\b";
            var phones = Console.ReadLine();
            var phoneMatches = Regex.Matches(phones, regex);
            var macthedPhones = phoneMatches.Cast<Match>().Select(a => a.Value.Trim()).ToArray();
            Console.WriteLine(string.Join(", ", macthedPhones));
        }
    }
}