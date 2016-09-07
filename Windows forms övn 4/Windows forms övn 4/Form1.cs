using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_forms_övn_4
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

        private void calculateButton_Click(object sender, EventArgs e)
        {
            DateTime start = DateTime.Parse(startDateTimePicker.Text);
            DateTime end = DateTime.Parse(endDateTimePicker.Text);

            daysBox.Text = (end - start).TotalDays.ToString();
            hoursBox.Text = (end - start).TotalHours.ToString();
            yearsBox.Text = (end.Year - start.Year).ToString();
        }
    }
}
