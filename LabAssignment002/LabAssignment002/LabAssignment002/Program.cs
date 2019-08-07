/* Date: 1/13?2017
 * Author: Matthew Powers
 * Assignment: Lab Assignment 2
 * Class: CSI_152
 * Description: Prints 3 ASCII sets of symbols
 */

using System;

namespace LabAssignment002
{
    class Program
    {
        // Method that writes the 5 stars in two rows

        static void fiveStarsLines()
        {
            Console.WriteLine("*****");
            Console.WriteLine("*****");
        }


        // Method that writes "box" of stars

        static void boxOfStars()
        {
            Console.WriteLine(" * * ");
            Console.WriteLine("  *  ");
            Console.WriteLine(" * * ");
        }


        // Method that uses the previous two methods to form a shape that is used the most often

        static void mostUsedSet()
        {
            fiveStarsLines();
            boxOfStars();
        }


        // Method that writes the single stars in the middle (relative to the five star lines)

        static void singleMiddleStars()
        {
            Console.WriteLine("  *  ");
            Console.WriteLine("  *  ");
            Console.WriteLine("  *  ");
        }


        // Main method that calls the previously defined methods to make the ASCII art
        static void Main(string[] args)
        {
            // Prints all 3 signs at once, and will stay open until a keystroke is made

            mostUsedSet();
            Console.WriteLine("\n");

            mostUsedSet();
            fiveStarsLines();
            Console.WriteLine("\n");

            singleMiddleStars();
            mostUsedSet();
            Console.ReadKey();

        }
    }
}
