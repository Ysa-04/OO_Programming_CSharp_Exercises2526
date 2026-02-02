using Microsoft.VisualBasic;

namespace H10_DayOfTheWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("What day?");
            int day = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("What month?");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What year?");
            int year = Convert.ToInt32(Console.ReadLine());

            DateTime date = new DateTime(year, month, day);
            Console.WriteLine($"{date.ToString("dd MMMM yyyy")} is a {date.DayOfWeek}");
        }
    }
}
