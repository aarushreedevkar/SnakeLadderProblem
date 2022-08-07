﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
    public static  class ExactWinningPosition
    {
        public static void PlayerExactPosition()
        {
            const int START_POSITION = 0;
            const int NO_PLAY = 0;
            const int LADDER = 1;
            const int SNAKE = 2;
            const int WINNING_POSITION = 100;

            int player = 0;
            while (player < WINNING_POSITION)
            {
                Random random = new Random();
                int option = random.Next(0, 3);
                int dieValue = random.Next(1, 7);
                switch (option)
                {
                    case NO_PLAY:
                        Console.WriteLine("No Play, Pass the chance");
                        break;
                    case LADDER:
                        player += dieValue;
                        Console.WriteLine("You got Ladder \n player position = " + player);
                        break;
                    case SNAKE:
                        player -= dieValue;
                        if (player < START_POSITION)
                        {
                            player = START_POSITION;
                        }
                        Console.WriteLine("You gotSnake \n player position = " + player);
                        break;
                    default:
                        break;
                }
            }
        }

    }
} 
      
