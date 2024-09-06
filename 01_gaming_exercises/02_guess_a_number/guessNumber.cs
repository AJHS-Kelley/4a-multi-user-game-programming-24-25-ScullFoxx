// Guess a Number, Sculley, Alexandra, v1.0

using System;
class GuessNumber {
    static void Main() {
        int numGuess = 0;
        int maxGuess;
        int minimumNum;
        int maxNum;
        int guess;
        // Generate the secret number
        Random rnd = new Random(); // Create an object named 'rnd' that is a copy of the Random() class.
        Console.WriteLine("Welcome to number guess! You just guess a number\n");
        Console.WriteLine("How many guesses would you like for this game?\n");
        maxGuess = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("What would you like your MINIMUM number to guess to be?");
        minimumNum = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("What would you like your MAXIMUM number to guess to be? (MAKE SURE TO ADD 1 TO WHATEVER YOU WANT!)\n");
        maxNum = Convert.ToInt32(Console.ReadLine());
        int secretNum = rnd.Next(minimumNum, maxNum); // Generate from 0 to 99
        // Console.WriteLine(secretNum);
        // int secretNum = rnd.Next(25, 1000); // Generate from 25 to 999
        while (numGuess < maxGuess) {
        
            Console.WriteLine("Pick a number " + minimumNum + " through " + maxNum);
            guess = Convert.ToInt32(Console.ReadLine());
            numGuess++;
            if (guess > secretNum)
            {
                Console.WriteLine("Your guess is too high!");
            }
            else if (guess < secretNum)
            {
                Console.WriteLine("Your guess is too low!");
            }
            else
            {
                Console.WriteLine("Congrats! You guess the secret number!");
                break;
            }
            
            if (numGuess >= maxGuess)
            {
                Console.WriteLine("You've run out of guesses. The Secret number was " + secretNum + ". Try again!");
                break;
            }
        }
        // while loop
            // Allow the user to guess the number.
            // Compare the guess to the secret number.
            // If match, print win, if >  or <, give hint.
            // +1 to numGuess
            // Check if numGuess > maxGuesses
            // If true, print a "lose game" message, if false guess again.
    }
}