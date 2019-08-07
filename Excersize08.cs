/* Author: Matthew Powers
* Date: 3/6/2017
* Class: CSI_152
* Assignment: Excersize08
* Desciption: Uses multiple for loops to write ASCII art
*/
using System;

namespace Excersize08
{
    class Exercise08
    {
        // Uses 2 for loops to print 1 to 9 three times
        static void oneToNine()
        {
            // first for loop that decides the number of rows
            for (int i = 0; i <= 2; i++)
            {
                // Second for loop that creates numbers 1 through 9 and prints them
                for (int j = 1; j <= 9; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        // Uses 2 for loops to print a long rectangle
        static void starRectangleOne()
        {
            // for loop that decides the number of rows
            for (int i = 0; i <= 4; i++)
            {
                // for loop that decides the number of columns
                for (int j = 0; j <= 4; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void starRectangleTwo()
        {
            // for loop that decides the number of rows
            for (int i = 0; i <= 1; i++)
            {
                // for loop that decides the number of columns
                for (int j = 0; j <= 10; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        
        static void christmasTree()
        {
            // for loop that decides the number of rows
            for (int i = 1; i <= 8; i++)
            {
                // for loop that decides the number of columns
                for (int j = 1; j <= 8; j++)
                {
                    // if statement that choses between spaces and asterisks
                    if (j + i > 8)
                    {
                        Console.Write("**");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        // Main method that calls above methods
        static void Main(string[] args)
        {
            oneToNine();
            starRectangleOne();
            starRectangleTwo();
            christmasTree();
        }
    }
}
