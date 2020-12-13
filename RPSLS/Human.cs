using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Human : Player
    {
        //member variables (has a)

        //constructor (spawner)

        //member methods (can do)
        public override string SelectGesture()
        {
            Console.WriteLine(this.name + " Please select your gesture.");
            gesturesList.ForEach(Console.WriteLine);
            //Console.WriteLine(name + " Enter '1' for Rock, '2' for Paper, '3' for Scissors, '4' for Lizard, '5' for Spock");
            string userInput = Console.ReadLine();

            if (userInput == "1" || userInput == "2" || userInput == "3" || userInput == "4" || userInput == "5")
            {
                return userInput;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Your entry is invalid.");
                return SelectGesture();
            }
        }
    }
}
