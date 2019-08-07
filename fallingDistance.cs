// Author: Matthew Powers
using System;

namespace fallingDistance
{
    class fallingDistance
    {
        static void fallingDistanceFormula()
        {
            Console.Write("Input the length of time: ");
            int time = int.Parse(Console.ReadLine());

            const int G = 32;
            double distance = 1.0 / 2.0 * G * Math.Pow(time, 2);

            Console.Write(distance);

        }
        static void Main(string[] args)
        {
            fallingDistanceFormula();
            Console.WriteLine("");
        }
    }
}
