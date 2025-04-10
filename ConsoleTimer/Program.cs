using System;
using ConsoleTimer.Elements;

namespace ConsoleTimer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Clock clock = new Clock();

            double currentTime = clock.getCurrentTime();
            Console.WriteLine($"Current Time: {currentTime}"); // Use string interpolation
            Console.ReadKey();
        }
    }
}