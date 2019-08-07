/* Author: Matthew Powers
 * Class: CSI_152
 * Assignment: Excersise 9
 * Description: Using multiple methods, asks user to input a number, then sums, averages, squares, and get the products of the input numbers.
 * The second part asks the user to input their ID, and then 3 exam scores and averages them, one with and one without decimal points
 */
using System;

namespace Excersize09
{
    class Exercise09
    {
        // Sums the users numbers
        static int sumNumbers(int sum1, int sum2)
        {
            Console.WriteLine(sum1 + sum2);
            return sum1 + sum2;
        }

        // Obtains the product of the users numbers
        static int productNumbers(int product1, int product2)
        {
            Console.WriteLine(product1 * product2);
            return product1 * product2;
        }

        // Obtains the average of the users numbers
        static int averageNumbers(int average1, int average2)
        {
            Console.WriteLine((average1 + average2) / 2);
            return (average1 + average2)/2;
        }

        // Obtains the square of the users numbers
        static int squareNumbers(int square)
        {
            Console.WriteLine(square * square);
            return square * square;
        }

        // Obtains the score of th 3 exams, and gets the average with decimal points
        static double examScores(double exam1, double exam2, double exam3)
        {
            Console.WriteLine((exam1 + exam2 + exam3) / 3);
            return (exam1 + exam2 + exam3) / 3;
        }

        // Obtains the score of th 3 exams, and gets the average without decimal points
        static double examScoresNoPoint(double exam1, double exam2, double exam3)
        {
            Console.WriteLine(Math.Round((exam1 + exam2 + exam3) / 3));
            return Math.Round((exam1 + exam2 + exam3) / 3);
        }


        // Calls the above methods into main
        static void Main(string[] args)
        {
            // Prompts the user for two numbers
            Console.WriteLine("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            // uses the above methods here
            sumNumbers(num1, num2);
            productNumbers(num1, num2);
            averageNumbers(num1, num2);
            squareNumbers(num1);
            squareNumbers(num2);

            // Prompts the user for their ID, then their exam scores
            Console.WriteLine("Enter your User ID: ");
            Console.ReadLine();
            Console.WriteLine("Enter the first exam score: ");
            double score1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second exam score: ");
            double score2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the third exam score: ");
            double score3 = Convert.ToDouble(Console.ReadLine());

            // Calls the exam score methods
            examScores(score1, score2, score3);
            examScoresNoPoint(score1, score2, score3);
        }
    }
}
