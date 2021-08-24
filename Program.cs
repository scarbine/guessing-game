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
            bool isSame = false;

            while(counter < 4){
                Game();
                counter++;
                if(userGuess == secrectNumber)
                {
                    Console.WriteLine("You guessed it");
                    break;
                }
            }


            
            if(!isSame)
            {
                Console.WriteLine("Sorry you have run out of turns!");
            }

            void Game()
            {
            Console.WriteLine("Can you guess the secrect number?");
            string userGuessString = Console.ReadLine();
            int userGuessInt = int.Parse(userGuessString);
            if(secrectNumber == userGuessInt)
            {
            userGuess = userGuessInt;
            isSame = true;
            return;
            }
            else
            {
                Console.WriteLine("Not it!");
            }
            }
        }
    }
}
