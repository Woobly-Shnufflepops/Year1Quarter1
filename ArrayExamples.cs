using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Syntax for arrays
            //// type[] name = new type[length];
            //// type: is the data item (element) type
            //// length: the size of the data
            //// 1: An array of interger values
            //int[] numbers = new int[10];

            //// 2: An array of 100 doubles
            //double[] temperatures = new double[100];

            //// 3: An array of 20 strings (names) with the length as a constant
            //const int SIZE = 20;
            //string[] names = new string[SIZE];

            //// Prompt the user for the number of days for which we collect temperatures
            //Console.Write("Enter the number of days: ");
            //int nDays = Convert.ToInt32(Console.ReadLine());

            //// declare an array to hold the temperatures
            //int[] temps = new int[nDays]; // length = nDays

            //Console.WriteLine("You entered: " + temps.Length);

            //Console.WriteLine("Numbers: {0}\nTemperatures: {1}\nNames: {2}", numbers.Length, temperatures.Length, names.Length);

            //temperatures[2] = 20;
            //Console.WriteLine(temperatures[2]);

            int[] numbers3 = new int[10];
            // by default, each element is initialized to 0
            // Give initalize values to the elements
            int[] numbers2 = new int[6] {1, 2, 6, 12, 33, 55};

            // method number 2:
            int[] numbers4 = new int[] { 1, 2, 6, 12, 33, 55 };

            // method number 3:
            int[] numbers5 = { 1, 2, 6, 12, 33, 55 };

            // Write a for loop to print the elements of the array number5 in one line seperated by spaces
            for (int i = 0; i < numbers5.Length; i++) 
            {
                Console.Write(numbers5[i] + " ");
            }
            Console.WriteLine();

            // Better loop for accessing arrays:
            // called foreach loop
            // No loop counter, replace loop counter with iteration variable
            // The iteration variable reperesents the array element
            foreach (int a in numbers5)
            {
                Console.Write(a + " ");
            }
        }
    }
}
