/* Date: 2/1/17
* Author: Matthew Powers
* Class: Computer_Science_152
* Assignment: Lab Assignment 4
* Description: Runs 6 different programs requiring user input
*/

using System;

namespace LabAssignment04
{
    class LabAssignment04
    {
        // Prompts the user for 5 interger inputs, then prints them, sums them, and then prints the sum and average
        static void fiveIntergerNumbers()
        {
            // Prompts for the 5 numbers
            Console.WriteLine("Please enter the first number: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second number: ");
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the third number: ");
            int number3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the fourth number: ");
            int number4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the fifth number: ");
            int number5 = int.Parse(Console.ReadLine());
            // Prints the numbers, then the sum and average
            Console.WriteLine("The first number is {0}, the second number is {1}, the third number is {2}, the fourth number is {3}, and the last number is {4}", number1, number2, number3, number4, number5);
            Console.WriteLine("The sum of the numbers is " + (number5 + number4 + number3 + number2 + number1));
            Console.WriteLine("The average of the numbers is " + (number5 + number4 + number3 + number2 + number1) / 5);
        }

        // Prompts the user for the gallons of gas a vehical can hold, and it's MPG, then calculates how far it can travel without refuling
        static void vehicalMPG()
        {
            // Prompts for the number of gallons and MPG
            Console.WriteLine("How many gallons of gas can your vehical hold?");
            int numberOfGallons = int.Parse(Console.ReadLine());
            Console.WriteLine("What's your vehicals Miles Per Gallon (MPG)?");
            int MPG = int.Parse(Console.ReadLine());
            // Calculates and prints how far the vehical can travel without refuling
            Console.WriteLine("The vehical can travel " + numberOfGallons * MPG + " miles without refuling!");
        }

        // User enters the hours, minutes, and seconds of an event length, then turns it into seconds
        static void eventTimeToSeconds()
        {
            // Prompts for the hours, minutes, and seconds
            Console.WriteLine("How many hours long is the event?");
            int eventHours = int.Parse(Console.ReadLine());
            Console.WriteLine("How many minutes long is the event?");
            int eventMinutes = int.Parse(Console.ReadLine());
            Console.WriteLine("How many seconds long is the event?");
            int eventSeconds = int.Parse(Console.ReadLine());
            // Calculates the above times into seconds
            Console.WriteLine("The event is " + (((eventHours * 60 * 60) + eventMinutes * 60) + eventSeconds) + " seconds long!");
        }

        // User enters price of item, the mark up percentage, and the sales tax percentage, and then prints off multiple facts about the provided input
        static void storeProfit()
        {
            // prompts for the item, mark up%, and sales tax%
            Console.WriteLine("What is the original price of the item?");
            decimal itemPrice = decimal.Parse(Console.ReadLine());
            Console.WriteLine("What is the percentage mark-up price?");
            decimal itemMarkUpPercent = (decimal.Parse(Console.ReadLine())) / 100;
            Console.WriteLine("What is the sales tax percentage?");
            decimal salesTax = (decimal.Parse(Console.ReadLine())) / 100;
            // Does all the calculations required and prints a whole bunch
            Console.WriteLine("The original price is {0:c}, the percent mark up is {1}%, the store's price is {2:c}, the sales tax rate is {3}%, the sales tax is {4:c}, and the final price is {5:c}",
                itemPrice, itemMarkUpPercent * 100, (itemMarkUpPercent * itemPrice) + itemPrice, salesTax * 100, (itemPrice * itemMarkUpPercent * salesTax),
                (((itemMarkUpPercent * itemPrice) + itemPrice) + (itemPrice * itemMarkUpPercent * salesTax)));
        }

        // User inputs a set amount of centimeters, which is then converted into yards, feet, and inches
        static void centimetersToImperial()
        {
            // Prompts the user for CM and then converts the input to inches
            Console.WriteLine("Please input the length in centimeters: ");
            int centimeters = int.Parse(Console.ReadLine());
            int inches = (int)(centimeters / (1 / 2.54));
            // Takes inches, and gets yards, and also reassigns inches to the leftover from yards
            int yards = inches / 36;
            inches = inches % 36;
            int feet = inches / 12;
            inches = inches % 12;

            Console.Write("{3}cm is {0} yards, {1} ft, and {2} inches)", yards, feet, inches, centimeters);
        }

        // User inputs amount of milk (in liters) made and calculates the number of cartons needed, cost of producing the milk, and the profit of the milk
        static void milkProduction()
        {
            // Prompts the user for the amount of milk produced
            Console.WriteLine("How much milk was produced this morning?");
            double milkProducedInLiters = double.Parse(Console.ReadLine());
            int milkCartons = (int)(milkProducedInLiters / 3.78);
            decimal costOfMilk = (decimal)(milkProducedInLiters * 0.38);
            decimal profitOfMilk = (decimal)(milkCartons * 0.27);

            // Prints out the number of cartons needed, cost to produce the milk, and profit of the milk
            Console.WriteLine("The number of cartons needed is {0}, the cost of producing the milk is {1:c}, and the profit is {2:c}", milkCartons, costOfMilk, profitOfMilk);

        }

        static void Main(string[] args)
        {
            fiveIntergerNumbers();
            Console.WriteLine("");
            vehicalMPG();
            Console.WriteLine("");
            eventTimeToSeconds();
            Console.WriteLine("");
            storeProfit();
            Console.WriteLine("");
            centimetersToImperial();
            Console.WriteLine("");
            milkProduction();
        }
    }
}
