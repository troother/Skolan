using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Objektorientering_övn_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Course showbox = new Course();
            showbox.CourseName = textBox1.Text;
            showbox.Points = Int32.Parse(textBox2.Text);

            MessageBox.Show(showbox.CourseName + ", " + showbox.Points);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Course days = new Course();
            days.EndDate = dateTimePicker1.Value;
            days.StartDate = dateTimePicker2.Value;
            double result = days.calculateNumberOfDays();

            MessageBox.Show(result.ToString());


        }
    }
}
