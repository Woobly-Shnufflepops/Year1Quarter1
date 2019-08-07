/*
 * Author: Matthew Powers
 * Date: 01/12/2017
 * Assignment: Lab 1
 * File: Excersize001.cs
 * Description: This program draws 3 ASCII STOP signs
 */



using System;

namespace ConsoleApplication1
{
    class Program
    {
        // This is the start of the program
        // These are the methods that are used to draw the STOP signs

        static void topOfASCII() // Prints the top of the ASCII STOP sign
        {
            Console.WriteLine(" _____  ");
            Console.WriteLine(" /     \\ ");
            Console.WriteLine("/       \\");
        }

        static void bottomOfASCII() // Prints the bottom of the ASCII STOP sign
        {
            Console.WriteLine("\\       /");
            Console.WriteLine(" \\_____/ ");
        }

        static void plusASCII()
        {
            Console.WriteLine("+-------+"); // Prints the + and - characters for the very bottom of the ASCII stop sign
        }

        static void stopASCII()
        {
            Console.WriteLine("|  STOP |"); // Prints the STOP text and sides of the ASCII STOP sign
        }

        static void Main(string[] args) // Main method that requires 3 keyboard inputs to draw all of the ASCII art, printing 1 sign at a time
        { // body
            Console.ReadKey();
            topOfASCII();
            bottomOfASCII();
            Console.ReadKey();

            topOfASCII();
            bottomOfASCII();
            plusASCII();
            Console.ReadKey();

            topOfASCII();
            stopASCII();
            bottomOfASCII();
            plusASCII();
            Console.ReadKey();
        }
    }
}
