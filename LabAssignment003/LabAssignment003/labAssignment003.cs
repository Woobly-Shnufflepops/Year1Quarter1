/* Date: 1/23/2017
 * Author: Matthew Powers
 * Assignment: Lab Assignment 3
 * Class: CSI_152
 * Description: Prints 4 examples of different number containers (EG: byte, int, etc), and a very long sentance using the assigned variables
 */



using System;

namespace LabAssignment003
{
    class labAssignment003
    {
        
        static void Main(string[] args)
        {
            // Creates 5 different values, 4 of which have different containers
            byte examNumberOfCorrectResponses = 5;
            decimal studentLoan = 1000.45m;
            string homeTown = "Renton";
            byte percentageGrade = 100;
            char gradeIWant = 'A';

            // Writes a long sentance using the above variables
            Console.WriteLine("The correct number of responses for the exam is {0}, the amount of money I owe on my credit card is {1}, my hometown is {2}, the percentage grade I hope to get is {3}, and I hope to end the course with an {4}", examNumberOfCorrectResponses, studentLoan, homeTown, percentageGrade, gradeIWant);

            // Creates 4 ecample containers for numbers
            int intExample = 123456789;
            float floatExample = 5.736737857f;
            double doubleExample = 3528.4756738;
            decimal decimalExample = 356473623.89m;

            // Prints the 4 example numbers with some text
            Console.WriteLine("An interger with 0 digits {0:n0}", intExample);
            Console.WriteLine("A flaot with 2 digits {0:f2}", floatExample);
            Console.WriteLine("A double with 5 digits {0:f5}", doubleExample);
            Console.WriteLine("A decimal with money {0:c}", decimalExample);
        }
    }
}
