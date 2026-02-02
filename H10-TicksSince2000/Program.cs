using System.Globalization;

namespace H10_TicksSince2000
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo belgianCI = new CultureInfo("nl-BE");

            DateTime year2000 = new DateTime(2000, 1, 1);
            DateTime now = DateTime.Now;

            TimeSpan diff = now - year2000;

            Console.WriteLine($"Sinds {year2000.ToString("d MMMM yyyy", belgianCI)} zijn er {diff.Ticks} ticks voorbijgegaan");
        }
    }
}
