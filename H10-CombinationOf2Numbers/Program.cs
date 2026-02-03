using System.Xml.XPath;

namespace H10_CombinationOf2Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.Write("Geef het eerste getal: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Geef het tweede getal: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                CombinationOf2Numbers pair = new CombinationOf2Numbers();
                pair.Number1 = num1;
                pair.Number2 = num2;

                Console.WriteLine($"Paar: {pair.Number1}, {pair.Number2}");
                Console.WriteLine($"Som = {pair.Sum()}");
                Console.WriteLine($"Verschil = {pair.Difference()}");
                Console.WriteLine($"Product = {pair.Product()}");
                Console.WriteLine($"Quotient = {pair.Quotient()}");
        }
    }
}
