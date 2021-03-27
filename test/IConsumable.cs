using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
    interface IConsumable
    {

  
        public string _name { get; set; }
        public DateTime _startingDate { get; set; }
        public DateTime _endingDate { get; set; }
        public float _rating { get; set; }
        public float _totalTime { get; set; }
        public int _totalDay { get; set; }
 
    }
}
