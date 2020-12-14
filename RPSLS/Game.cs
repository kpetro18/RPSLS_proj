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
        public Player player; //solely used for the gesturesList in the CompareGestures method so it looks cleaner/didnt want to have to keep track of swapping between playerOne.gesturesList and playerTwo.gesturesList
        public Player playerOne;
        public Player playerTwo;
        public string playerOneGesture;
        public string playerTwoGesture;
        public int currentRound;

        //constructor (spawner)
        public Game()
        {
            currentRound = 1;
        }
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
            Console.Clear();
        }

        public void StartMatch()
        {
            while (playerOne.score < 2 && playerTwo.score < 2)
            {
                Console.WriteLine("Round: " + currentRound);
                playerOneGesture = playerOne.SelectGesture();
                playerTwoGesture = playerTwo.SelectGesture();
                CompareGesture();
                currentRound++;
                Console.Clear();
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

        public void CompareGesture() //******************   I WOULD LIKE SOME FEED BACK ON HOW TO DO THIS WITHOUT 'MAGIC NUMBERS' *******************************
        {
            if (playerOneGesture == playerTwoGesture)
            {
                Console.WriteLine("It's a tie!");
            }
            else if (playerOneGesture == player.gesturesList[0])
            {
                if (playerTwoGesture == player.gesturesList[2] || playerTwoGesture == player.gesturesList[3])
                {
                    Console.WriteLine(playerOne.name + " wins the round!");
                    playerOne.score ++;
                }
                else
                {
                    Console.WriteLine(playerTwo.name + " wins the round!");
                    playerTwo.score ++;
                }
            }

            else if (playerOneGesture == player.gesturesList[1])
            {
                if (playerTwoGesture == player.gesturesList[0] || playerTwoGesture == player.gesturesList[4])
                {
                    Console.WriteLine(playerOne.name + " wins the round!");
                    playerOne.score++;
                }
                else
                {
                    Console.WriteLine(playerTwo.name + " wins the round!");
                    playerTwo.score++;
                }
            }

            else if (playerOneGesture == player.gesturesList[2])
            {
                if (playerTwoGesture == player.gesturesList[1] || playerTwoGesture == player.gesturesList[3])
                {
                    Console.WriteLine(playerOne.name + " wins the round!");
                    playerOne.score++;
                }
                else
                {
                    Console.WriteLine(playerTwo.name + " wins the round!");
                    playerTwo.score++;
                }
            }

            else if (playerOneGesture == player.gesturesList[3])
            {
                if (playerTwoGesture == player.gesturesList[1] || playerTwoGesture == player.gesturesList[4])
                {
                    Console.WriteLine(playerOne.name + " wins the round!");
                    playerOne.score++;
                }
                else
                {
                    Console.WriteLine(playerTwo.name + " wins the round!");
                    playerTwo.score++;
                }
            }

            else if (playerOneGesture == player.gesturesList[4])
            {
                if (playerTwoGesture == player.gesturesList[0] || playerTwoGesture == player.gesturesList[1])
                {
                    Console.WriteLine(playerOne.name + " wins the round!");
                    playerOne.score++;
                }
                else
                {
                    Console.WriteLine(playerTwo.name + " wins the round!");
                    playerTwo.score++;
                }
            }
        }       
    }
}
