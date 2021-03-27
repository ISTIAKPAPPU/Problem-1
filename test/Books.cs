using System;
using System.Collections.Generic;

namespace test
{
    public class Books:IConsumable 
    {
        public string _name { get ; set ; }
        public DateTime _startingDate { get ; set ; }
        public DateTime _endingDate { get; set; }
        public float _rating { get ; set ; }
        public float _totalTime
        {
            get; set;
        }
        public int _totalDay
        {
            get; set;
        }
        /*private int totalTime;
        public int _totalTime {
            get { return totalTime; }
            set { totalTime = 0; }
        }
        private int totalDay;
        public int _totalDay {
            get { return totalDay; }
            set { totalDay = 0; }
        }*/


        public Books(string name, DateTime startingDate, DateTime endingDate, float rating)
        {
            this._name = name;
            this._startingDate = startingDate;
            this._endingDate = endingDate;
            this._rating = rating;

        }
        public static void check(List<Books>booklist)
        {
            foreach(Books i in booklist)
            {
                Console.WriteLine("name"+i._name);
                Console.WriteLine("sDate"+i._startingDate);
                Console.WriteLine("Edate"+i._endingDate);
                Console.WriteLine("Day"+i._totalDay);
                Console.WriteLine("Time"+i._totalTime);
                Console.WriteLine("rating"+i._rating);
               
            }
        }
   
    }
}
