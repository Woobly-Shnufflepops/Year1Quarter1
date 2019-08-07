// Author: Matthew Powers
using System;

namespace volumeCalculator
{
    class volumeCalculator
    {
        static void cylinderVolume()
        {
            Console.Write("Input the radius: ");
            double radius = double.Parse(Console.ReadLine());

            Console.Write("Input the height: ");
            double height = double.Parse(Console.ReadLine());

            double volume = Math.PI * Math.Pow(radius, 2) * height;
            Console.Write("The volume of the cylinder is {0:f4}", volume);
        }
        static void Main(string[] args)
        {
            cylinderVolume();
            Console.WriteLine("");
        }
    }
}
