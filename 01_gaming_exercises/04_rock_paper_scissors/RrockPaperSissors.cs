//Rock papers sissors, Casey Boyce, v0.2
using System;
class rockPaperSissors {
    static void Main()
    {
        // Declare variables
        string playerName = "Test Player";
        int playerScore = 0;
        int cpuScore = 0;
        int playerChoice;
        int cpuChoice;
        //Get player's name
        Console.WriteLine("Enter your name: ");
        playerName = Console.ReadLine();
        //Display rules
        Console.WriteLine("Rules:");
        Console.WriteLine("Rock beats Scissors, Scissors beats Paper, and Paper beats Rock.");
        Console.WriteLine("First to 5 points wins.");
        Console.WriteLine();
        //Game loop start
        while (playerScore < 5 && cpuScore < 5)
        {
            //Display current score
            Console.WriteLine($"Current Score - {playerName}: {playerScore} | CPU: {cpuScore}");

            //Player choice
            Console.WriteLine("Choose Rock (1), Paper (2), or Scissors (3): ");
            playerChoice = int.Parse(Console.ReadLine());
        }
    }
}