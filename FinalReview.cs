using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalReview
{
    class Program
    {
        static void piCalculator()
        {
            Console.Write("Enter the height of the cylinder: ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the radius of the cylinder: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            double volume = Math.PI * Math.Pow(radius, 2) * height;
            Console.WriteLine(volume);
        }

        static void booleanTester()
        {
            int x = 5;
            int y = 7;
            Console.WriteLine("X = {0}, Y = {1}", x, y);

            Console.WriteLine("X is not greater than 10: " + !(x > 10));
            Console.WriteLine("Y is not equal to 5 and 7: " + !(y == 5 || y == 7));
            Console.WriteLine("X is less or equal to twice Y and Y is between 20 and 30: " + ((x <= (y * 2) && (y >= 20 && y <= 30))));
            Console.WriteLine("Y is not between 19 and 39: " + !(y >= 19 && y <= 39));
            Console.WriteLine("X is greater than 5 and Y, or Y is less than or equal to -3: " + (x > 5 && x > y || y <= -3));
            Console.WriteLine("Either X is between 10 and 20 but not equal to 15, or Y is not between -2 and 2: " + (x >= 10 && x <= 20 && x != 15 || !(y >= -2 && y <= 2)));
        }

        static void priceOfItems()
        {
            const decimal TAX = 0.09m;
            Console.Write("Enter the price of the item: ");
            decimal itemPrice = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter the quantity of the itme: ");
            decimal itemAmount = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("The subtotal is {0:c}, the tax is {1}%, and the grand total is {2:c}", itemAmount * itemPrice, TAX * 100, itemAmount * itemPrice + (TAX * itemAmount * itemPrice));
        }

        static void intergerDivision()
        {
            Console.Write("Enter the first interger number: ");
            int N1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second interger number: ");
            int N2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The remainder of the two is {0}", N1 % N2);
        }

        static void passOrFail()
        {
            Console.Write("Enter your grade (in percentage): ");
            double grade = Convert.ToDouble(Console.ReadLine());
            if (grade >= 70) Console.WriteLine("You passed!");
            else Console.WriteLine("You Failed");
        }

        static void Main(string[] args)
        {
            decimal x = 2;
            Console.WriteLine("{0:c}", x);

            piCalculator();
            booleanTester();
            priceOfItems();
            intergerDivision();
            passOrFail();
        }
    }
}
