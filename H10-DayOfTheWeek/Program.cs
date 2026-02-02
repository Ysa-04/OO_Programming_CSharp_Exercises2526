using System.Globalization;
using Microsoft.VisualBasic;

namespace H10_DayOfTheWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welke dag?");
            int day = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Welke maand?");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Welk jaar?");
            int year = Convert.ToInt32(Console.ReadLine());

            DateTime date = new DateTime(year, month, day);

            CultureInfo belgianCI = new CultureInfo("nl-BE");

            Console.WriteLine($"{date.ToString("d MMMM yyyy", belgianCI)} is een {date.ToString("dddd")}"); // geen DayOfWeek gebruiken
        }
    }
}
