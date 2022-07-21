﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeLadderSimulator
{
    public class SnakeLadderGame
    {
        static int Position = 0;
        const int Ladder = 1, Snake = 2;
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
        /// method rule for Game play
        /// </summary>
        public static void GamePlay()
        {
            int diceNumber = RandomValueGenerator(1, 7);
            int optionCheck = RandomValueGenerator(0, 3);
            switch (optionCheck)
            {
                case Ladder:
                    Position += diceNumber;
                    break;
                case Snake:
                    Position -= diceNumber;
                    break;
                default:
                    Position += 0;
                    break;
            }
            Console.WriteLine("player_Current_Position :" + Position);
        }

    }
}
