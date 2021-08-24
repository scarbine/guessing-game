using System;

namespace guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Can you guess the secrect number?");
            string userGuessString = Console.ReadLine();
            int userGuessInt = int.Parse(userGuessString);
            Console.WriteLine($" You guessed # {userGuessInt}");

        }
    }
}
