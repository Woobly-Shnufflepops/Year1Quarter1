using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_ArtTwo
{
    class ASCII_ArtTwo
    {
        static void Main(string[] args)
        {
            Console.Write("    | ");
            // loop to print the first row
            for (int j = 1; j <= 9; j++)
            {
                Console.Write("{0,4}", j);
            }
            Console.WriteLine();
            Console.Write("------");

            // draw the horizontal line
            for (int j = 1; j <= 9; j++)
            {
                Console.Write("----");
            }
            Console.WriteLine();
            // Controls the number of rows
            for (int i = 1; i <= 9; i++)
            {
                // Controls the number of columns
                Console.Write("{0,3} | ", i);
                for (int counter = 1; counter <= 9; counter++)
                {
                    Console.Write("{0,4}", counter * i);
                }
                // Creates a line to seperate the line(s)
                Console.WriteLine();
            }
        }
    }
}
