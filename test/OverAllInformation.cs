using System;
using System.Collections.Generic;

namespace test
{
    public class OverAllInformation
    {
        private static float bookRate = 0.0f;
        private static float seriesRate = 0.0f;
        private static float movieRate = 0.0f;

        public static void Display()
        {
            Rating(Program.BookList, Program.SeriesList, Program.MovieList);
            Console.WriteLine("\n\nThe total consumption time = {0} Hours",Program.TotalConsumptionTime);
            Console.WriteLine("Individual consumption time:\nFor Book= {0} Hours    For Series= {1} Hours    For Movies= {2} Hours", Program.ConsumptiontimeForBooks, Program.ConsumptiontimeForSeries, Program.ConsumptiontimeForMovies); 
            Console.WriteLine("\nThe total days of consumption = {0}",Program.TotalDaysOfConsumption);
            Console.WriteLine("Individual days of consumption:\nBook= {0} Days    Series= {1} Days    Movies= {2} Days", Program.ConsumptionDaysForBooks, Program.ConsumptionDaysForSeries, Program.ConsumptionDaysForMovies);
            Console.WriteLine("\nTotal Average rating = {0}", totalAverageRating());
            Console.WriteLine("Average individual rating:\nFor Book= {0}      For Series= {1}      For Movies= {2}", AverageRating(bookRate,Program.BookList.Count),AverageRating(seriesRate,Program.SeriesList.Count),AverageRating(movieRate,Program.MovieList.Count));
            Console.WriteLine("\nTotal number of consumable = {0}",Program.BookList.Count+Program.MovieList.Count+Program.SeriesList.Count);
            Console.WriteLine("Individual number of consumable:\nBooks= {0}    For Series= {1}    For Movies= {2}", Program.BookList.Count, Program.SeriesList.Count, Program.MovieList.Count);
            
        }

        private static void Rating(List<Books> BookList,List<Series> SeriesList, List<Movies> MovieList)
        {
           
            foreach (Books book in BookList)
            {
                bookRate += book._rating;
            }
            foreach (Series series in SeriesList)
            {
                seriesRate += series._rating;
            }
            foreach (Movies movie in MovieList)
            {
                movieRate += movie._rating;
            }
        }
        private static float AverageRating(float item ,int size)
        {
            return item / size; 
        }
        private static float totalAverageRating()
        {
            var bookAverate=AverageRating(bookRate, Program.BookList.Count);
            var seriesAverage=AverageRating(seriesRate, Program.SeriesList.Count);
            var movieAverage=AverageRating(movieRate, Program.MovieList.Count);
            return (bookAverate+seriesAverage+movieAverage)/ 3;
        }
           


        
    }
}
