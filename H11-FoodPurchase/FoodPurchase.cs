using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H11_FoodPurchase
{
    internal class FoodPurchase
    {
        public bool Refrigerate;
        private string productName;
        public string ProductName
        {
            get
            {
                return this.productName.ToUpper();
            }
        }
        private int number;
        public int Number
        {
            get
            {
                return number;
            }
            set
            {
                if(value <= 0)
                {
                    Console.WriteLine("Ongeldig aantal");
                }
                else
                {
                    number = value;
                }
            }
        }
        private double unitPrice;
        public double UnitPrice
        {
            get
            {
                return unitPrice;
            }
            set
            {
                if (value < 0 || value >= 5000)
                {
                    Console.WriteLine("Ongeldige eenheidsprijs");
                }
                else
                {
                    unitPrice = value;
                }
            }
        }
        public DateTime ExprationDate
        {
            get
            {
                return DateTime.Now.AddMonths(2); //in get niet in set!!!!
            }
        }

        public FoodPurchase(string productName, byte number, double unitPrice, bool refrigerate )
        {
            this.productName = productName;
            Number = number;
            UnitPrice = unitPrice;
            Refrigerate = refrigerate;
        }

        public double CalculateTotalPrice()
        {
            return this.number * this.unitPrice;
        }   
    }
}
