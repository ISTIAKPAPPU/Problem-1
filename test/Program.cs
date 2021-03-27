using System;
using System.Collections.Generic;

namespace test
{
    public class Program
    {
        public readonly static List<Books> BookList = new List<Books>();
        public readonly static List<Movies> MovieList = new List<Movies>();
        public readonly static List<Series> SeriesList = new List<Series>();
        public static float TotalConsumptionTime = 0;
        public static float ConsumptiontimeForBooks = 0;
        public static float ConsumptiontimeForMovies = 0;
        public static float ConsumptiontimeForSeries = 0;
        public static int TotalDaysOfConsumption = 0;
        public static int  ConsumptionDaysForBooks = 0;
        public static int  ConsumptionDaysForMovies = 0;
        public static int  ConsumptionDaysForSeries = 0;


        static void Main(string[] args)
        {
            MainMenu();
           
        }
        public static void MainMenu()
        {

            
            Console.WriteLine("\nMain Manue");
            Console.WriteLine("1) Add a consumable");
            Console.WriteLine("2) Edit a consumable");
            Console.WriteLine("3) Delete a consumable");
            Console.WriteLine("4) See the list of consumables and individually");
            Console.WriteLine("5) See overall info");
            Console.WriteLine("6) Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("\nADD CONSUMABLE:");
                    ChooseConsumableToAdd.chooseType();
                    break;
                case "2":
                    Console.WriteLine("\nEDITING CONSUMABLE:");
                    ChooseConsumableForEdit.chooseType();
                    break;
                case "3":
                    Console.WriteLine("\nDELETING CONSUMABLE:");
                    ChooseConsumableForDelete.chooseType();
                    break;
                case "4":
                    Console.WriteLine("\nSEE THE LIST OF CONSUMABLE AND INDIVIDUALLY PROCESSING:");
                    DisplayConsumablesInformation.chooseType();
                    break;
                case "5":
                    Console.WriteLine("\nSEE OVERALL INFO PROCESSING:");
                    OverAllInformation.Display();
                    Program.MainMenu();
                    break;
                default:
                    break;
            }
        }

    }
}
