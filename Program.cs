using System;
using System.Text.RegularExpressions;

namespace guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            // vars
            Random rnd = new Random();
            int secrectNumber = rnd.Next(1,100);
            int userGuess = 0;
            int counter = 0;
            int totalRounds = 4;
            int currentRound = 1;
            int roundsLeft = totalRounds;
            bool isSame = false;

            while(counter < totalRounds){
                Game();
                counter++;
                currentRound++;
                roundsLeft--;
                if(userGuess == secrectNumber)
                {
                    Console.WriteLine($"You guessed it in round: {(currentRound -1)}");
                   
                    break;
                }
            }


            
            if(!isSame)
            {
                Console.WriteLine("Sorry you have run out of turns!");
            }

            void Game()
            {
            Console.WriteLine($"Round {currentRound}");
            // Console.WriteLine($"Secrect Number {secrectNumber}");
            Console.WriteLine($"Can you guess the secrect number? You have {roundsLeft} rounds left");
            string userGuessString = Console.ReadLine();
            int userGuessInt = int.Parse(userGuessString);
            userGuess = userGuessInt;
            if(secrectNumber == userGuessInt)
            {
            isSame = true;
            return;
            }
            else
            {
                Console.WriteLine($"{userGuess} is not it!");
                if(userGuess > secrectNumber)
                {
                    Console.WriteLine("Your guess was too high.");
                }
                else
                {
                    Console.WriteLine("Your guess was too low.");
                }
            }
            }
        }
    }
}
