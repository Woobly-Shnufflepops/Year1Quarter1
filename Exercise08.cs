using System;

namespace Excersize08
{
    class Exercise08
    {
        static void oneToNine()
        {
            for (int i = 0; i <= 2; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        static void starRectangleOne()
        {
            for (int i = 0; i <= 4; i++)
            {
                for (int j = 0; j <= 4; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void starRectangleTwo()
        {
            for (int i = 0; i <= 1; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        const int eight = 8;
        static void christmasTree()
        {
            for (int i = 1; i <= 8; i++)
            {
                for (int j = 1; j <= 16; j++)
                {
                    if (j <= i)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            //oneToNine();
            //starRectangleOne();
            //starRectangleTwo();
            christmasTree();
        }
    }
}
