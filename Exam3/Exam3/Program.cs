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
                SumPrice(input, gear,finalPrice);
            }
            FinalBill(gear, finalPrice);
        }

        static void SumPrice(string input, List<string> gear, double finalPrice)
        {
            Regex regex = new Regex(@"<>(?<name>[\w]+)<>(?<quantity>[\d]+)--(?<price>[\d]+.[\d]+)");
            MatchCollection matches = regex.Matches(input);           
            foreach (Match match in matches)
            {
                string name = match.Groups["name"].Value;
                double quantity = double.Parse(match.Groups["quantity"].Value);
                double price = double.Parse(match.Groups["price"].Value);
                gear.Add(name);
                finalPrice += quantity * price;
            }
        }

        static void FinalBill(List<string> gear, double finalPrice)
        {
            Console.WriteLine("Gear bought:");
            foreach (string equipment in gear)
                Console.WriteLine(equipment);
                
            Console.WriteLine($"Total cost: {finalPrice:f02}");
        }
    }
}
    
