﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        //member variables (has a)
        Player playerOne;
        Player playerTwo;
        List<string> gesturesList = new List<string>(new string[] { "rock", "paper", "scissors", "lizard", "Spock" });
        public int ValidUserInput;


        //constructor (spawner)




        //member methods (can do)
        public void Rules()
        {
            Console.WriteLine("Rock Paper Scissors Lizard Spock");
            Console.WriteLine("Rules:");
            Console.WriteLine("Rock crushes Lizard");
            Console.WriteLine("Rock crushes Scissors");
            Console.WriteLine("Paper covers Rock");
            Console.WriteLine("Paper disproves Spock");
            Console.WriteLine("Scissors cuts Paper");
            Console.WriteLine("Scissors decapitates Lizard");
            Console.WriteLine("Lizard poisons Spock");
            Console.WriteLine("Lizard eats Paper");
            Console.WriteLine("Spock smashes Scissors");
            Console.WriteLine("Spock vaporizes Rock");
            Console.WriteLine("Enter '1' For single player, '2' For two player");
        }

        public void NumberOfPlayers()
        {
            
            Console.WriteLine("Please select '1' for single player or '2' for multiplayer");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    Console.WriteLine("You selected single player vs AI.");
                    Console.WriteLine("Player 1 please enter your name.");
                    playerOne = new Human();
                    playerOne.name = Console.ReadLine();
                    playerTwo = new AI();
                    break;

                case "2":
                    Console.WriteLine("You selected 2 player.");
                    Console.WriteLine("Player 1 please enter your name.");
                    playerOne = new Human();
                    playerOne.name = Console.ReadLine();
                    Console.WriteLine("Player 2 please enter your name.");
                    playerTwo = new Human();
                    playerTwo.name = Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Your entry is invalid, please enter '1' or '2'");
                    NumberOfPlayers();  //need to look into incursion(?) to stop the 'method inception'
                    break;
            }
        }

        //public void isValid(userInput)
        //{
        //    try
        //    {
        //        ValidUserInput = Convert.ToInt32(userInput);
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}


        //Console.WriteLine(" Enter '1' for Rock, '2' for Paper, '3' for Scissors, '4' for Lizard, '5' for Spock");




    }
}
