using System;

namespace guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            // vars
            int secrectNumber = 42;


            Game();




            void Game()
            {
            Console.WriteLine("Can you guess the secrect number?");
            string userGuessString = Console.ReadLine();
            int userGuessInt = int.Parse(userGuessString);
            if(secrectNumber == userGuessInt)
            {
            Console.WriteLine($" You guessed it!");
            }
            else
            {
                Console.WriteLine("Not it!");
            }
            }
        }
    }
}
