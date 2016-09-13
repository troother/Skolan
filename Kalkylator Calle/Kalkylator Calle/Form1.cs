using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkylator_Calle
{
    public partial class Form1 : Form
    {
        StringBuilder visa = new StringBuilder();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ett_Click(object sender, EventArgs e)
        {
            visa.Append("1");
            textBox1.Text = visa.ToString();
        }

        private void två_Click(object sender, EventArgs e)
        {
            visa.Append("2");
            textBox1.Text = visa.ToString();
        }

        private void plus_Click(object sender, EventArgs e)
        {
            visa.Append("+");
            textBox1.Text = visa.ToString();
        }

        private void summera_Click(object sender, EventArgs e)
        {
            StringBuilder siffra = new StringBuilder();
            int nästa = 0;
            bool plus = false;
            int temp = 0;
            foreach (var symbol in visa.ToString())
            {
                if (symbol != '+' || symbol != '-')
                {
                    if (plus)
                    {
                        temp = int.Parse(siffra.ToString()) + symbol;
                        plus = false;
                    }
                    else
                    {
                        siffra.Append(symbol.ToString());
                    }
                }
                else if (symbol == '+')
                {
                    plus = true;
                }
            }

            MessageBox.Show(visa.ToString());
            MessageBox.Show(siffra.ToString());
            MessageBox.Show(temp.ToString());
        }
    }
}
