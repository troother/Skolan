using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_forms_övn_01
{
    public partial class frmVisaTextMeddelande : Form
    {
        public int räknare = 1;
        public frmVisaTextMeddelande()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmdVisaMeddelande_Click(object sender, EventArgs e)
        {
            string together = txtTextruta1.Text + ", " + txtTextruta2.Text;
            MessageBox.Show(together);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtTextruta1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTextruta1_Click(object sender, EventArgs e)
        {
            if (räknare == 1)
            {
                txtTextruta1.Text = ("");
                räknare = 0;

            }
        }
    }
}
