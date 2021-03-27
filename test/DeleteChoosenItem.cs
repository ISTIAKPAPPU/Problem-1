using System;
using System.Collections.Generic;

namespace test
{
    public class DeleteChoosenItem
    {
        public static void delete(List<Books> BookList)
        {
            if (BookList.Count == 0)
            {
                Console.WriteLine("No item Left add First!!");
                Program.MainMenu();
            }
            DisplayExistingItems.Display(BookList);

            int index = ChooseIndex();
           
            BookList.RemoveAt(IndexValid(index, BookList.Count));
        }
        public static void delete(List<Series> SeriesList)
        {
            if (SeriesList.Count == 0)
            {
                Console.WriteLine("No item Left add First!!");
                Program.MainMenu();
            }

            DisplayExistingItems.Display(SeriesList);

            int index = ChooseIndex();

            SeriesList.RemoveAt(IndexValid(index, SeriesList.Count));
        }
        public static void delete(List<Movies> MovieList)
        {
            if (MovieList.Count == 0)
            {
                Console.WriteLine("No item Left add First!!");
                Program.MainMenu();
            }
            DisplayExistingItems.Display(MovieList);

            int index = ChooseIndex();

            MovieList.RemoveAt(IndexValid(index, MovieList.Count));
        }

        private static int IndexValid(int index,int size)
        {

             while(index<0 || index>=size)
            {
                Console.WriteLine("Invalid Selection! choose valid one");
                Console.WriteLine("Choose Item For Remove:");
                index = Convert.ToInt32(Console.ReadLine()) - 1;
                
            }
     
            return index;
        }
        private static int ChooseIndex()
        {
            Console.WriteLine("Choose Item For Remove:");
            return Convert.ToInt32(Console.ReadLine()) - 1;
        }
    }

}

