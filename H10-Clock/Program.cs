namespace H10_Clock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                DateTime timeNow = DateTime.Now;
                Console.WriteLine(timeNow.ToString("T"));
                System.Threading.Thread.Sleep(1000);
                Console.Clear();
            }
        }
    }
}
