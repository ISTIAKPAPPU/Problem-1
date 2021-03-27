using System;
using System.Collections.Generic;

namespace test
{
    public class EditChoosenItem
    {  

       
        public static void editBooks(List<Books> BookList)
        {

            //Showing Existing Books 
            DisplayExistingItems.Display(BookList);

            Console.WriteLine("Choose Book For Edit:");
            int index = Convert.ToInt32(Console.ReadLine())-1;
            var book = BookList[index];
          
            if(book._endingDate != DateTime.MinValue)
            {
                Console.WriteLine("You Cant't Edit This!!! Its Already End!!!!");
            }
            else
            {
                book._totalTime += AddTime();
                book._totalDay += AddDay();
                book._rating = ChangeRating(book._rating);
                book._endingDate = AddEndingDate();

                // OverAll Result
                Program.TotalConsumptionTime += book._totalTime;
                Program.TotalDaysOfConsumption += book._totalDay;

                // Individual Result
                Program.ConsumptiontimeForBooks += book._totalTime;
                Program.ConsumptionDaysForBooks += book._totalDay;
                
                
            }
           
        }

        public static void editSerise(List<Series> SeriesList)
        {
            //Showing Existing Series 
            DisplayExistingItems.Display(SeriesList);

            Console.WriteLine("Choose Series For Edit:");
            int index = Convert.ToInt32(Console.ReadLine()) - 1;
            var series = SeriesList[index];
      

            if (series._endingDate != DateTime.MinValue)
            {
                Console.WriteLine("You Cant't Edit This!! Its Already End!!!!");
            }
            else
            {
                series._totalTime += AddTime();
                series._totalDay += AddDay();
                series._rating = ChangeRating(series._rating);
                series._endingDate = AddEndingDate();

                // OverAll Result
                Program.TotalConsumptionTime += series._totalTime;
                Program.TotalDaysOfConsumption += series._totalDay;

                // Individual Result
                Program.ConsumptiontimeForSeries += series._totalTime;
                Program.ConsumptionDaysForSeries += series._totalDay;

            }

        }

        public static void editMovies(List<Movies> MovieList)
        {
            //Showing Existing Movies 
            DisplayExistingItems.Display(MovieList);


            Console.WriteLine("Choose Series For Edit:");

            int index = Convert.ToInt32(Console.ReadLine()) - 1;
            var movie = MovieList[index];

            if (movie._endingDate != DateTime.MinValue)
            {
                Console.WriteLine("You Cant't Edit This!! Its Already End!!!!");
            }
            else
            {
                movie._totalTime += AddTime();
                movie._totalDay += AddDay();
                movie._rating = ChangeRating(movie._rating);
                movie._endingDate = AddEndingDate();

                // OverAll Result
                Program.TotalConsumptionTime += movie._totalTime;
                Program.TotalDaysOfConsumption += movie._totalDay;

                // Individual Result
                Program.ConsumptiontimeForMovies += movie._totalTime;
                Program.ConsumptionDaysForMovies += movie._totalDay;

            }
        }



        private static float AddTime()
        {
           Console.WriteLine("Add time(Hours):");
            var input= Console.ReadLine();
            double time;
            while(!double.TryParse(input, out time))
            {
                Console.WriteLine("Invalid input, please retry");
                input = Console.ReadLine();
            }

            return (float)time;

        }

        private static int AddDay()
        {
            Console.WriteLine("Add Days:");
            var input = Console.ReadLine();
            int day;
            while (!int.TryParse(input, out day))
            {
                Console.WriteLine("Invalid input, please retry");
                input = Console.ReadLine();
            }

            return day;
        }


        private static float ChangeRating(float previousRating)
        {
            if (isChangeRating() == 1)
            {
              Console.WriteLine("Enter Rating(out of 10):");
              var input= Console.ReadLine();
              double rating;
              ValidRating:
              while(!double.TryParse(input, out rating))
              {
                Console.WriteLine("Invalid input, please retry");
                input = Console.ReadLine();
              }
              if (rating > 10 || rating < 0)
               {
                    Console.WriteLine("Invalid Rating !! try again (0 to 10)");
                    input = Console.ReadLine();
                    goto ValidRating;
               }  
              else
               {
                 return (float)rating;
               }
              
            }
            else
            {
                return previousRating;
            }
            
          
        }
        private static DateTime AddEndingDate()
        {
            Console.WriteLine("Consumption ending date in format YYYY-MM-DD:");
            DateTime endingDate = DateTime.MinValue; ;
            string endingDateInpute = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(endingDateInpute))
            {
                endingDate = DateTime.MinValue;
            }
            else
            {
                while (!DateTime.TryParseExact(endingDateInpute, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out endingDate))
                {
                    Console.WriteLine("Invalid date, please retry");
                    endingDateInpute = Console.ReadLine();
                }
            }
            return endingDate;

        }


        //Change Rating or not
        private static int isChangeRating()
        {
            Console.WriteLine("Change Rating:");
            Console.WriteLine("1) YES");
            Console.WriteLine("2) NO");
            var userinput = Console.ReadLine();
            while (String.IsNullOrWhiteSpace(userinput) ==true)
            {
                Console.WriteLine("Wrong input!! Choose properly.");
                userinput = Console.ReadLine();
            }
            var input = Convert.ToInt32(userinput);
            while (true)
            {  

               if(input==1||input==2)
                {
                    return input;
                    
                }
                else
                {
                    Console.WriteLine("Wrong input!!  Choose properly.");
                    input = Convert.ToInt32(Console.ReadLine());
                    
                }
            }

        }
    }
    
}
