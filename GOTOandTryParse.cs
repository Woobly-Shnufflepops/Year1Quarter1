using System;

namespace GOTOAndTryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            // request a value from the user

            Console.WriteLine("Enter a number: ");
            // store the text typed by the user
            input: // creating a label: name for a point in the program
            string input = Console.ReadLine();
            //int num0 = int.Parse(input);
            int number;
            if (int.TryParse(input, out number))
            {
                // the parse has succeeded
            }
            else
            {
                // the parse has failed
                // create a new prompt
                Console.WriteLine("ERROR: Wrong format: Enter a number: ");
                goto input;
            }
        }
    }
}
