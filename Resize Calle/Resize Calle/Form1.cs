using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resize_Calle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Left = 80;
            textBox1.Top = 80;
        }


        private void formen_resize(object sender, EventArgs e)
        {
            textBox1.Height = this.Height - 200;
            textBox1.Width = this.Width - 200;

        }
    }
}
