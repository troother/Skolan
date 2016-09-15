using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_övning_2_Calle
{
    public partial class Form1 : Form
    {
        private Kurs kursInfo;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double dagar = kursInfo.BeräknaAntalKursDagar();
            MessageBox.Show(dagar.ToString());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            kursInfo = new Kurs();
            kursInfo.Namn = textBox1.Text;
            kursInfo.Poäng = int.Parse(textBox2.Text);
            kursInfo.StartDatum = DateTime.Parse(dateTimePicker1.Text);
            kursInfo.SlutDatum = DateTime.Parse(dateTimePicker2.Text);

            MessageBox.Show($"Kursnamn: {kursInfo.Namn}\nPoäng: {kursInfo.Poäng}\nStartdatum: {kursInfo.StartDatum}\nSlutdatum: {kursInfo.SlutDatum}");



        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(kursInfo.PoängPerKursdag().ToString());

        }
    }
}
