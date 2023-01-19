using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Results
    {
        // Initializing Rolls List
        int[] rolls = new int[13];

        // Constructor which takes in All Roll Results and sets that to be Rolls List in Results Class
        public Results (int[] allRolls)
        {
            rolls = allRolls;
            // Call RollResults Functions
            RollResults();
        }

        // Roll Results Function
        public void RollResults ()
        {
            // Calculate Total number of Rolls
            int total = (rolls[2] + rolls[3] + rolls[4] + rolls[5] + rolls[6] + rolls[7] + rolls[8] + rolls[9] + rolls[10] + rolls[11] + rolls[12]);
            
            // Iterate through each roll amount in Rolls List
            for (int i = 2; i < 13; i++)
            {
                // Initialize decimaled variables to get percentage of each rolled number against the total
                decimal numRolls = rolls[i];
                decimal perc = numRolls / total * 100;

                // Initializing Print String with the Rolled Number
                string printLine = i + ": ";

                // Iterate through the percentage variable to add stars to Print String
                for (int j = 0; j < perc; j++)
                {
                    // Add Star for each Percent
                    printLine = printLine + "*";
                }

                // Print Results of Rolled Number and Associated Star Count
                Console.WriteLine(printLine);
            }
        }
    }
}
