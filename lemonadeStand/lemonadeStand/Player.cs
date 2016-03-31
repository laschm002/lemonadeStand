using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
   public  class Player
    {
        public string playerName;

        public Player ()
        {
           

        }
        public void getUserName()
        {
            Console.WriteLine("Please Enter Your Name!");

            playerName = Console.ReadLine();

            Console.WriteLine("Hello " + playerName + " here are the rules to play the lemonade stand game");
        }

    }
    
}
