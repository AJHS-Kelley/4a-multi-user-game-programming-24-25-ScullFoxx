// Rock Paper Scissors, Sculley Alexandra, v1.0

using System;
class RPS {
    static void Main() {

        // Testing Game LOOP
        int loopCount = 0;
        int loopReqs = 0;
        int numDraws = 0;
        Console.WriteLine("How many loops do you need?\n type an integer and press enter.\n");
        loopReqs = Convert.ToInt32(Console.ReadLine());
        
        // VARIABLES
        // string playerAnswer = "";
        // string playerName = "";
        int playerScore = 0;
        int cpuScore = 0;
        string playerChoice = "";
        string cpuChoice = "";
        Random rnd = new Random();
        int cpuRand;

        // Player Name
         
        /* Console.WriteLine("Welcome to FEESH's Rock, Paper, Scissors\n");
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
        */
        // Gameplay
        while (loopCount < loopReqs)
        {
            //Console.WriteLine("Burrito");
            cpuRand = rnd.Next(0, 3);
            // Console.WriteLine("PLease pick option rock, paper, or scissors.\n");
            if (cpuRand == 0)
            {
                playerChoice = "rock";
                //Console.WriteLine("Player has selected rock.\n");
            }
            else if (cpuRand == 1)
            {
                playerChoice = "paper";
                //Console.WriteLine("Player has selected paper.\n");
            }
            else if (cpuRand == 2)
            {
                playerChoice = "scissors";
                //Console.WriteLine("Player has selected scissors.\n");
            }
            
            cpuRand = rnd.Next(0, 3);
            //Console.WriteLine("Feesh is choosing...\n");
            if (cpuRand == 0)
            {
                cpuChoice = "rock";
                //Console.WriteLine("Feesh has rock!\n");
            }
            else if (cpuRand == 1)
            {
                cpuChoice = "paper";
                //Console.WriteLine("Feesh has paper!\n");
            }
            else if (cpuRand == 2)
            {
                cpuChoice = "scissors";
                //Console.WriteLine("Feesh has scissor!\n");
            }

            if (cpuChoice == playerChoice)
            {
                //Console.WriteLine("Oops, Tie! Nobody points.\n");
                numDraws++;
            }
            else if (cpuChoice == "rock" && playerChoice == "scissors")
            {
                //Console.WriteLine("Feesh has scored point!\n");
                cpuScore++;
            }
            else if (cpuChoice == "scissors" && playerChoice == "paper")
            {
                //Console.WriteLine("Feesh has score point!\n");
                cpuScore++;
            }
            else if (cpuChoice == "paper" && playerChoice == "rock")
            {
                //Console.WriteLine("Feesh has score point!\n");
                cpuScore++;
            }
            else if (playerChoice == "scissors" && cpuChoice == "paper")
            {
                //Console.WriteLine("Uhh.. Player has point :(.\n");
                playerScore++;
            }
            else if (playerChoice == "paper" && cpuChoice == "rock")
            {
                //Console.WriteLine("Uhh.. Player has point :(.\n");
                playerScore++;
            }
            else if (playerChoice == "rock" && cpuChoice == "scissors")
            {
                //Console.WriteLine("Uhh.. Player has point :(.\n");
                playerScore++;
            }
            //Console.WriteLine("Chicken Sandwich");
            /*if (cpuScore >= 5)
            {
                Console.WriteLine("Feesh wins L :)\n");
                break;
            }
            else if (playerScore >= 5)
            {
                Console.WriteLine($"Oh noes {playerName} wins :(");
                break;
            */

            loopCount++;
        }

        Console.WriteLine("Player Score: " + playerScore);
        Console.WriteLine("CPU Score: " + cpuScore);
        Console.WriteLine("Draws : " + numDraws);
    }



}
