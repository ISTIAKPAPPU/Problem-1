using System;

namespace test
{
    public class DisplayForSpecificType
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
                    Console.WriteLine("List of Books:");
                    DisplayAllItems.Display(Program.BookList);
                    Program.MainMenu();
                    break;
                case "2":
                    Console.WriteLine("List of Series:");
                    DisplayAllItems.Display(Program.SeriesList);
                    Program.MainMenu();
                    break;
                case "3":
                    Console.WriteLine("List of Movies:");
                    DisplayAllItems.Display(Program.MovieList);
                    Program.MainMenu();
                    break;
                case "4":
                    Console.WriteLine("Main manue");
                    Program.MainMenu();
                    break;
                default:
                    break;

            }
        }

    }
}
