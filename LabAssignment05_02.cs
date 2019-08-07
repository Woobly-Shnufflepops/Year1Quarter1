/* Author: Matthew Powers
* Class: CSI_152
* Assignment: Lab Assignment 5 part 2
* Description: Prompts the user if they want to calculate the area of a circle, rectangle or cylinder, then the user enters the variables
*/
using System;

namespace LabAssignment05_02
{
    class Program
    {
        // prompts the user for the radius and calculates the area of a circle
        static void areaOfACircle()
        {
            // promps the user for the radius
            Console.WriteLine("Enter the radius: ");
            double radius = double.Parse(Console.ReadLine());

            // calculates the area
            double area = Math.Pow(radius, 2) * Math.PI;

            // Prints out the area of the circle
            Console.WriteLine("The area of the circle is {0}", area);
        }

        // prompts the user for the height and width then calculates the area of the rectangle
        static void areaOfARectangle()
        {
            // prompts the user for the length of the rectangle, and stores it as length
            Console.WriteLine("Enter the length of the rectangle: ");
            double length = double.Parse(Console.ReadLine());

            // prompts the user for the height of the rectangle, and stores it as height
            Console.WriteLine("Enter the width of the rectangle: ");
            double width = double.Parse(Console.ReadLine());

            // calculates the area of the rectangle and pritns it to console
            double area = length * width;
            Console.WriteLine("The area of the rectangle is {0}", area);
        }

        // prompts the user for the radius and height then calculates the area of the cylinder
        static void areaOfACylinder()
        {
            // prompts the user for the radius of the cylinder and stores it as radius
            Console.WriteLine("Enter the radius of the cylinder: ");
            double radius = double.Parse(Console.ReadLine());

            // promps the user for the height and stores it as height
            Console.WriteLine("Enter the height of the cylinder: ");
            double height = double.Parse(Console.ReadLine());

            // calculates the area of the cylinder and prints it to the console
            double area = 2 * Math.PI * radius * (radius + height);
            Console.WriteLine("The area of the cylinder is {0}", area);
        }

        // promps the user for which area they'd like to calculate, then calls the above method that matches
        static void areaCalculator()
        {
            // promps the user to choose between 3 areas to calculate, and stores them as a string
            Console.WriteLine("Enter the area of the object you'd like to calculate: circle, rectangle, or cylinder");
            string areaToCalculate = Console.ReadLine();

            // matches the input to the case, and calls the matching method
            switch (areaToCalculate)
            {
                case "circle":
                    areaOfACircle();
                    break;

                case "rectangle":
                    areaOfARectangle();
                    break;

                case "cylinder":
                    areaOfACylinder();
                    break;

                default:
                    Console.WriteLine("ERROR: Text doesn't match!");
                    break;
            }
        }

        // Main method that calls area calculator, which does all the work
        static void Main(string[] args)
        {
            areaCalculator();
        }
    }
}
