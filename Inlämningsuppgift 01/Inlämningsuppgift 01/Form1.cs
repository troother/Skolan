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

namespace Inlämningsuppgift_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
            if (!Directory.Exists(@"C:\Users\Tobbe\Documents\Addressbook"));
            Directory.CreateDirectory(@"C:\Users\Tobbe\Documents\Addressbook");
            if (!File.Exists(@"C:\Users\Tobbe\Documents\Addressbook\settings.txt"));
            File.Create(@"C:\Users\Tobbe\Documents\Addressbook\settings.txt");
        }
    }

    class Person
    {
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string StreetAdress { get; set;}
        public string ZipCode {get; set;}
        public string City {get; set;}
        public string PhoneNumber {get; set;}
        public string Email {get; set; }
    }
}
