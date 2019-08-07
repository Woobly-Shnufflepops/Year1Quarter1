/* Class: CSI_152
 * Author: Matthew Powers
 * Date: 2/9/17
 * Assignment: Midterm Question 1
 * Description: Prompts user for a percentage grade, then
 * displays true or false in the console based off the number
*/

using System;


namespace percentageGrade
{
    class percentGrade
    {
        // Prompts the user for a value between 0 and 100, and
        // checks to see if the number is between that or not
        static void gradePercentageNum()
        {
            // Prompts the user for a percentage grade
            Console.Write("Please input the percentage grade: ");
            double grade = double.Parse(Console.ReadLine());

            // checks to see if the grade is between 0 and 100
            // and prints a true or false statement
            bool between0And100 = grade >= 0 && grade <= 100;
            Console.Write(between0And100);
        }

        // Calls the above method into main
        static void Main(string[] args)
        {
            gradePercentageNum();
            Console.WriteLine("");
        }
    }
}
