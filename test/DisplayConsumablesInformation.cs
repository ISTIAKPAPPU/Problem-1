using System;

namespace test
{
    public class DisplayConsumablesInformation
    {
   
        public static void chooseType()
        {

            Console.Clear();
            Console.WriteLine("\nConsumable Types:");
            Console.WriteLine("1) Show Specific type Information");
            Console.WriteLine("2) Individually Pick Infomation ");
            Console.WriteLine("3) Go to Mainmenu");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Specific Type:");
                    DisplayForSpecificType.chooseType();
                    Program.MainMenu();
                    break;
                case "2":
                    Console.WriteLine("Individually:");
                    DisplayForIndividualType.chooseType();
                    Program.MainMenu();
                    break;
                case "3":
                    Console.WriteLine("Main manue");
                    Program.MainMenu();
                    break;
                default:
                    break;

            }
        }

    }
}
