using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodExamples
{
    class Program
    {
        static void Main(string[] args)
        {// Entry point to the program
            // Call a method to execute its code
            // syntax: method-name(parameters);
            //Environment.Exit(0); interrupts the program and exits
            //PrintValue(5); // 5: argument value
            // argument value is assigned to the corresponding parameter (x)
            // The argument above is a literal value

            //Console.WriteLine("Enter an interger value: ");
            //int value = int.Parse(Console.ReadLine());
            // the argument is a variable
            //PrintValue(value);

            // arguments are an expression
            //PrintValue(2 * value - 7);

            // arguments are a method call (returns a value)
            //PrintValue((int)Math.Pow(value, 3));

            Console.WriteLine("Enter two numbers: ");
            double i = double.Parse(Console.ReadLine());
            double j = double.Parse(Console.ReadLine());
            DoubleValue(i, j);

            MethodFromHell(2, 2, 2, 'A', " hello", true);
        }

        // static return-type method-name(parameter-list)
        // void method
        //      - return-type: void
        //      - method-name: VoidMethod
        //      - parameter-list: empty
        static void VoidMethod() // method header
            // defines the signature of the method
        { // Method body
            // contains a sequence of statements
        }

        // Write a method with one value/parameter
        // return-type: void
        // name: PrintValue
        // parameter-list: one parameter/variable

        static void PrintValue(int x) // x is the parameter
        {
            x = x * x;
            Console.WriteLine(x);
        }

        // Write a method to add two double numbers and print them to console.
        // You need a void method with 2 parameters

        static void DoubleValue(double i, double j)
        {
            // add the number stored in the parameters saving the sum into a new variable
            double sum = i + j;
            Console.WriteLine("{0:f2}", sum);
        }

        static void MethodFromHell(int a, double c, byte s, char ch, string str, bool bl)
        {

        }
    }
}
