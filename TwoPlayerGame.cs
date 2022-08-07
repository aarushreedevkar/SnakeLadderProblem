using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
public static class TwoPlayerGame
    {
        public static void TwoPlayer()
        {
            const int Startposition = 0;    //starting position 0
            const int NO_PLAY = 1;
            const int LADDER = 2;
            const int SNAKE = 3;
            Random random = new Random();
            int option = random.Next(1, 4); //random value genreted 1-3
            int dieValue = random.Next(1, 7); //random value genreted 1-6
            Console.WriteLine("Player Roll Dies:" + dieValue);
            int CurrentPosition = 0;

            switch (option)   //start switch
            {
                case NO_PLAY:
                    Console.WriteLine("No Play");
                    break;
                case LADDER:
                    CurrentPosition = dieValue + CurrentPosition;
                    Console.WriteLine("You got Ladder \n player position = " + CurrentPosition);
                    break;
                case SNAKE:
                    CurrentPosition = CurrentPosition - dieValue;
                    Console.WriteLine("You gotSnake \n player position = " + CurrentPosition);
                    break;

            } //end switch
            //Console.ReadLine();
            //Game game = new Game();
            //game.Play();
            //Console.Read();
        }
    }
}

       
