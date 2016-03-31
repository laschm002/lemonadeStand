using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    public class Game
    {
        
        Player player = new Player();

        public Game()
        {
            
        }

        public void start ()
        {
            welcome();
            player.getUserName();
            getRules();
           
        }

        public void welcome()
        {
            Console.WriteLine("Lemonade Stand Game");
        }

        public void getRules()
        {
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Here are the rules for the game!");
            Console.WriteLine("1.   You will be running a lemonade stand for 1 week, starting Monday!");
            Console.WriteLine("2.   Your inital investment to start the lemonade stand is $40");
            Console.WriteLine("3.   You will be provided with the weather forecast for the week detailing the temperature and weather conditions");
            Console.WriteLine("4.   Each day you will need to change the price of the lemonade and the amount of pitchers made based on the weather!");
            Console.WriteLine("5.   1 pitcher = 10 cups of lemonade and costs 10 dollars to make!  That means you need to sell a cup of lemonade for at least $1 to break even!");
            Console.WriteLine("6.   Each day 100 customers will pass by your stand!");
            Console.WriteLine("7.   At the end of the day, whatever is remaining in the pitchers of lemonade will be considered waste, subtracting from your balance!");
            Console.WriteLine("8.   At the end of the day, you will see your total profit for that day and your current balance");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------");

        }
        


    }
}
  

