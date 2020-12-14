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
        public bool validUserInput;

        //constructor (spawner)
        public Human()
        {
            validUserInput = false;
        }

        //member methods (can do)
        public override string SelectGesture()
        {
            DisplayGesturesList();
            Console.WriteLine(name + " Please select your gesture.");
            string userInput = Console.ReadLine();
            IsValid(userInput);

            if (validUserInput == true)
            {
                return userInput;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("youre input was invalid");
                return SelectGesture();
            }
        }

        public void IsValid(string userInput)
        {
            for (int i = 0; i < gesturesList.Count; i++)
            {
                if (userInput == gesturesList[i])
                {
                    validUserInput = true;
                    break;
                }
                else
                {
                    validUserInput = false;
                }
            }
        }
        public void DisplayGesturesList()
        {
            for (int i = 0; i < gesturesList.Count; i++)
            {
                Console.WriteLine(i + " " + gesturesList[i]);
            }
        }
    }
}
