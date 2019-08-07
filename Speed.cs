using System;

namespace speed
{
    class Speed
    {
        static void Main(string[] args)
        {
            Console.Write("How fast are you going?");
            int MPH = int.Parse(Console.ReadLine());

            if (MPH < 40)
            {
                Console.WriteLine("Too slow you have a tickt");
            }
            else if (MPH <= 60)
            {
                Console.WriteLine("Perfect speed");
            }
            else if (MPH <= 70)
            {
                Console.WriteLine("Too fast you have a warning");
            }
            else
            {
                Console.WriteLine("Fine time");
            }
        }

        // change this application to implement the grade conversion:
        // grade 0-59 : F
        // grade 60-69 : D
        // grade 70-79 : C
        // grade 80-89 : B
        // grade 90 and up : A

        // promp use for a percentage grade and output the message showing letter grade
    }
}
