using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    public class Weather
    {
        Random rand = new Random();
        public int weatherDemandVariable;
        public int dailyWeather;
        public int conditions;
        public int dailyConditions;

        public Weather ()
        {
            

        }

        public int getDailyWeather()
        {
            dailyWeather = rand.Next(50, 100);
            return dailyWeather;
        }

        public void displayDailyWeather ()
        {
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------------");

            Console.WriteLine("Today the temperature is " + dailyWeather);
        }

        public int getWeatherDemandVariable ()
        {
            dailyWeather = rand.Next(50, 100);

            if (dailyWeather >= 50  && dailyWeather < 70)
            {
                weatherDemandVariable = 1;
                
            }
            else if (dailyWeather >= 70 && dailyWeather < 90)
            {
                weatherDemandVariable = 2;
            }
            else
            {
                weatherDemandVariable = 3;
            }
            
            return weatherDemandVariable;
        }
 
        public void getWeeklyForecast ()
        {
            int monday = rand.Next(50,100);
            int tuesday = rand.Next(50,100);
            int wednesday = rand.Next(50,100);
            int thursday = rand.Next(50,100);
            int friday = rand.Next(50,100);
            int saturday = rand.Next(50,100);
            int sunday = rand.Next(50,100);

            Console.WriteLine("Here is the forecast for the week!");
            Console.WriteLine("");
            Console.WriteLine("Monday the temperature will be " + monday);
            Console.WriteLine("Tuesday the temperature will be " + tuesday);
            Console.WriteLine("Wednesday the temperature will be " + wednesday);
            Console.WriteLine("Thursday the temperature will be " + thursday);
            Console.WriteLine("Friday the temperature will be " + friday);
            Console.WriteLine("Saturday the temperature will be " + saturday);
            Console.WriteLine("Sunday the temperature will be " + sunday);

        }

        public int getDailyConditions()
        {
            dailyConditions = rand.Next(1, 4);

            switch (dailyConditions)
            {
                case 1:
                    Console.WriteLine("It is stormy");
                    break;
                case 2:
                    Console.WriteLine("It is clear");
                    break;
                case 3:
                    Console.WriteLine("It is sunny");
                    break;
                default:
                    break;
            }

            return dailyConditions;

        }


        public int getDailyConditionVariable()
        {

            if (dailyConditions == 1)
            {
                dailyConditions = 1;

            }
            else if (dailyConditions == 2)
            {
                dailyConditions = 2;
            }
            else
            {
                dailyConditions = 3;
            }

            return dailyConditions;
        }


        public void getWeeklyConditions()
        {
            Console.WriteLine("Here is the forecast of conditions for the next 7 days");

            for (int i = 0; i < 7; i++)
            {
                int conditions = rand.Next(1, 4);

                switch (conditions)
                {
                    case 1:
                        Console.WriteLine("stormy");
                        break;
                    case 2:
                        Console.WriteLine("clear");
                        break;
                    case 3:
                        Console.WriteLine("sunny");
                        break;
                    default:
                        break;
                }
              } 
            
        }

        public void getTemperatureAndConditions()
        {
            Weather weather = new Weather();
            weather.getWeeklyForecast(); getWeeklyConditions();
        }
    }
}
