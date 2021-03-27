using System;

namespace test
{
    public class ChooseConsumableForDelete
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
                    Console.WriteLine("Deleting Book");
                    DeleteChoosenItem.delete(Program.BookList);
                    Program.MainMenu();
                    break;
                case "2":
                    Console.WriteLine("Deleting Series");
                    DeleteChoosenItem.delete(Program.SeriesList);
                    Program.MainMenu();
                    break;
                case "3":
                    Console.WriteLine("Deleting Movie");
                    DeleteChoosenItem.delete(Program.MovieList);
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

    }

}

