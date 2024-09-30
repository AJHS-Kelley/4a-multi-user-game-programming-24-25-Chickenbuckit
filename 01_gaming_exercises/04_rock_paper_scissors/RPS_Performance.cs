using System;

class RPS {
    static void Main() {
        // Declare variables
        int playerScore = 0;
        int cpuScore = 0;
        int loopcount = 0;
        int loopreqs;

        // Get the number of loops from the user
        Console.WriteLine("Type a whole number determining how many rounds you want to play:");
        while (!int.TryParse(Console.ReadLine(), out loopreqs) || loopreqs <= 0) {
            Console.WriteLine("Invalid input. Please enter a positive whole number.");
        }

        Random rand = new Random();

        // Game loop start
        while (loopcount < loopreqs) {
            // Display current score
            Console.WriteLine($"Current Score - Bot 1: {playerScore} | Bot 2: {cpuScore}");

            // Generate random choices for both bots
            int playerChoice = rand.Next(1, 4); // 1, 2, or 3
            int cpuChoice = rand.Next(1, 4); // 1, 2, or 3

            // Determine the winner
            string result;
            if (playerChoice == cpuChoice) {
                result = "It's a tie!";
            } else if ((playerChoice == 1 && cpuChoice == 3) ||
                       (playerChoice == 2 && cpuChoice == 1) ||
                       (playerChoice == 3 && cpuChoice == 2)) {
                result = "Bot 1 wins this round!";
                playerScore++;
            } else {
                result = "Bot 2 wins this round!";
                cpuScore++;
            }

        //     // Output the choices and result
        //     Console.WriteLine($"Bot 1 chose: {ChoiceToString(playerChoice)}");
        //     Console.WriteLine($"Bot 2 chose: {ChoiceToString(cpuChoice)}");
        //     Console.WriteLine(result);
        //     Console.WriteLine();

        //     loopcount++;
        // }

        // // Declare the overall winner
        // if (playerScore > cpuScore) {
        //     Console.WriteLine("Bot 1 wins the game!");
        // } else if (cpuScore > playerScore) {
        //     Console.WriteLine("Bot 2 wins the game!");
        // } else {
        //     Console.WriteLine("The game is a tie!");
        // }
    }

    static string ChoiceToString(int choice) {
        switch (choice) {
            case 1: return "Rock";
            case 2: return "Paper";
            case 3: return "Scissors";
            default: return "Invalid Choice";
        }
    }
}