using System;

namespace whileLoops
{
    class whileLoops
    {
        static void Main(string[] args)
        {
            // syntax for a while loop is
            // while (condition/test is true) <- while header
            // { body
            //      
            // }

            int x = 0;
            int y = 0;
            while (x <= 20)
            {
                y += x;
                Console.Write(x + " ");
                x++;
            }
            Console.WriteLine(y);

            // another application of a while loop:
            // requests input from the user (multiple numbers) and stops when the user enters a negative number

            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());

            //while (number > 0)
            //{
            //    Console.WriteLine("Your number is {0}", number);
            //    Console.WriteLine("Enter another number: ");
            //    number = int.Parse(Console.ReadLine());
            //}
            int number;
            do
            {
                Console.WriteLine("Enter a number: ");
                number = int.Parse(Console.ReadLine());
                Console.WriteLine("Your number is {0}", number);
            }
            while (number > 0);
        }
    }
}
