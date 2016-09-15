using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objektorientering_övn_02
{
    class Course
    {
        public string CourseName { get; set; }
        public int Points { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public double calculateNumberOfDays()
        {
            var amountOfDays = EndDate - StartDate;
            TimeSpan totdays = EndDate.Subtract(StartDate);
            double totday = totdays.TotalDays;
            return totday;
        }
    }
}
