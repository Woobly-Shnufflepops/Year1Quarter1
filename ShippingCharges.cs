/* Author: Matthew Powers
* Class: CSI_152
* Assignment: Lab Assignment 5 part 1
* Description: Determines the shipping cost based off the value of the item(s) purchased
*/
using System;

namespace shippingChargesCalculator
{
    class LabAssignment05_01
    {
        // prompts the user for a value, and determines the shipping cost based off the input
        static void shippingCost()
        {
            // Prompts the user for the cost and stores it
            Console.WriteLine("Enter the total cost of your purchases: ");
            decimal price = decimal.Parse(Console.ReadLine());

            if (price <= 250)
            {
                Console.WriteLine("The shipping cost is $5.00");
            }
            else if (price <= 500)
            {
                Console.WriteLine("The shipping cost is $8.00");
            }
            else if (price <= 1000)
            {
                Console.WriteLine("The shipping cost is $10.00");
            }
            else if (price <= 5000)
            {
                Console.WriteLine("The shipping cost is $15.00");
            }
            else
            {
                Console.WriteLine("The shipping cost is $20.00");
            }
        }

        // calls the above method
        static void Main(string[] args)
        {
            shippingCost();
        }
    }
}
