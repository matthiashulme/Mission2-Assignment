using System;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inital Message and Recieving Number of Rolls from User
            Console.WriteLine("Welcome to the dice throwing simulator!\n");
            Console.Write("How many dice rolls would you like to simulate?\n");
            string s = Console.ReadLine();
            int numRolls = Convert.ToInt32(s);

            // Initializing Random and Rolls List Variables
            Random r = new Random();
            int[] rolls = new int[13];

            // Iterate through specified number of rolls
            for (int i = 0; i < numRolls; i++)
            {
                // Simulate two rolls, add them together, and add them to the rolls list variable
                int roll1 = r.Next(6) + 1;
                int roll2 = r.Next(6) + 1;
                int combined = roll1 + roll2;
                rolls[combined]++;
            }

            // Creating Results Class Instance and passing in Rolls for constructor
            Results results = new Results(rolls);

            // Closing Message
            Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
        }
    }
}
