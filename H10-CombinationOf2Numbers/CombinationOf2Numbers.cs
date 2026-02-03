using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H10_CombinationOf2Numbers
{
    public class CombinationOf2Numbers
    {
        public int Number1;
        public int Number2;

        public double Sum()
        {
            return Number1 + Number2;
        }

        public double Difference()
        {
            return Number1 - Number2;
        }

        public double Product()
        {
            return Number1 * Number2;
        }

        public double Quotient()
        {
            if (Number2 == 0)
            {
                Console.Write("Wie deelt door nul is ne snul! ");
            }
            return Math.Round(Convert.ToDouble(Number1) / Number2, 2);
        }
    }
}
