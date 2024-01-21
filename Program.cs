
using Mission2Assignment;

internal class Program
{
    private static void Main(string[] args)
    {
        // Initiate a variable for the number of dice rools
        int RollCount = 0;

        // Create a new instance of the class called 'dice'
        Class1 dice = new Class1();

        // Print a welcome message to the console window
        System.Console.WriteLine("Welcome to the dice throwing simulator!\n");
        System.Console.WriteLine("How many times would you like to roll the die?");

        // Assign the number of dice rolls input by the user to the RollCount Variable
        RollCount = int.Parse(System.Console.ReadLine());

        // Call the RollDice method from Class1 and pass the RollCount value into it
        dice.RollDice(RollCount);

        // Say goodbye
        System.Console.WriteLine("\nThank you for using the Dice Throwing Simulator.  Goodbye!");
    }
}
