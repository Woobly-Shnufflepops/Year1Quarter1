// Author: Matthew Powers
using System;

namespace clubProceeds
{
    class candySales
    {
        static void candySalesCalculator()
        {
            int cases = 37;
            int candyBars = cases * 12;
            decimal grossProfit = candyBars * 0.75m;
            decimal candyBarCasesCost = cases * 5.00m;
            decimal associationTax = grossProfit * 0.1m;
            decimal proceeds = grossProfit - associationTax - candyBarCasesCost;
            Console.WriteLine("{0:c}", proceeds);

            //Console.Write("{0} {1} {2:c} {3:c} {4:c} {5:c}", cases, candyBars, grossProfit, candyBarCasesCost, associationTax, proceeds);

        }
        static void Main(string[] args)
        {
            candySalesCalculator();
        }
    }
}
