using System;
using System.Collections.Generic;

namespace test
{

    public class Movies :IConsumable
    {
        public string _name { get; set; }
        public DateTime _startingDate { get; set; }
        public DateTime _endingDate { get; set; }
        public float _rating { get; set; }
        public float _totalTime { get ; set ; }
        public int _totalDay { get ; set ; }

        public Movies(string name, DateTime startingDate, DateTime endingDate,float rating)   
        {
            this._name = name;
            this._startingDate = startingDate;
            this._endingDate = endingDate;
            this._rating = rating;
        }
    }
}
