using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
    public class SnakeAndLadderGame
    {
        const int NoPlay = 0, Ladder = 1, Snake = 2, WinningPosition = 100;
        int playerPosition = 0;
        Random random = new Random();
        public int DiceRoll()
        {

            return random.Next(1, 7);

        }
        public void Play()
        {
            while (this.playerPosition < WinningPosition)
            {

                int roll = random.Next(0, 3);
                switch (roll)
                {
                    case NoPlay:
                        Console.WriteLine("Player hasn't rolled the dice");
                        break;

                    case Ladder:
                        if (this.playerPosition + DiceRoll() <= 100)
                        {
                            this.playerPosition += DiceRoll();

                        }
                        break;

                    case Snake:
                        if (this.playerPosition - DiceRoll() >= 0)
                        {
                            this.playerPosition = playerPosition - DiceRoll();

                        }

                        else
                        {
                            this.playerPosition = 0;
                        }

                        break;


                }


            }

        }

    }
}
