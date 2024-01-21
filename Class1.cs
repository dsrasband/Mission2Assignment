using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2Assignment
{
    internal class Class1
    {
        public void RollDice(int number)
        {
            Random random = new Random();

            // Initialize an array to hold the roll results
            int[] rolls = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            for (int iCount = 1; iCount <= number; iCount++) 
            {

                // Generate random numbers for each die
                int die1 = random.Next(1, 7);
                int die2 = random.Next(1, 7);

                // Add the two dice rolls together to get the total result of the roll
                int rollresult = die1 + die2;

                // Based on the roll result, add one to that position in the array
                rolls[rollresult - 2] = rolls[rollresult - 2] + 1;
            }

            // Print the text to explain the results
            System.Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS:");
            System.Console.WriteLine("\nEach '*' represents 1% of the total number of rolls.");
            System.Console.WriteLine($"\nTotal number of rolls = {number}.\n");

            // Initialize a for loop that will loop for how many times the dice should be rolled
            for (int iCount = 0;iCount < rolls.Length; iCount++) 
            {
                // Initialize an empty string to hold the number of asterisks for each roll result
                string asterisks = "";
                
                // Initialize a variable to hold and calculate the percentage each value was rolled
                float percentage = ((float)rolls[iCount] / number) * 100;

                // Using a for loop, add the number of asterisks for the amount each number was rolled
                for (int iCount2 = 0; iCount2 < percentage; iCount2++) 
                {
                    asterisks = asterisks + "*";
                }

                // Write to the console the roll result along with the percentage it was rolled represented by asterisks
                System.Console.WriteLine($"{iCount + 2}: {asterisks}");
            }
        }
    }
}
