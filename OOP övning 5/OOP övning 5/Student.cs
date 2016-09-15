using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_övning_5
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PersonalNumber { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }


        public Student()
        {
            
        }
        public Student(string firstname, string lastname, string personalnumber, string phone, string email)
        {
            FirstName = firstname;
            LastName = lastname;
            PersonalNumber = personalnumber;
            Phone = phone;
            Email = email;
        }


        public string ValidateValues()
        {
            var props = this.GetType().GetProperties();
            string missing = "";

            foreach (var propertyInfo in props)
            {
                if (propertyInfo.GetValue(this, null).ToString() == "")
                    missing += propertyInfo.Name + " ";

                
            }

            return missing;
        }
        public string[,] GetGrades()
        {
            string[,] data = new string[3, 2];

            data[0, 0] = "Programmering C#";
            data[0, 1] = "G";
            data[1, 0] = "ASP.NET med C#";
            data[1, 1] = "VG";
            data[2, 0] = "Frontend utveckling";
            data[2, 1] = "VG";

            return data;
        }



    }

}
