using System;

namespace guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            // vars
            int secrectNumber = 42;
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
                    Console.WriteLine($"You guessed it in round: {currentRound}");
                   
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
            }
            }
        }
    }
}
