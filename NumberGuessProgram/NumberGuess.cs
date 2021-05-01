using System;

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
            //Generates a random numberber from 1-20
            Random ran = new Random();
            do{
            number = Convert.ToInt32(ran.Next(100));
            }while(!( ((number >= 1) & (number <= 20))));
            turnCounter = 1; exitCounter = 0;
            do{
            Console.Write("Guess the number: "); line = Console.ReadLine();
            numGuessed = int.Parse(line);
            if( (numGuessed == number) ){
            Console.WriteLine("You guessed correctly!");
            exitCounter = 1;
            }
            else{
                if( (numGuessed > number) ){
                Console.WriteLine("Guess lower");
                }
            else{
            Console.WriteLine("Guess higher");
            }
        }
        turnCounter++;
        }while( ((turnCounter <= MAX_TURNS) & (exitCounter == 0)));
            if( (exitCounter == 0) ){
            Console.Write("The number was: " + number);
            }
            Console.WriteLine();
            Console.Write("Press any key to exit: "); Console.ReadLine();
        }
    }
}