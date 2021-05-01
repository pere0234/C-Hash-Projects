using System;
/*
*A simple random number guessing game
*A random number is generated and the user must guess correctly within 4 turns
*By: Daniel Pereira
*/
namespace NumberGuessingGame
{
    class NumberGuess
    {
        static void Main(string[] args)
        {
            const int MAX_TURNS = 4;
            int number, numGuessed;
            byte turnCounter, exitCounter;
            string line;
            //Generates a random number
            Random ran = new Random();
            do{
            //Resolves the random number to a 32-bit int
            number = Convert.ToInt32(ran.Next(100));
            //While the number is between 1 and 20, run the loop
            }while(!( ((number >= 1) & (number <= 20))));
            turnCounter = 1; exitCounter = 0;
            do{
            //Prompts user to guess the number
            Console.Write("Guess the number: "); line = Console.ReadLine();
            //Reads the user input
            numGuessed = int.Parse(line);
            //If number guessed equals the generated number, guess is correct
            if( (numGuessed == number) ){
            Console.WriteLine("You guessed correctly!");
            exitCounter = 1;
            }
            //Else if the guess is either too high or too low, prompt user to guess again
            else{
                if( (numGuessed > number) ){
                Console.WriteLine("Guess lower");
                }
            else{
            Console.WriteLine("Guess higher");
            }
        }
        turnCounter++;
        //If user doesn't guess within 4 turns, reveal the number
        }while( ((turnCounter <= MAX_TURNS) & (exitCounter == 0)));
            if( (exitCounter == 0) ){
            Console.Write("The number was: " + number);
            }
            Console.WriteLine();
            Console.Write("Press any key to exit: "); Console.ReadLine();
        }
    }
}
