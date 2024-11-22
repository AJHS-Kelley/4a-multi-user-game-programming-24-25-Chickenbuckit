//Rock Paper Scissors, Casey Boyce, v0.4
using System;
class RockPaperSissors {
    static void Main() 
    {
        //Declare variables
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

            //Player choice with validation
            playerChoice = 0;
            while (playerChoice < 1 || playerChoice > 3)
            {
                Console.WriteLine("Choose Rock (1), Paper (2), or Scissors (3): ");
                if (!int.TryParse(Console.ReadLine(), out playerChoice) || playerChoice < 1 || playerChoice > 3)
                {
                    Console.WriteLine("Invalid choice. Please enter 1, 2, or 3.");
                    playerChoice = 0;
                }
            }
            //CPU choice
            Random rand = new Random();
            cpuChoice = rand.Next(1, 4); // 1, 2, or 3
            //Determine the winner
            string result;
            if (playerChoice == cpuChoice)
            {
                result = "It's a tie!";
            }
            else if ((playerChoice == 1 && cpuChoice == 3) ||
                     (playerChoice == 2 && cpuChoice == 1) ||
                     (playerChoice == 3 && cpuChoice == 2))
            {
                result = $"{playerName} wins this round!";
                playerScore++;
            }
            else
            {
                result = "CPU wins this round!";
                cpuScore++;
            }
            //Output the choices and result
            Console.WriteLine($"Your choice: {ChoiceToString(playerChoice)}");
            Console.WriteLine($"CPU choice: {ChoiceToString(cpuChoice)}");
            Console.WriteLine(result);
            Console.WriteLine();
        }
        //Declare the overall winner
        if (playerScore == 5)
        {
            Console.WriteLine($"{playerName} wins the game!");
        }
        else
        {
            Console.WriteLine("CPU wins the game!");
        }
    }
    static string ChoiceToString(int choice)
    {
        switch (choice)
        {
            case 1: return "Rock";
            case 2: return "Paper";
            case 3: return "Scissors";
        }
    }
}
