/* Date: 1/23/2017
Author: Matthew Powers
Assignment: Excersize 2
Class: CSI_152
Description: Calculates the circumference of a circle, takes 2 numbers and uses different
operations and prints the results to the console. The last program converts Celsius to 
Fahrenheit.
*/

using System;

namespace ConsoleApplication2
{
    class Excersize02
    {
        static void circumferenceCalculator()
        {
            // Prompts user for the radius of a circle, then calculates and prints the circumference
            const double PI = 3.14159;
            Console.WriteLine("Enter the radius of a circle: ");
            int circleRadius = int.Parse(Console.ReadLine());
            Console.WriteLine("The circumference is " + (circleRadius * circleRadius * PI));
        }

        static void numberOperator()
        {
            // Takes 2 numbers and shows different operations on them
            int arbitraryNumber1 = 199;
            int arbitraryNumber2 = 76;
            Console.WriteLine("The sum of the two numbers is " + (arbitraryNumber1 + arbitraryNumber2));
            Console.WriteLine("The difference of the two numbers is " + (arbitraryNumber1 - arbitraryNumber2));
            Console.WriteLine("The product of the two numbers is " + (arbitraryNumber1 * arbitraryNumber2));
            Console.WriteLine("The average of the two numbers is " + ((arbitraryNumber1 + arbitraryNumber2) / 2));
            Console.WriteLine("The square of the two numbers are " + arbitraryNumber2 * arbitraryNumber2 + " and " + arbitraryNumber1 * arbitraryNumber1);
            Console.WriteLine("The remainder of the two numbers are " + arbitraryNumber1 % arbitraryNumber2);
        }

        static void celsiusToFahrenheit()
        {
            // Converts 37 degrees Celsius to Fahrenheit
            Console.WriteLine("37 dgrees celsius is " + (37 * 1.8 + 32) + " degrees in fahrenheit");
        }
        static void Main(string[] args)
        {
            circumferenceCalculator();
            numberOperator();
            celsiusToFahrenheit();
        }
    }
}
