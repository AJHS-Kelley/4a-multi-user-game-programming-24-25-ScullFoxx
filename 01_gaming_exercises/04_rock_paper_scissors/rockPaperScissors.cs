// Rock Paper Scissors, Sculley Alexandra, v1.0

using System;
class RPS {
    static void Main() {

        // VARIABLES
        string playerAnswer = "";
        string playerName = "";
        int playerScore = 0;
        int cpuScore = 0;
        string playerChoice = "";
        string cpuChoice = "";
        Random rnd = new Random();
        int cpuRand;

        // Player Name
         
        Console.WriteLine("Welcome to FEESH's Rock, Paper, Scissors\n");
        Console.WriteLine("Lets start with what you decide to be called.\n");
        playerName = Console.ReadLine();
        Console.WriteLine("Is this YOUR NAME? Don't be lies now. Type yes to confirm.\n");
        playerAnswer = Console.ReadLine().ToLower();
        if (playerAnswer == "yes")
        {
            // Rules 
            Console.WriteLine($"Okay thanks for playing {playerName}.\n Here's a few rules to go over.\n");
            Console.WriteLine("Rock beats scissors, Scissors beats paper, Paper beats rock.\n");
            Console.WriteLine("FOr every round wins, winner geta point. Feesh to 5 win.\n");
        }
        else if (playerAnswer != "yes")
        {
            while (playerAnswer != "yes")
            {
                Console.WriteLine("OKay dudes, put in your name fr this time.\n");
                playerName = Console.ReadLine();
                Console.WriteLine("Is this YOUR NAME? Don't be lies now. Type yes to confirm.\n");
                playerAnswer = Console.ReadLine().ToLower();
            }
        }
    
        // Gameplay
        while (playerScore <= 5 || cpuScore <= 5)
        {
            cpuRand = rnd.Next(0, 2);
            Console.WriteLine("PLease pick option rock, paper, or scissors.\n");
            playerChoice = Console.ReadLine().ToLower();
            if (playerChoice == "rock" || playerChoice == "paper" || playerChoice == "scissors")
            {
                Console.WriteLine($"You has selected {playerChoice}..");
            }
            else if (playerChoice != "rock" || playerChoice != "paper" || playerChoice != "scissors")
            {
                Console.WriteLine("Okay buddys... I need ya to acc pick sum. rock, paper, or scissors.\n");
                playerChoice = Console.ReadLine().ToLower();
            }
            Console.WriteLine("Feesh is choosing...\n");
            if (cpuRand == 0)
            {
                cpuChoice = "rock";
                Console.WriteLine("Feesh has rock!\n");
            }
            else if (cpuRand == 1)
            {
                cpuChoice = "paper";
                Console.WriteLine("Feesh has paper!\n");
            }
            else if (cpuRand == 2)
            {
                cpuChoice = "scissors";
                Console.WriteLine("Feesh has scissor!\n");
            }

            if (cpuChoice == playerChoice)
            {
                Console.WriteLine("Oops, Tie! Nobody points.\n");
            }
            else if (cpuChoice == "rock" && playerChoice == "scissors")
            {
                Console.WriteLine("Feesh has scored point!\n");
                cpuScore++;
            }
            else if (cpuChoice == "scissors" && playerChoice == "paper")
            {
                Console.WriteLine("Feesh has score point!\n");
                cpuScore++;
            }
            else if (cpuChoice == "paper" && playerChoice == "rock")
            {
                Console.WriteLine("Feesh has score point!\n");
                cpuScore++;
            }
            else if (playerChoice == "scissors" && cpuChoice == "paper")
            {
                Console.WriteLine($"Uhh.. {playerName} has point :(.\n");
                playerScore++;
            }
            else if (playerChoice == "paper" && cpuChoice == "rock")
            {
                Console.WriteLine($"Uhh.. {playerName} has point :(.\n");
                playerScore++;
            }
            else if (playerChoice == "rock" && cpuChoice == "scissors")
            {
                Console.WriteLine($"Uhh.. {playerName} has point :(.\n");
                playerScore++;
            }

            if (cpuScore >= 5)
            {
                Console.WriteLine("Feesh wins L :)\n");
                break;
            }
            else if (playerScore >= 5)
            {
                Console.WriteLine($"Oh noes {playerName} wins :(");
                break;
            }

        }



    }
}
