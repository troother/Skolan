using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCalle
{
    public partial class Form1 : Form
    {
        public int forsta = 1;
        public int andra = 1;

        private const string Username = "Calle";
        private const string Password = "carl";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (forsta == 1)
            {
                textBox1.Text = "";
                forsta = 0;
            }

        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (andra == 1)
            {
                textBox2.Text = "";
                andra = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == Username && textBox2.Text == Password)
                label1.Text = "Du är inloggad.";
            else
            {
                label1.Text = "Felaktigt användarnamn och eller lösenord.";
            }


            Form2 formen = new Form2(textBox1.Text);
            formen.Show();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
