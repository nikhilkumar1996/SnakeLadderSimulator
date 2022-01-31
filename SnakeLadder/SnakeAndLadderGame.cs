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
        int playerPosition = 0, count = 0;
        Random random = new Random();
        public int DiceRoll()
        {
            count++;
            return random.Next(1, 7);

        }
        public int Play(int player)
        {
            while (this.playerPosition <= WinningPosition)
            {

                int roll = random.Next(0, 3);
                switch (roll)
                {
                    case NoPlay:
                        {
                            Console.WriteLine("Player hasn't rolled the dice");

                            return 0;
                        }
                        
                        
                       
                        

                    case Ladder:
                        if (this.playerPosition + DiceRoll() < 100)
                        {
                            this.playerPosition += DiceRoll();

                            this.playerPosition += DiceRoll();
                            return this.playerPosition;

                        }
                        if (this.playerPosition + DiceRoll() == 100)
                        {
                            Console.WriteLine("Winner",this.playerPosition);
                            return 100;
                        }
                         
                        
                        break;

                    case Snake:
                        if (this.playerPosition - DiceRoll() > 0)
                        {
                            this.playerPosition = playerPosition - DiceRoll();
                            return this.playerPosition;

                        }

                        else
                        {
                            this.playerPosition = 0;
                            return this.playerPosition;
                        }

                        
                  
                    


                }
                Console.WriteLine("PlayerPosition=" + this.playerPosition);

            }
            Console.WriteLine("Count of Dice Rolled=" + count);
            
            return this.playerPosition;
            
        }

    }
}