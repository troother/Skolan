using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatumFormulär
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime test = DateTime.Parse(dateTimePicker1.Text);
            DateTime test2 = DateTime.Parse(dateTimePicker2.Text);

            textBox1.Text = (test2.Year - test.Year).ToString();
            textBox2.Text = (test2 - test).TotalDays.ToString();
            textBox3.Text = (test2 - test).TotalHours.ToString();
        }
    }
}
