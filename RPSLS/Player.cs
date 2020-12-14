using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    abstract class Player
    {
        //member variables (has a)
        public string name;
        public int score;
        public List<string> gesturesList = new List<string> { "rock", "paper", "scissors", "lizard", "Spock" };

        //constructor (spawner)
        public Player()
        {
            score = 0;
        }

        //member methods (can do)
        public abstract string SelectGesture();

    }
}
