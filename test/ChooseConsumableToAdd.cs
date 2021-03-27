using System;

namespace test
{
    public class ChooseConsumableToAdd
    {
       public static void chooseType()
        {
            
            Console.Clear();
            Console.WriteLine("\nConsumable Types:");
            Console.WriteLine("1) Books");
            Console.WriteLine("2) Series");
            Console.WriteLine("3) Movies");
            Console.WriteLine("4) Go to Mainmenu");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("\nAdding Book");
                    var Books = new Books(AddName(), AddStartingDate(), AddEndingDate(), AddRating());
                    Program.BookList.Add(Books);
                    Program.MainMenu();
                    break;
                case "2":
                    Console.WriteLine("\nAdding Series");
                    var series = new Series(AddName(), AddStartingDate(), AddEndingDate(), AddRating());
                    Program.SeriesList.Add(series);
                    Program.MainMenu();
                    break;
                case "3":
                    Console.WriteLine("\nAdding Movies");
                    var movies = new Movies(AddName(), AddStartingDate(), AddEndingDate(), AddRating());
                    Program.MovieList.Add(movies);
                    Program.MainMenu();
                    break;
                case "4":
                    Console.WriteLine("Main Manue");
                    Program.MainMenu();
                    break;
                default:
                    break;

            }
        }


        private static string AddName()
        {

            Console.WriteLine("Enter Name:");
            string name = Console.ReadLine();
            while (true)
            {

                if (String.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("Name can't blank!!Enter Name Again.");
                    name = Console.ReadLine();
                }
                else
                {
                    break;
                }
            }
            return name;
        }



        private static float AddRating()
        {
            Console.WriteLine("Enter Rating(Out of 10) or press Enter to continue):");
            var input = Console.ReadLine();
            double rating;
            if(String.IsNullOrWhiteSpace(input))
            {
                return 0.0f;
            }
            else
            {
                ValidRating:
                while (!double.TryParse(input, out rating))
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
           


        }



        private static DateTime AddStartingDate()
        {
            Console.WriteLine("Consumption starting date in the format YYYY-MM-DD(could be blank)");
            DateTime startingDate;
            string startingDateInput = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(startingDateInput))
            {
                startingDate = DateTime.MinValue;
            }
            else
            {
                while (!DateTime.TryParseExact(startingDateInput, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out startingDate))
                {
                    Console.WriteLine("Invalid date, please retry");
                    startingDateInput = Console.ReadLine();
                }
            }

            return startingDate;

        }




        private static DateTime AddEndingDate()
        {
            Console.WriteLine("Consumption ending date in the same format YYYY-MM-DD(could be blank)");
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
    }
}
