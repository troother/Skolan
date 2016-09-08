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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string username) : this()
        {
            correct(username);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public void correct(string username)
        {
            label1.Text = $"Välkommen {username}, du är nu inloggad,";
        }
    }
}
