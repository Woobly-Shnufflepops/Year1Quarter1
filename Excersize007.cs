using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise07
{
    class Program
    {
        static void forLoopPractice()
        {
            Console.Write("Please enter a number: ");
            int firstNum = int.Parse(Console.ReadLine());
            Console.Write("Please enter a second number: ");
            int secondNum = int.Parse(Console.ReadLine());

            for (int counter = firstNum; counter <= secondNum; counter += 1)
            {
                if (counter % 2 == 1)
                {
                    Console.Write(counter + " ");
                }
            }
            Console.WriteLine();
            int evenSum = 0;
            for (int counter = firstNum; counter <= secondNum; counter += 1)
            {
                if (counter % 2 == 0)
                {
                    evenSum += counter;
                }
            }
            Console.WriteLine(evenSum);
            for (int counter = firstNum; counter <= secondNum; counter += 1)
            {
                if (counter <= 10)
                {
                    Console.Write(counter + " ");
                    Console.Write(counter * counter + " ");
                }
            }
            Console.WriteLine();
            int oddSum = 0;
            for (int counter = firstNum; counter <= secondNum; counter += 1)
            {
                if (counter % 2 == 1)
                {
                    oddSum += counter * counter;
                }
            }
            Console.WriteLine(oddSum);
            //char A = 'A';
            //for (int num = 1; num <= 26; num++)
            //{
            //    Console.Write(A + " ");
            //    A++;
            //}
            for (int ASCII_Code = 065; ASCII_Code <= 090; ASCII_Code++)
            {
                Console.Write((char)ASCII_Code + " ");
            }
        }

        static void whileLoopPractice()
        {
            Console.Write("Please enter a number: ");
            int firstNum = int.Parse(Console.ReadLine());
            Console.Write("Please enter a second number: ");
            int secondNum = int.Parse(Console.ReadLine());

            int counter = firstNum;
            while (counter <= secondNum)
            {
                if (counter % 2 == 1)
                {
                    Console.Write(counter + " ");
                }
                counter++;
            }
            Console.WriteLine("");

            counter = firstNum;
            while (counter <= secondNum)
            {
                if (counter % 2 == 0)
                {
                    counter += counter;
                }
                counter++;
            }
            Console.WriteLine(counter);

            counter = firstNum;
            while (counter <= 10)
            {
                Console.Write();
            }
        }

        static void doWhileLoopPractice()
        {
            Console.Write("Please enter a number: ");
            int firstNum = int.Parse(Console.ReadLine());
            Console.Write("Please enter a second number: ");
            int secondNum = int.Parse(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            forLoopPractice();
        }
    }
}
