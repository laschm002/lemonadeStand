﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Game game = new Game();
            Day day = new Day();
            game.start();
            day.gameEachDay();

            Console.ReadKey();
        }
    
    }
}
