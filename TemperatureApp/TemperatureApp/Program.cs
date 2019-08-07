using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * This program implements a solution to the
 * problem about the temperatures in the PPT
 * Collect the temperature for multiple days
 * and compute the average temp as well as
 * the min and the max temp
 * Plus find the days that are above average
 */

namespace TemperatureApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // We need an array to store the temperatures


            // use a for loop to request the temp
            // values from the user and store them
            // in the array
            int[] temperatures = GetTempValues();

            DisplayValues(temperatures);

            Console.WriteLine(WarmestDay(temperatures));

            Console.WriteLine(SimulateDiceRoll());
        }

        // method that has no parameters and returns an array

        static int[] GetTempValues()
        {
            Console.Write("How many days' temperatures? ");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] temperatures = new int[size];
            for (int i = 0; i < temperatures.Length; i++)
            {
                // Prompt for the day's tmep
                Console.Write("Day {0}'s high temp: ",
                    i + 1);
                // store the input value in its element
                // location
                temperatures[i] = Convert.ToInt32(Console.ReadLine());
            }
            return temperatures;
        }

        // a method that displays the content 
        // of an array of integer values
        static void DisplayValues(int[] a)
        {
            // use a foreach loop to display the values
            // entered in one line using spacing
            foreach (int element in a)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }

        // Method that finds the warmest day - returns the highest temperature in the array
        static int WarmestDay(int[] a)
        {

            // set the max value to that of the first element
            //int max = a[0];
            // Best practice is to set the max value to the smallest int value
            int min = int.MaxValue;
            // cmpare the max to the other elements one-by-one
            foreach(int element in a)
            {
                // check if there is a higher value
                if(min > element)
                {
                    // update max to that element
                    min = element;
                }
            }
            return min;
        }

        static int SimulateDiceRoll()
        {
            Random rd = new Random();
            int x = rd.Next(1, 7);

            // Double values are between 0 and 0.999...
            double d = rd.NextDouble();
            // generate a double random value in the 1.000 to 9.999... range
            double f = rd.NextDouble() + rd.Next(1,10);
            return x;
        }
    }
}
