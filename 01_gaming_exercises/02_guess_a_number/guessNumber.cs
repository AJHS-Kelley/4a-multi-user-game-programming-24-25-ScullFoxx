// Guess a Number, Sculley, Alexandra, v0.2

using System;
class GuessNumber {
    static void Main() {
        int numGuess = 0;
        int maxGuess = 4;
        int guess;
        // Generate the secret number
        Random rnd = new Random(); // Create an object named 'rnd' that is a copy of the Random() class.
        int secretNum = rnd.Next(101); // Generate from 0 to 99
        // Console.WriteLine(secretNum);
        // int secretNum = rnd.Next(25, 1000); // Generate from 25 to 999
        while (numGuess < maxGuess) {
        
            Console.WriteLine("Pick a number 0 through 100.");
            guess = Convert.ToInt32(Console.ReadLine());
            if (guess == secretNum)
            {
                Console.WriteLine("Congrats! You guessed the secret number! The number was: " + secretNum);
                break;
            }
            else if (guess != secretNum)
            {
                Console.WriteLine("That's not it! You did not guess the secret number.");
                numGuess++;
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