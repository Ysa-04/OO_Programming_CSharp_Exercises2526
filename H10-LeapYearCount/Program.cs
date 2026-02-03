namespace H10_LeapYearCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int leapYearCount = 0;

            for (int index = 1799; index <= 2021; index++)
            {
                if (DateTime.IsLeapYear(index))
                {
                    leapYearCount++;
                }
            }
            Console.WriteLine($"Er zijn {leapYearCount} schrikkeljaren tussen 1799 en 2021");
        }
    }
}
