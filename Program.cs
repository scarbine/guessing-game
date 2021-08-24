﻿using System;
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
            int totalRounds = 0;
            int currentRound = 1;
            int roundsLeft = 0;
            bool isSame = false;

            Console.WriteLine("Welcome to the Guessing Game!");
            Console.WriteLine("Please choose your level of difficulty. Enter the number of the level you would like to choose.");
            Console.WriteLine("1) Easy");
            Console.WriteLine("2) Medium");
            Console.WriteLine("3) Hard");
            string userDifficulty = Console.ReadLine();
            int difficultyLevel = int.Parse(userDifficulty);
            Console.WriteLine(difficultyLevel);
            Console.WriteLine(userDifficulty);

            if(userDifficulty == "3")
            {
                totalRounds = 4;
                roundsLeft = 4;
            }
            else if( userDifficulty == "2")
            {
                totalRounds = 6;
                roundsLeft = 6;
            }
            else
            {
                totalRounds = 8;
                roundsLeft = 8;
            }

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
