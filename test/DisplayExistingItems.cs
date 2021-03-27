using System.Collections.Generic;

namespace test
{
    public class DisplayExistingItems 
    {
       
        public static void Display(List<Books> BookList)
        {
           int index=1;   
           foreach(Books book in BookList)
            {
                System.Console.WriteLine("{0}){1}",index,book._name);
                index++;
            }
        }
        public static void Display(List<Series> SeriseList)
        {
            int index = 1;
            foreach (Series serise in SeriseList)
            {
                System.Console.WriteLine("{0}){1}", index, serise._name);
                index++;
            }
        }
        public static void Display(List<Movies> MovieList)
        {
            int index = 1;
            foreach (Movies movie in MovieList)
            {
                System.Console.WriteLine("{0}){1}", index, movie._name);
                index++;
            }
        }


    }
    
 
}
