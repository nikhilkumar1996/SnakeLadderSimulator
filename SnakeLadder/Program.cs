using System;
namespace SnakeLadder {

    public class Program
    {

        public static void Main()
        {

            Console.WriteLine("Welcome to Snake Ladder Program");

            SnakeAndLadderGame SnakeAndLadder = new SnakeAndLadderGame();
            

            int [] players =new int[2] { 1, 2};
            
            
                foreach (int items in players)
                {
                    
                    int PLAYER = SnakeAndLadder.Play(items);
                    



                    if ( PLAYER==100)
                    {
                        Console.WriteLine( "Player {0} wins",items);
                    }
                    return;
                    



                }

            }
        }
    }
