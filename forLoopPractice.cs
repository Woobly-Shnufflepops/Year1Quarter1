using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            // print 100 messages using a for loop
            // loop that is code to
            // specify the number of repetition
            // by using a counter
            // counter has a starting value,
            // a ending value and a stepping value
            // called stride

            // for loop header has 3 parts
            // counter: initialization; test; update
            //for (int counter = 39; counter >= 4; counter -= 5)
            //{
            //    Console.Write(counter + " ");
            //}
            //// go to the next line
            //Console.WriteLine();

            // Rewrite the loop so it sums the following numbers and prints the sum after the loop ends
            // 4 9 14 19 24 29 34 39
            int numSum = 0;
            for (int counter = 4; counter <= 39; counter += 5)
            {
                if (counter % 2 == 0)
                {
                    numSum += counter;
                }
            }
            Console.WriteLine(numSum);
            

            //for (int counter = 4; counter <= 39; counter += 5)
            //{
            //    Console.Write(counter + " ");
            //}
        }
    }
}
