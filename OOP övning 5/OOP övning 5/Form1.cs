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
    public partial class Form1 : Form
    {
        private Student student;

        public Form1()
        {
            InitializeComponent();
            TeacherForm teacherForm = new TeacherForm();
            teacherForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            student = new Student(txtFirstName.Text, txtLastName.Text, txtPersonalNumber.Text, txtPhone.Text, txtEmail.Text);

            string missing = student.ValidateValues();

            if (missing != "")
            {
                MessageBox.Show(missing + ", Är inte ifyllda");
            }
            else
            {
                MessageBox.Show(
                    $"Du har matat in följande uppgifter:\nFörnamn: {student.FirstName}\nEfternamn: {student.LastName}\n" +
                    $"Personnummer: {student.PersonalNumber}\nTelefon: {student.Phone}\nEmail: {student.Email}\nStämmer det?");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var grades = student.GetGrades();

            for (int i = 0; i < 3; i++)
            {
                listBox1.Items.Add(grades[i,0] + ", " + grades[i, 1]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (this.Controls[i].GetType().ToString().ToLower().Contains("textbox"))
                    this.Controls[i].Text = "";
            }
        }
    }
}
