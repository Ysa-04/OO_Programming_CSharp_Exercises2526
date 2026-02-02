namespace H10_Birthday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Wanneer is je verjaardag? (DD/MM) ");
            DateTime userBirthday = Convert.ToDateTime(Console.ReadLine());
            DateTime today = DateTime.Today;

            DateTime birthdayThisYear = new DateTime(today.Year, userBirthday.Month, userBirthday.Day);
            TimeSpan diff = birthdayThisYear - today;

            if (diff.Days == 0)
            {
                Console.WriteLine("Vandaag is je verjaardag! Gefeliciteerd!");
            }
            else if (diff.Days == 1)
            {
                Console.WriteLine("Je bent morgen jarig!");
            }
            else if (diff.Days == -1)
            {
                Console.WriteLine("Je was gisteren jarig, proficiat nog!");
            }
            else
            {
                if (diff.Days < 0)
                {
                    birthdayThisYear = birthdayThisYear.AddYears(1);
                    diff = birthdayThisYear - today;
                }

                Console.WriteLine($"Nog {diff.TotalDays} dagen tot je verjaardag!");
            }
        }
    }
}
