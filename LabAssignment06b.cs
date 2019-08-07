/* Author: Matthew Powers
* Date: 3/1/2017
* Class: CSI_152
* Assignment: Lab Assignment 6
* Description: Asks the user for a postitive interger, then checks if said number is prime or not
*/
using System;

namespace LabAssignment06b
{
    class Program
    {
        // method that prompts user for a positive interger, then checks if it's prime or not
        static void primeNumberChecker()
        {
            // Prompts the user for input, then stores it in primeOrNot
            Console.WriteLine("Enter a positive interger to see if it is prime: ");
            int primeOrNot = int.Parse(Console.ReadLine());

            // start of the for loop seeing if the number is prime
            for (int i = 2; i <= primeOrNot; i++)
            {
                // if the number is specifically 2, it writes so
                if (primeOrNot == 2)
                {
                    Console.WriteLine("2 is a prime number");
                    break;
                }
                // Checks to see if primeOrNot is divisible by any number before it, if it is, this executes
                else if (primeOrNot % i == 0)
                {
                    Console.WriteLine(primeOrNot + " is not prime");
                    break;
                }
                // If it reaches the end of the loop, prints the input and that it is prime
                else if (i == primeOrNot - 1)
                {
                    Console.WriteLine(primeOrNot + " is prime");
                    break;
                }
            }
        }
        // main method that calls above program
        static void Main(string[] args)
        {
            primeNumberChecker();
        }
    }
}
