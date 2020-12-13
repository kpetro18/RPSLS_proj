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
        public List<string> gesturesList = new List<string>(new string[] { "'1' for rock", "'2' for paper", "'3' for scissors", "'4' for lizard", "'5' for Spock" });

        //constructor (spawner)
        public Player()
        {
        }

        //member methods (can do)
        public abstract string SelectGesture();

    }
}
