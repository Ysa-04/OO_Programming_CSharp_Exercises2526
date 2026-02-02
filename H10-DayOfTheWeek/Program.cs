namespace H10_DayOfTheWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welke dag?");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Welke maand? (in getal)");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Welk jaar?");
            int year = Convert.ToInt32(Console.ReadLine());

            string date = $"{day}/{month}/{year}";

            
        }
    }
}
