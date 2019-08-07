using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignment06
{
    class Program
    {
        static void primeNumberChecker()
        {
            Console.WriteLine("Enter a positive interger to see if it is prime: ");
            int primeOrNot = int.Parse(Console.ReadLine());

            for (int i = 2; i < primeOrNot; i++)
            {
                if (primeOrNot == 2)
                {
                    Console.WriteLine("2 is a prime number");
                    break;
                }
                else if (primeOrNot % i == 0)
                {
                    Console.WriteLine(primeOrNot + " is not prime");
                    break;
                }
                else if (i == primeOrNot - 1)
                {
                    Console.WriteLine(primeOrNot + " is prime");
                    break;
                }
            }
        }
        static void Main(string[] args)
        {
            primeNumberChecker();
            for (int i = 4; i <= 10; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            for (int j = 6; j > 0; j--)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
            for (int k = 2; k <= 16; k += 2)
            {
                Console.Write(k + " ");
            }
            Console.WriteLine();
            for (int l = 19; l >= 5; l -= 2)
            {
                Console.Write(l + " ");
            }
            Console.WriteLine();
            for (int m = 7; m <= 39; m += 8)
            {
                Console.Write(m + " ");
            }
            Console.WriteLine();
            for (int n = 2; n <= 64; n = n * 2)
            {
                Console.Write(n + " ");
            }
        }
    }
}
