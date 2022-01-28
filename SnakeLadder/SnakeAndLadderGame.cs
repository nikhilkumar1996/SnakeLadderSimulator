using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
    public class SnakeAndLadderGame
    {
        int playerPosition = 0;
        Random random = new Random();
        public int DiceRoll()
        {
            return random.Next(1, 7);
        }
        
    }
}
