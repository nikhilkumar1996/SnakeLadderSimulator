using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
    public class SnakeAndLadderGame
    {
        const int NoPlay = 0, Ladder = 1, Snake = 2, Winner = 3, WinningPosition = 100;
        int playerChange = 1, count = 0; //playerChange=1(PLAYER 1) && playerChnage=2(PLAYER 2)
        Random random = new Random();
        public int DiceRoll()
        {
            count++;
            return random.Next(1, 7);

        }
        public void Play(int playerPosition1, int playerPosition2)
        {
            Console.WriteLine("PLAYER:" + this.playerChange + "is playing \n");
            bool flag = true;
            while (playerPosition1 <= WinningPosition || playerPosition2 <= WinningPosition && flag)
            {

                int roll = random.Next(0, 4);
                if (playerChange == 1)
                {
                    switch (roll)
                    {
                        case NoPlay:
                            Console.WriteLine("Player{0} hasn't rolled the dice", playerChange);
                            playerChange = 2;

                            continue;

                        case Ladder:
                            if (playerPosition1 + DiceRoll() < 100 && playerChange == 1)
                            {
                                playerPosition1 += DiceRoll();




                            }
                            break;

                        case Snake:
                            if (playerPosition1 - DiceRoll() > 0 && playerChange == 1)
                            {
                                playerPosition1 = playerPosition1 - DiceRoll();
                                playerChange = 2;

                            }
                            else
                            {
                                playerPosition1 = 0;
                            }
                            break;

                        case Winner:
                            if (playerPosition1 + DiceRoll() == 100 && playerChange == 1)
                            {

                                playerPosition1 += DiceRoll();
                                flag = false;
                            }
                            break;
                    }
                    Console.WriteLine("Player 1 current position : " + playerPosition1);


                }



                if (playerChange == 2)
                {
                    switch (roll)
                    {
                        case NoPlay:
                            Console.WriteLine("Player{0} hasn't rolled the dice", playerChange);
                            playerChange = 1;

                            continue;

                        case Ladder:
                            if (playerPosition2 + DiceRoll() < 100 && playerChange == 2)
                            {
                                playerPosition2 += DiceRoll();



                            }
                            break;

                        case Snake:
                            if (playerPosition2 - DiceRoll() > 0 && playerChange == 2)
                            {
                                playerPosition2 = playerPosition2 - DiceRoll();
                                playerChange = 1;

                            }
                            else
                            {
                                playerPosition2 = 0;
                            }
                            break;

                        case Winner:
                            if (playerPosition2 + DiceRoll() == 100 && playerChange == 2)
                            {

                                playerPosition2 += DiceRoll();
                                flag = false;
                            }
                            break;
                    }
                    Console.WriteLine("Player 2 current position : " + playerPosition2);
                }

            }

            //Print winner 
            if (playerPosition1 == WinningPosition)
            {
                Console.WriteLine("Winner is player 1  :" + playerPosition1);
                Console.WriteLine("Final position of player 2  :" + playerPosition2);
            }
            else
            {
                Console.WriteLine("Winner is player 2  :" + playerPosition2);
                Console.WriteLine("Final position of player 1  :" + playerPosition1);
            }
            //Total Number of game played
            Console.WriteLine("Number of times game played :" + this.count);



        }

    }
}