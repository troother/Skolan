using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Filhatering
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox0.Text = "Tjenare!";
            SaveToFile();
        }

        public static void SaveToFile()
        {
            string[] lines = {"Tjenare", "vad heter", "du?"};

            File.WriteAllLines(@"c:\test.txt", lines);
        }
    }
}
