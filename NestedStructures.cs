using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedStructures
{
    class Program
    {
        static void Main(string[] args)
        {

            // infinite while loop

            int counter = 0;
            for (/*start*/;/*end*/;/*counter*/) 
            {
                counter++;
                if (counter % 2 == 1) continue;
                // Continue skips any code below it in the body but also continues looping
                Console.WriteLine(counter);
                if (counter == 100) break;
                // break skips any code below it in the body and exits the loop
            }
        }
    }
}
