using System;

namespace test
{
    public class ChooseConsumableForEdit
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
                    Console.WriteLine("\nList of Books");
                    //DisplayItems.display(Program.BookList);
                    EditChoosenItem.editBooks(Program.BookList);
                    Program.MainMenu();
                    break;
                case "2":
                    Console.WriteLine("\nList of Series");
                    //DisplayItems.display(Program.SeriseList);
                    EditChoosenItem.editSerise(Program.SeriesList);
                    Program.MainMenu();
                    break;
                case "3":
                    Console.WriteLine("\nList of Movies");
                    //DisplayItems.display(Program.MovieList);
                    EditChoosenItem.editMovies(Program.MovieList);
                    Program.MainMenu();
                    break;
                case "4":
                    Console.WriteLine("\nMain Manue");
                    Program.MainMenu();
                    break;
                default:
                    break;

            }
        }

    }
    
}
