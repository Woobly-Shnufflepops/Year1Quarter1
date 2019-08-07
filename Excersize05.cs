/* Author: Matthew Powers
* Class: CSI_152
* Assignment: Excersize 5
* Description: Takes a number grade (in percentage) and converts it into a letter grade
*/
using System;

namespace percentGradeToLetterGrade
{
    class Program
    {
        static void percentGrade()
        {
            // prompts the user for input
            Console.Write("Enter your grade (in percentage): ");
            double percent = double.Parse(Console.ReadLine());

            // checks what number was entered, and outputs a statement
            if (percent < 60)
            {
                Console.WriteLine("Your grade is an F");
            }
            else if (percent < 70)
            {
                Console.WriteLine("Your grade is a D");
            }
            else if (percent < 80)
            {
                Console.WriteLine("Your grade is a C");
            }
            else if (percent < 90)
            {
                Console.WriteLine("Your grade is a B");
            }
            else
            {
                Console.WriteLine("Your grade is an A");
            }
        }
        static void Main(string[] args)
        {
            // Calls the above defined method
            percentGrade();
        }
    }
}
