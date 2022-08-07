using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
    public static class RollsTheDie
    {
       public static void RollAndDie()
        {
           
            int position = 0;
            Console.WriteLine("Start position of player: " + position);
            Console.ReadLine();
            Random random = new Random();
            int dieValue = random.Next(1, 7);
            Console.WriteLine(" Player die roll position = " + dieValue);
            Console.ReadLine();
        } 
    }
}
