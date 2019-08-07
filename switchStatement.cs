using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the suer's letter grade
            Console.Write("Enter your letter grade: ");
            char letterGrade = char.Parse(Console.ReadLine());
            float gpa = 0f;

            // convert the character to uppercase
            letterGrade = char.ToUpper(letterGrade);

            switch (letterGrade)
            {
                case 'A':
                    gpa = 4.0f;
                    break;

                case 'B':
                    gpa = 3.0f;
                    break;

                case 'C':
                    gpa = 2.0f;
                    break;

                case 'D':
                    gpa = 1.0f;
                    break;

                default:
                    break;
            }
            //if (letterGrade == 'A')
            //{
            //    gpa = 4.0f;
            //}
            //else if (letterGrade == 'B')
            //{
            //    gpa = 3.0f;
            //}
            //else if (letterGrade == 'C')
            //{
            //    gpa = 2.0f;
            //}
            //else if (letterGrade == 'D')
            //{
            //    gpa = 1.0f;
            //}
            //else // 'F'
            //{
            //    //gpa = 0f;
            //}
            Console.WriteLine("Your GPA is {0:f1}", gpa);
        }
    }
}
