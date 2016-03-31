using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    public class Day
    {
       
        Store store = new Store(0,0,0);

        
        public Day()
        {
            
        }


        public void gameEachDay()
        {
            store.getWeeklyWeatherFunctions();

           int day = 0;
           while (day < 7)
            {
                store.getDailyWeatherFunctions();
                store.getPitcherAmounts();
                store.getDailyCostOfCup();
                store.getPlayerChoices();
                store.getBalance();

                store.CreateCustomers();
                store.DecideWhetherCustomerBuysLemonade();
                store.getDayProfit();
                store.addDailyProfitToBalance();
                store.reset();

                day++;
            }

        }

    }     
}
