using System;
using System.Collections.Generic;

namespace test
{
    public class DisplayIndividualItem
    {
        public static void Display(List<Books> BookList)
        {
            DisplayExistingItems.Display(BookList);

            int index = ChooseIndex();
            isIndexValid(index, BookList.Count);
            var book = BookList[index];

            Console.WriteLine("Name= {0}   Days= {1}   Hours= {2}   Rating= {3}", book._name, book._totalDay, book._totalTime, book._rating);

        }
        public static void Display(List<Series> SeriesList)
        {
            DisplayExistingItems.Display(SeriesList);

            int index = ChooseIndex();
            isIndexValid(index, SeriesList.Count);
            var series = SeriesList[index];

            Console.WriteLine("Name= {0}   Days= {1}   Hours= {2}   Rating= {3}", series._name, series._totalDay, series._totalTime, series._rating);


        }
        public static void Display(List<Movies> MovieList)
        {
            DisplayExistingItems.Display(MovieList);

            int index = ChooseIndex();
            isIndexValid(index, MovieList.Count);
            var movie = MovieList[index];

            Console.WriteLine("Name= {0}   Days= {1}   Hours= {2}   Rating= {3}", movie._name, movie._totalDay, movie._totalTime, movie._rating);

        }

        private static void isIndexValid(int index, int size)
        {
            if (index < 0 && index >= size)
            {
                Console.WriteLine("Invalid Selection");
                ChooseConsumableForDelete.chooseType();
            }
        }
        private static int ChooseIndex()
        {
            Console.WriteLine("Choose Item For Information:");
            return Convert.ToInt32(Console.ReadLine()) - 1;
        }
    }

}

