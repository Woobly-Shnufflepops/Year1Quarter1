/*Author: Matthew Powers
* Class: CSI_152
* Assingment: Excersize 10
* Description: Uses a variety of arrays that do many different things
*/
using System;

namespace Excersize10
{
    class Program
    {
        // Method that sums the elements in the array
        static int SumTypeOfArray(int[] array)
        {
            int j = 0;
            foreach(int i in array)
            {
                j += i;
            }
            return j;
        }

        // Method that adds 1 to each element in the arrray
        static void Increment(double[] array)
        {
            for (int element = 0; element < array.Length; element++)
            {
                Console.Write("{0:f1} ", array[element]++);
            }
            Console.WriteLine();
        }

        // Checks to see if any of the elements in the array are negative, if so, returns false
        static bool ContainsNegative(double[] array)
        {
            bool isFalse = false;
            foreach(int element in array)
            {
                if(element < 0)
                {
                    isFalse = true;
                }
            }
            return isFalse;
        }

        // Prints the words in the array in reverse
        static void PrintReverse(string[] array)
        {
            for(int i = array.Length -1; i >= 0; i--)
            {
                Console.Write(array[i] + " ");
            }
        }

        // Finds the max value in the array and returns it
        static int Max(int[] array)
        {
            int max = int.MinValue;
            foreach(int element in array)
            {
                if(max < element)
                {
                    max = element;
                }
            }
            return max;
        }

        // Finds the average number in the array
        static double Average(double[] array)
        {
            int average = 0;
            foreach(int element in array)
            {
                average += element;
            }
            return average/array.Length;
        }

        // Checks to see if the number entered by the user matches any of the elements in the array
        static bool Contains(int[] array, int search)
        {
            bool ifSearch = false;
            foreach(int element in array)
            {
                if(search == element)
                {
                    ifSearch = true;
                }
            }
            return ifSearch;
        }

        // main method that calls the above methods
        static void Main(string[] args)
        {
            // Defines all of the arrays
            int[] SumArray = { 3, 5, 1, 2, 4, 6 };
            double[] DoubleArray = { 3.0, 5.0, 1.0, 2.0, 4.0, 6.0 };
            double[] NegativeArray = { 3.1, 5.3, 1.2, -2.5, 4.0, 6.9 };
            string[] ReverseArray = { "The", "soggy", "cat", "was", "unhappy!" };
            int[] MaxArray = { 12, 3, 14, 5, 11 };
            double[] AverageArray = { 10, 20, 30, 40};
            int[] SearchArray = { 3, 5, 1, 2, 4, 6 };

            // Calls the methods and arrays and prints them
            Console.WriteLine(SumTypeOfArray(SumArray));
            Increment(DoubleArray);
            Console.WriteLine(ContainsNegative(NegativeArray));
            PrintReverse(ReverseArray);
            Console.WriteLine();
            Console.WriteLine(Max(MaxArray));
            Console.WriteLine(Average(AverageArray));
            Console.Write("Input an interger value: ");
            Console.WriteLine(Contains(SearchArray, Convert.ToInt32(Console.ReadLine())));
        }
    }
}
