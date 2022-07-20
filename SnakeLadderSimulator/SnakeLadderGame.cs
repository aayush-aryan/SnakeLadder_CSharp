using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeLadderSimulator
{
    class SnakeLadderGame
    {
        int Position = 0;
        /// <summary>
        /// rolling die Method
        /// </summary>
        /// <returns></returns>
        static int RollingDie()
        {
            Random random = new Random();
            return random.Next(1, 7); ;
        }
    }
}
