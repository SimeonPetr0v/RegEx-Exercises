using System.Globalization;
using System.Text.RegularExpressions;
namespace Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@">>(?<name>[\w]+)<<(?<cost>[\d+(.)?\d+?]+)!(?<quantity>[\d]+)");
            string input = Console.ReadLine();
            List<string> furnitures = new List<string>();
            double totalPrice = 0;
            
            while (input.ToLower() != "purchase")
            {
                if (regex.IsMatch(input))
                {
                    Match match = regex.Match(input);
                    string name = match.Groups["name"].Value;
                    double price = double.Parse(match.Groups["cost"].Value);
                    int quantity = int.Parse(match.Groups["quantity"].Value);
                    furnitures.Add(name);
                    totalPrice += price * quantity;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine("Bought furniture:");
            foreach (string furniture in furnitures)
                Console.WriteLine(furniture);
            
            Console.WriteLine($"Total money spent: {totalPrice:f2}");


        }
    }
}