using System;

namespace SnakeLadderSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To SnakeLadder:");

            int DiceCount1=SnakeLadderGame.GamePlay(1);
            int DiceCount2 = SnakeLadderGame.GamePlay(2);

            if (DiceCount1 > DiceCount2)
            {
                Console.WriteLine("first player win the game");
            }
            else if (DiceCount2 > DiceCount1)
            {
                Console.WriteLine("Second Player win the game");
            }
            else
            {
                Console.WriteLine("tie the game between both Player");
            }
            
        }
    }
}
