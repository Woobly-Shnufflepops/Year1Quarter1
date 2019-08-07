// Author: Matthew Powers
using System;

namespace eventTime
{
    class eventTime
    {
        static void eventTimeSeconds()
        {
            Console.Write("Enter the event time (in seconds): ");
            int seconds = int.Parse(Console.ReadLine());

            int hours = seconds / 3600;
            seconds = seconds % 3600;
            int minutes = seconds / 60;
            seconds = seconds % 60;

            Console.Write("{0}:{1}:{2}", hours, minutes, seconds);
        }
        static void Main(string[] args)
        {
            eventTimeSeconds();
            Console.WriteLine("");
        }
    }
}
