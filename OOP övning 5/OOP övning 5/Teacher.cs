using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_övning_5
{
    class Teacher
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public string[] InChargeOfCourses()
        {
            return GetCourses();
        }

        private string[] GetCourses()
        {
            string[] courses = {"Front-end programmering", "Webb introduktion", "Programmering C#"};

            return courses;
        }

    }
}
