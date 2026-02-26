namespace H11_FoodPurchase
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            DemoPurchase();
        }

        public static void DemoPurchase()
        {
            FoodPurchase kaas = new FoodPurchase("Kaas", 1, 4.9, true);
            Console.WriteLine($"De totaalprijs van {kaas.ProductName} is {kaas.UnitPrice}.");
            Console.WriteLine($"De vervaldatum van aankoop {kaas.Number} is {kaas.ExprationDate}");
        }
    }
}
