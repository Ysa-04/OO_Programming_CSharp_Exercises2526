namespace H11_FoodPurchase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FoodPurchase kaas = new FoodPurchase("Kaas", 2, 2.45, true);
            DemoPurchase(kaas);
            FoodPurchase boter = new FoodPurchase("Boter", 0, 5555, true);
            DemoPurchase(boter);
        }

        public static void DemoPurchase(FoodPurchase product)
        {
            
            if ((product.UnitPrice > 0 || product.UnitPrice < 5000) && product.Number > 0)
            {
                Console.WriteLine($"De totaalprijs van {product.ProductName} is {product.CalculateTotalPrice()}.");
                Console.WriteLine($"De vervaldatum van aankoop {product.Number} is {product.ExprationDate}");
            } 
        }
    }
}
