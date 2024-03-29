using System.Text.RegularExpressions;

namespace SoftUni_Bar_Income
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> products = new Dictionary<string, double>();
            double income = 0;
            string pattern = @"%(?<name>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<quantity>\d+)\|[^|$%.]*?(?<price>\d+(\.\d+)?)\$";
            string input;
            while ((input = Console.ReadLine() )!= "end of shift")
            {

               
                Match match = Regex.Match(input, pattern);
                if (match.Success)
                {
                    string name = match.Groups["name"].Value;
                    string product = match.Groups["product"].Value;
                    int quantity = int.Parse(match.Groups["quantity"].Value);
                    double price = double.Parse(match.Groups["price"].Value);

                    double totalPrice = quantity * price;
                    income += totalPrice;
                    Console.WriteLine($"{name}: {product} - {totalPrice:F2}");
                }
            }
            Console.WriteLine($"Total income: {income:f2}");
        }
    }
}