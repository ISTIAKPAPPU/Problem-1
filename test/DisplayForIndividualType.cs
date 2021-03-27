using System;

namespace test
{
    public class DisplayForIndividualType
    {
        public static void chooseType()
        {

            Console.Clear();
            Console.WriteLine("Consumable Types:");
            Console.WriteLine("1) Books");
            Console.WriteLine("2) Series");
            Console.WriteLine("3) Movies");
            Console.WriteLine("4) Go to Mainmenu");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Books:");
                    DisplayIndividualItem.Display(Program.BookList);
                    Program.MainMenu();
                    break;
                case "2":
                    Console.WriteLine("Series:");
                    DisplayIndividualItem.Display(Program.SeriesList);
                    Program.MainMenu();
                    break;
                case "3":
                    Console.WriteLine("Movies:");
                    DisplayIndividualItem.Display(Program.MovieList);
                    Program.MainMenu();
                    break;
                case "4":
                    Console.WriteLine("main manue");
                    Program.MainMenu();
                    break;
                default:
                    break;

            }

            
        }  
    }
}
