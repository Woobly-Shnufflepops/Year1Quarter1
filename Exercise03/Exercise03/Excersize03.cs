/* Date: 1/25/2017
 * Author: Matthew Powers
 * Assignment: Excersize 3
 * Class: CSI_152
 * Description: Makes 2 methods, which are then called in Main
*/

using System;

namespace Exercise03
{
    class Excersize03
    {
        // Shows the various operations in C#
        static void operationAndResult()
        {
            // Initializes the two variables
            int x = 10;
            int y = 5;

            // Writes the expressions and calculates them
            Console.WriteLine("x value\t\ty value\t\texpression\tresult");
            Console.WriteLine("");
            Console.WriteLine("  {0}\t\t{2}\t\tx=y+3\t\tx={1}", x, x=y+3, y);
            Console.WriteLine("");
            Console.WriteLine("  {0}\t\t{2}\t\tx=y-2\t\tx={1}", x, x=y-2, y);
            Console.WriteLine("");
            Console.WriteLine("  {0}\t\t{2}\t\tx=y*5\t\tx={1}", x, x=y*5, y);
            Console.WriteLine("");
            Console.WriteLine("  {0}\t\t{2}\t\tx=x/y\t\tx={1}", x, x=x/y, y);
            Console.WriteLine("");
            Console.WriteLine("  {0}\t\t{2}\t\tx=x%y\t\tx={1}", x, x=x%y, y);
        }

        // Shows single operand calculations

        static void plusPlusMinusMinus()
        {
            // initalizes the variable
            int a = 10;

            // Uses various ++ and -- to and displays the results
            Console.WriteLine("The value of a is {0}", a);
            Console.WriteLine("");
            Console.WriteLine(".....................");
            Console.WriteLine("");
            Console.WriteLine("The value of ++a is {0}", ++a);
            Console.WriteLine("");
            Console.WriteLine("The value of a is {0}", a);
            Console.WriteLine("");
            Console.WriteLine("The value of a++ is {0}", a++);
            Console.WriteLine("");
            Console.WriteLine("The value of a is {0}", a);
            Console.WriteLine("");
            Console.WriteLine("The value of --a is {0}", --a);
            Console.WriteLine("");
            Console.WriteLine("The value of a is {0}", a);
            Console.WriteLine("");
            Console.WriteLine("The value of a-- is {0}", a--);
            Console.WriteLine("");
            Console.WriteLine("The value of a is {0}", a);
        }
        static void Main(string[] args)
        {
            // Calls the above methods which print lots of text
            operationAndResult();
            Console.WriteLine("");
            plusPlusMinusMinus();
        }
    }
}
