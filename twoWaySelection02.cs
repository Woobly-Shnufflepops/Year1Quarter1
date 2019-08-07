using System;

namespace twoWaySelection
{
    class twoWaySelection                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              
    {
        static void Main(string[] args)
        {

            Console.Write("Enter your age: ");
            double age = double.Parse(Console.ReadLine());

            // check if users age is in the range, 17-42
            // two way selection

            if (age >= 17 && age <= 42)
            {
                Console.Write("You are eligible for service");
            }
            else
            {
                Console.Write("You are ineligible for service");
            }
        }
    }
}
