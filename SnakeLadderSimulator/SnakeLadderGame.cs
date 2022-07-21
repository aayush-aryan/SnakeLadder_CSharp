using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeLadderSimulator
{
    public class SnakeLadderGame
    {
        static int Position = 0; 
        const int Ladder = 1, Snake = 2, WinPosition = 100;
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
            int diceNumber = 0, optionCheck = 0;

            while (Position<=WinPosition)
            {
                 diceNumber = RandomValueGenerator(1, 7);
                 optionCheck = RandomValueGenerator(0, 3);
                switch (optionCheck)
                {
                    case Ladder:
                        Position = Position + diceNumber;
                        break;
                    case Snake:
                        Position = Position - diceNumber;
                        if (Position < 0)
                        {
                            Position = 0;
                        }
                        break;
                    default:
                        Position = Position+0;
                        break;
                }
            }
            
            Console.WriteLine("player_Current_Position :" + Position);
        }
    }
}
