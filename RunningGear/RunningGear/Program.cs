using System.Text.RegularExpressions;
namespace RunningGear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> gear = new List<string>();
            double finalPrice = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Run!")
                    break;
                Regex regex = new Regex(@"<>(?<name>[\w]+)<>(?<quantity>[\d]+)--(?<price>[\d]+.[\d]+)");
                MatchCollection matches = regex.Matches(input);
                
                foreach (Match match in matches)
                {
                    string name = match.Groups[1].Value;
                    double quantity = double.Parse(match.Groups[2].Value);
                    double price = double.Parse(match.Groups[3].Value);
                    gear.Add(name);
                    finalPrice += quantity * price;
                }
            }
            Console.WriteLine("Gear bought:");
            foreach (string equipment in gear)
                Console.WriteLine(equipment);
            Console.WriteLine($"Total cost: {finalPrice:f02}");
        }
    }
}