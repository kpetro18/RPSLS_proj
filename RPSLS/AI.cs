using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class AI : Player
    {
        public override string SelectGesture()
        {
            name = "Computer";
            Random num = new Random();
            int rand = num.Next(0, gesturesList.Count);
            return gesturesList[rand];
        }
    }
}
