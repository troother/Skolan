using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gruppövning_12_Vecka_3
{
    public partial class Form1 : Form
    {
        private Kund kund;

        public Form1()
        {
            InitializeComponent();

            SkapaAnvändare();

            this.Text = $"BOKUS - Inloggad som {kund.Användarnamn}";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SkapaAnvändare()
        {
            kund = new Kund();
            kund.Förnamn = "Thorsten";
            kund.Efternamn = "Flink";
            kund.Gatuaddress = "Soptippen 13";
            kund.Epost = "Thorsten.Flink@dramaten.se";
            kund.Nyhetsbrev = false;
            kund.Personnummer = "19600307-0348";
            kund.Postnummer = 11414;
            kund.Postort = "Ankeborg";
            kund.Användarnamn = "Torsken";
            kund.Lösenord = "112";
        }
    }
}
