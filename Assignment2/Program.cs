using System;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int[] rolls = new int[6];

            // Simulate the roll of 1 die for 100 times
            for (int i = 0; i < 100; i++)
            {
                rolls[r.Next(6)]++;
            }

            Console.WriteLine(rolls[4]);
        }
    }
}
