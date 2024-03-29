using System.Text.RegularExpressions;
namespace Treasures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex metals = new Regex(@"@(\w+)\|");
            Regex gems = new Regex(@"#(\w+)\*");
            
            Match metalM = metals.Match(input);
            Match gemM = gems.Match(input);
            string metal = " ";
            string gem = " ";
            if (metalM.Success) 
                metal = metalM.Groups[1].Value;
            if (gemM.Success)   
                gem = gemM.Groups[1].Value;
            Console.WriteLine($"Found hidden {metal} and {gem} in the cave.");
        }
    }
}