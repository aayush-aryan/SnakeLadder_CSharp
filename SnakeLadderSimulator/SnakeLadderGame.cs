using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeLadderSimulator
{
    public class SnakeLadderGame
    {
        static int Position = 0;
        const int Ladder = 1, Snake = 2, WinPosition = 100;
        static int currentPosition;
        /// <summary>
        /// rolling die Method
        /// </summary>
        /// <returns></returns>
        public static int RandomValueGenerator(int start, int end)
        {
            Random random = new Random();
            return random.Next(start, end);
        }
        /// <summary>
        /// method rule for Game
        /// </summary>
        public static void GamePlay()
        {
            int diceNumber, optionCheck;

            for(Position=0;Position<WinPosition;Position++)
            {
                 diceNumber = RandomValueGenerator(1, 7);
                 optionCheck = RandomValueGenerator(0, 3);

                switch (optionCheck)
                {
                    case Ladder:
                        currentPosition = Position + diceNumber;
                        if (currentPosition > 100)
                        {
                            Position = Position+0;
                        }
                        else
                        {
                            Position = currentPosition;
                        } 
                        break;
                    case Snake:
                        currentPosition = Position - diceNumber;
                        if (currentPosition <= 0)
                        {
                            Position = 0;
                        }
                        else
                        {
                            Position = currentPosition;
                        }
                        break;
                    default:
                        Position = currentPosition;
                        break;
                }
                Console.WriteLine("player_Current_Position :" + Position);
            }
            
        }
    }
}
