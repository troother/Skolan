using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_form_övn_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string first = textBoxFirstName.Text;
            string last = textBoxLastName.Text;
            string ssn = textBoxSSN.Text;
            string email = textBoxEmail.Text;
            string phone = textBoxPhoneNumber.Text;
            string merital = comboBoxMaritalStatus.Text;

            StringBuilder checkEmpty = new StringBuilder();

            if (first != "" && last != "" && ssn != "" && email != "" && phone != "" && merital != "")
            {
                MessageBox.Show("OK!");                
            }
            if (first == "")
            {
                checkEmpty.Append("First ");
            }
            if (last == "")
            {
                checkEmpty.Append(" Last ");
            }
            if (ssn == "")
            {
                checkEmpty.Append(" SSN ");
            }
            if (email == "")
            {
                checkEmpty.Append(" Email ");
            }
            if (phone == "")
            {
                checkEmpty.Append(" Phone ");
            }
            if (merital == "")
            {
                checkEmpty.Append(" Merital");
            }
            if (checkEmpty.ToString() != "")
                MessageBox.Show(("Följande är inte ifyllda: ") + checkEmpty.ToString());


        }
    }
}
