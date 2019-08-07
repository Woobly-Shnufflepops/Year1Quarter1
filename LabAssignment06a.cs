/* Author: Matthew Powers
* Date: 3/1/2017
* Class: CSI_152
* Assignment: Lab Assignment 6
* Description: Calls 1 method which uses a few for loops for different mathmatical operations, then prints the out put
*/
using System;

namespace LabAssignment06a
{
    class Program
    {
        // method with da loops
        static void forLoopLoops()
        {
            // counting up
            for (int i = 4; i <= 10; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            // counting down
            for (int j = 6; j > 0; j--)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
            // count with 2's
            for (int k = 2; k <= 16; k += 2)
            {
                Console.Write(k + " ");
            }
            Console.WriteLine();
            // counting down by 2
            for (int l = 19; l >= 5; l -= 2)
            {
                Console.Write(l + " ");
            }
            Console.WriteLine();
            // counting by 8's
            for (int m = 7; m <= 39; m += 8)
            {
                Console.Write(m + " ");
            }
            Console.WriteLine();
            // multiplying by 2
            for (int n = 2; n <= 64; n = n * 2)
            {
                Console.Write(n + " ");
            }
        }

        // main method which calls above method
        static void Main(string[] args)
        {
            forLoopLoops();
        }
    }
}
