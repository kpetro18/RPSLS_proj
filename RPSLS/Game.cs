using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        //member variables (has a)
        public Player playerOne;
        public Player playerTwo;
        public string playerOneGesture;
        public string playerTwoGesture;
        public int currentMatch;

        //public int ValidUserInput;


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

        public void StartMatch()
        {
            while (playerOne.score < 2 && playerTwo.score < 2)
            {
                Console.WriteLine("Round: " + currentMatch);
                playerOneGesture = playerOne.SelectGesture();
                playerTwoGesture = playerTwo.SelectGesture();
                CompareGesture();
            }
            if (playerOne.score >= 2)
            {
                Console.WriteLine(playerOne.name + " wins the match!!");
            }
            else
            {
                Console.WriteLine(playerTwo.name + " wins the match!!");
            }
        }

        public void CompareGesture()
        {
            if (playerOneGesture == playerTwoGesture)
            {
                Console.WriteLine("It's a tie!");
            }
            else if (playerOneGesture == "1")
            {
                if (playerTwoGesture == "3" || playerTwoGesture == "4")
                {
                    Console.WriteLine(playerOne.name + " wins the round!");
                    playerOne.score += playerOne.score;
                }
                else
                {
                    Console.WriteLine(playerTwo.name + " wins the round!");
                    playerTwo.score += playerTwo.score;
                }
            }

            else if (playerOneGesture == "2")
            {
                if (playerTwoGesture == "1" || playerTwoGesture == "5")
                {
                    Console.WriteLine(playerOne.name + " wins the round!");
                    playerOne.score += playerOne.score;
                }
                else
                {
                    Console.WriteLine(playerTwo.name + " wins the round!");
                    playerTwo.score += playerTwo.score;
                }
            }

            else if (playerOneGesture == "3")
            {
                if (playerTwoGesture == "2" || playerTwoGesture == "4")
                {
                    Console.WriteLine(playerOne.name + " wins the round!");
                    playerOne.score += playerOne.score;
                }
                else
                {
                    Console.WriteLine(playerTwo.name + " wins the round!");
                    playerTwo.score += playerTwo.score;
                }
            }

            else if (playerOneGesture == "4")
            {
                if (playerTwoGesture == "2" || playerTwoGesture == "5")
                {
                    Console.WriteLine(playerOne.name + " wins the round!");
                    playerOne.score += playerOne.score;
                }
                else
                {
                    Console.WriteLine(playerTwo.name + " wins the round!");
                    playerTwo.score += playerTwo.score;
                }
            }

            else if (playerOneGesture == "5")
            {
                if (playerTwoGesture == "1" || playerTwoGesture == "2")
                {
                    Console.WriteLine(playerOne.name + " wins the round!");
                    playerOne.score += playerOne.score;
                }
                else
                {
                    Console.WriteLine(playerTwo.name + " wins the round!");
                    playerTwo.score += playerTwo.score;
                }
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






    }
}
