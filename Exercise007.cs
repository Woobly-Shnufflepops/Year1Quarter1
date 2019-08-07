/* Author: Matthew Powers
* Class: CSI_152
* Assignment: Excersize 7
* Description: Prompts the user for input twice, then does calcualtions in for, while, and do while loops
*/
using System;


namespace Exercise07
{
    class Program
    {
        // the for loop example
        static void forLoopPractice()
        {
            // prompts the user for 2 numbers
            Console.Write("Please enter a number: ");
            int firstNum = int.Parse(Console.ReadLine());
            Console.Write("Please enter a second number: ");
            int secondNum = int.Parse(Console.ReadLine());

            // checks to see if a number is odd, then writes the number if it is, then incriments up
            for (int counter = firstNum; counter <= secondNum; counter += 1)
            {
                if (counter % 2 == 1)
                {
                    Console.Write(counter + " ");
                }
            }
            Console.WriteLine();

            // checks to see if a number is even, then adds the number if it is, then incriments up. At the end, it prints the sum of the even numbers at the end
            int evenSum = 0;
            for (int counter = firstNum; counter <= secondNum; counter += 1)
            {
                if (counter % 2 == 0)
                {
                    evenSum += counter;
                }
            }
            Console.WriteLine(evenSum);

            // Checks to see if the number is less than 10, and if it is, prints the number and it's square
            for (int counter = firstNum; counter <= secondNum; counter += 1)
            {
                if (counter <= 10)
                {
                    Console.Write(counter + " ");
                    Console.Write(counter * counter + " ");
                }
            }
            Console.WriteLine();

            // Checks if the number is odd, then adds the square of that odd number and prints it at the end
            int oddSum = 0;
            for (int counter = firstNum; counter <= secondNum; counter += 1)
            {
                if (counter % 2 == 1)
                {
                    oddSum += counter * counter;
                }
            }
            Console.WriteLine(oddSum);

            // Takes ascii code numbers, and converts them to ascii, then increments
            for (int ASCII_Code = 065; ASCII_Code <= 090; ASCII_Code++)
            {
                Console.Write((char)ASCII_Code + " ");
            }
        }

        // the while loop example
        static void whileLoopPractice()
        {
            // prompts the user for 2 numbers
            Console.Write("Please enter a number: ");
            int firstNum = int.Parse(Console.ReadLine());
            Console.Write("Please enter a second number: ");
            int secondNum = int.Parse(Console.ReadLine());

            // checks to see if a number is odd, then writes the number if it is, then incriments up
            int oddSum = firstNum;
            while (oddSum <= secondNum)
            {
                if (oddSum % 2 == 1)
                {
                    Console.Write(oddSum + " ");
                }
                oddSum++;
            }
            Console.WriteLine("");

            // checks to see if a number is even, then adds the number if it is, then incriments up. At the end, it prints the sum of the even numbers at the end
            int evenSum = 0;
            int evenCounter = firstNum;
            while (evenCounter <= secondNum)
            {
                if (evenCounter % 2 == 0)
                {
                    evenSum += evenCounter;
                }
                evenCounter++;
            }
            Console.WriteLine(evenSum);

            // Checks to see if the number is less than 10, and if it is, prints the number and it's square
            int squareCalc = firstNum;
            while (squareCalc <= 10)
            {
                Console.Write("{0} {1} ", squareCalc, squareCalc * squareCalc);
                squareCalc++;
            }
            Console.WriteLine("");

            // Checks if the number is odd, then adds the square of that odd number and prints it at the end
            int oddCounter = firstNum;
            int oddSquare = 0;
            while (oddCounter <= secondNum)
            {
                if (oddCounter % 2 == 1)
                {
                    oddSquare += oddCounter * oddCounter;
                }
                oddCounter++;
            }
            Console.WriteLine(oddSquare);

            // Takes ascii code numbers, and converts them to ascii, then increments
            int ASCII_Code = 065;
            while (ASCII_Code <= 090)
            {
                Console.Write((char)ASCII_Code + " ");
                ASCII_Code++;
            }
        }

        // the do while loop example
        static void doWhileLoopPractice()
        {
            // prompts the user for 2 numbers
            Console.Write("Please enter a number: ");
            int firstNum = int.Parse(Console.ReadLine());
            Console.Write("Please enter a second number: ");
            int secondNum = int.Parse(Console.ReadLine());

            // checks to see if a number is odd, then writes the number if it is, then incriments up
            int oddCounter = firstNum;
            do
            {
                if (oddCounter % 2 == 1)
                {
                    Console.Write(oddCounter + " ");
                }
                oddCounter++;
            }
            while (oddCounter <= secondNum);
            Console.WriteLine("");

            // checks to see if a number is even, then adds the number if it is, then incriments up. At the end, it prints the sum of the even numbers at the end
            int evenCounter = firstNum;
            int evenSum = 0;
            do
            {
                if (evenCounter % 2 == 0)
                {
                    evenSum += evenCounter;
                }
                evenCounter++;
            }
            while (evenCounter <= secondNum);
            Console.WriteLine(evenSum);

            // Checks to see if the number is less than 10, and if it is, prints the number and it's square
            int squareCalc = firstNum;
            do
            {
                Console.Write("{0} {1} ", squareCalc, squareCalc * squareCalc);
                squareCalc++;
            }
            while (squareCalc <= secondNum);
            Console.WriteLine("");

            // Checks if the number is odd, then adds the square of that odd number and prints it at the end
            int oddSquareCounter = firstNum;
            int oddSquareSum = 0;
            do
            {
                if (oddSquareCounter % 2 == 1)
                {
                    oddSquareSum += oddSquareCounter * oddSquareCounter;
                }
                oddSquareCounter++;
            }
            while (oddSquareCounter <= secondNum);
            Console.WriteLine(oddSquareSum);

            // Takes ascii code numbers, and converts them to ascii, then increments
            int ASCII_Code = 065;
            do
            {
                Console.Write((char)ASSCI_Code + " ");
                ASCII_Code++;
            }
            while (ASCII_Code <= 090);
        }

        // Main method that calls the above methods
        static void Main(string[] args)
        {
            forLoopPractice();
            whileLoopPractice();
            doWhileLoopPractice();
        }
    }
}
