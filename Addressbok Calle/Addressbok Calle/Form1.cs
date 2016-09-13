using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Addressbok_Calle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fel;
            if (CheckFields(out fel))
                MessageBox.Show("Alla värden är ifyllda ok");
            else
                MessageBox.Show(fel);
        }

        private bool CheckFields(out string fel)
        {
            StringBuilder varden = new StringBuilder();
            List<Control> kontroller = new List<Control>();
            int räknare = 0;
            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (this.Controls[i].Name != "button1")
                {
                    kontroller.Add(this.Controls[i]);
                }
            }

            foreach (var kontroll in kontroller)
            {
                if (kontroll.Text == "")
                {
                    varden.Append(kontroll.Name + ",");
                    räknare += 1;
                }
            }

            if (räknare != 0)
            {
                varden.Append(" Är inte ifyllda.");
                fel = varden.ToString();
                return false;
            }
            else
            {
                fel = null;
                return true;
            }
        }
    }
}
