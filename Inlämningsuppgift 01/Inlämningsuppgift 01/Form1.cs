﻿using System;
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
        private void btnSaveNew_Click(object sender, EventArgs e)
        {

        }

        public void CreateContct()
        {
            var contact = new Contact();
            {
                contact.FirstName = txtFirstName.Text;


            };
        }
    }
}
