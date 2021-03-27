using System;
using System.Collections.Generic;

namespace test
{

    public class DisplayAllItems
    {
        public static void Display(List<Books> BookList)
        {
   
            foreach (Books book in BookList)
            {

                Console.WriteLine("Name= {0}   Days= {1}   Hours= {2}   Rating= {3}",book._name,book._totalDay,book._totalTime,book._rating);
               
            }
        }
        public static void Display(List<Series> SeriseList)
        {
     
            foreach (Series series in SeriseList)
            {
                Console.WriteLine("Name= {0}   Days= {1}   Hours= {2}   Rating= {3}", series._name, series._totalDay, series._totalTime, series._rating);

            }
        }
        public static void Display(List<Movies> MovieList)
        {

            foreach (Movies movie in MovieList)
            {
                Console.WriteLine("Name= {0}   Days= {1}   Hours= {2}   Rating= {3}", movie._name, movie._totalDay, movie._totalTime, movie._rating);

            }
        }

    }

   
}
