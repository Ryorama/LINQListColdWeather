using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQListColdWeather
{

    public enum DaysOfWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday

    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Weather> daysForcasted = new List<Weather>();
            daysForcasted.Add(new Weather(DaysOfWeek.Thursday, 33, 24));
            daysForcasted.Add(new Weather(DaysOfWeek.Friday, 34, 28));
            daysForcasted.Add(new Weather(DaysOfWeek.Saturday, 41, 35));
            daysForcasted.Add(new Weather(DaysOfWeek.Sunday, 40, 31));
            daysForcasted.Add(new Weather(DaysOfWeek.Monday, 44, 31));

            var coldDays =
                from forecast in daysForcasted
                where forecast.HighTemp < 40
                select forecast;

            foreach (var cd in coldDays)
            {
                Console.WriteLine("Cold weather on {0}", cd.Day);
            }

        }
    }

    class Weather
    {

        public DaysOfWeek Day { get; set; }
        public int HighTemp { get; set; }
        public int LowTemp { get; set; }

        public Weather(DaysOfWeek day, int high, int low) {
            Day = day;
            HighTemp = high;
            LowTemp = low;
        }
    }
}
