using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_övning_5
{
    public partial class StudentInfo : Form
    {
        public StudentInfo(Student student)
        {
            InitializeComponent();
            label1.Text = student.FirstName;
            label2.Text = student.LastName;
            label3.Text = student.PersonalNumber;
            label4.Text = student.Phone;
            label5.Text = student.Email;
        }
    }
}
