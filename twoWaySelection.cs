using System;

namespace twoWaySelection
{
    class twoWaySelection
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a value: ");
            double x = double.Parse(Console.ReadLine());

            // check if the value is positive and report it to the user
            // two way selection

            if (x >= 0)
            {
                Console.Write("{0} is greater than, or equal to, 0", x);
            }
            else
            {
                Console.Write("{0} is less than 0", x);
            }
        }
    }
}
