using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    class Store
    {
        Weather dailyWeather = new Weather();
        public List<Customer> customers = new List<Customer>();
        Game game = new Game();
        public double pitcherAmount;
        public double cupPrice;
        public double dailyPlayerChoices;
        public double balance;
        public int priceVariable;
        double sales;
        int numberOfCustomers = 100;
        public double totalDailySales;
        double profit;
       


        public Store(double Sales, double Balance, double Profit)
        {
            balance = 40;
            sales = Sales;
            profit = Profit;
            
        }

        public void getWeeklyWeatherFunctions()
        {
            dailyWeather.getWeeklyForecast();
            dailyWeather.getWeeklyConditions();
        }
        public void getDailyWeatherFunctions()
        {
            dailyWeather.getDailyWeather();
            dailyWeather.displayDailyWeather();
            dailyWeather.getWeatherDemandVariable();
            dailyWeather.getDailyConditions();
            dailyWeather.getDailyConditionVariable();
        }
        
        public double getDailyCostOfCup()
        {
            Console.WriteLine("Please enter the lemonade cup price for the day based on the weather!");
            Console.WriteLine("Enter a price .50 to $4");

            cupPrice = Convert.ToDouble(Console.ReadLine());


            if (cupPrice >= .50 && cupPrice <= 4)
            {
                Console.WriteLine("You are selling cups of lemonade at $ " + cupPrice + " for the day");
            }

            else
            {
                Console.WriteLine("You can only enter a number between .50 and $3!");
                getDailyCostOfCup();
            }
            return cupPrice;
        }
        public int getPriceVariable()
        {
            int CupPrice =Convert.ToInt32(cupPrice);
            if (CupPrice >= .50 && CupPrice < 1.50)
            {
                priceVariable = 3;
            }
            else if (CupPrice >= 1.50 && CupPrice < 2.50)
            {
                priceVariable = 2;
            }
            else
            {
                priceVariable = 1;
            }
            return priceVariable;
        }


        public double getPitcherAmounts()
        {
            Console.WriteLine("Please enter how many pitchers you would like to make for the day!");
            Console.WriteLine("The number must be between 1 and 10!");

            pitcherAmount = Convert.ToDouble(Console.ReadLine());

            if (pitcherAmount >= 1 && pitcherAmount <= 10)
            {
                Console.WriteLine("You have decided to make " + pitcherAmount + " for the day");
            }
            
            else
            {
                Console.WriteLine("You can only enter a number between 1 and 10!");
                getPitcherAmounts();
            }
            return pitcherAmount;

        }
        
        public double getPlayerChoices()
        {
            dailyPlayerChoices = pitcherAmount * 10;
            
            Console.WriteLine("Your total cost for the day is $ " + dailyPlayerChoices);
            return dailyPlayerChoices;

        }
        public double getBalance()
        {
            balance -= dailyPlayerChoices;

            Console.WriteLine("After your expenses for the day, your balance is now " + balance);

            return balance;
        }


        public Customer GetCustomer()
        {
            Random rand = new Random();
            Customer customer = new Customer(rand.Next(1, 4), (rand.Next(1, 4)));
            return customer;
        }
        public List<Customer> CreateCustomers()
        {

            for (int i = 0; i < numberOfCustomers; i++)
            {
                Customer customer = GetCustomer();
                customers.Add(customer);
            }
            return customers;
        }
        public void sellCupOfLemonade(Customer customer)
        {
            this.sales += 1;
            customer.cash -= 1;
        }


        public void getDailyDemand(Customer customer)
        {
            int demandScore;
            demandScore = dailyWeather.getWeatherDemandVariable() + dailyWeather.getDailyConditionVariable() + getPriceVariable()+ customer.getCustomerMood() + customer.getCustomerWilingToSpend();
            if (demandScore > 9)
            {
                sellCupOfLemonade(customer);

            }

            else
            {

            }

        }

        public void DecideWhetherCustomerBuysLemonade()
        {
            foreach (Customer customer in customers)
            {
                getDailyDemand(customer);
            }
            totalDailySales = sales;
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("RESULTS FROM THE DAY");
            Console.WriteLine("You sold " + totalDailySales + " cups of lemonade!");
        }

        public double getDayProfit()
        {
            profit = (totalDailySales * cupPrice) - (pitcherAmount * 10);
            Console.WriteLine("This is your profit from selling lemonade today " + "$" + profit);
            return profit;

        }

        public double addDailyProfitToBalance()
        {
           balance += profit;
            Console.WriteLine("This is how much money you have in the store " + "$" + balance);
            return balance; ;
        }

        public void reset()
        {
            this.sales = 0;
            customers.Clear();
        }


    }
}

