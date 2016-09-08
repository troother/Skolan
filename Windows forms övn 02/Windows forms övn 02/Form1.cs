using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_forms_övn_02
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void userBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string userinfo = userBox.Text + ", " + passBox.Text;

            Form2 formen = new Form2(userBox.Text);

            if (userinfo != "torbjörn, tobbe")
            {
                MessageBox.Show("Wrong user/password");
                return;
            }
            if (userinfo == ("torbjörn, tobbe"));
            {             
                MessageBox.Show("Welcome" + " " + userBox.Text);
                this.Hide();
                formen.Show();
            }
        }
    }
}
