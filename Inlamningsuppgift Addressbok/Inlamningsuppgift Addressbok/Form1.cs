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

namespace Inlamningsuppgift_Addressbok
{
    public partial class Form1 : Form
    {
        Search Search = new Search();
        public Form1()
        {
            InitializeComponent();
        }

        private Contact CreateContact()
        {
            var contact = new Contact()
            {
                FirstName = txtFirstName.Text.ToLower(),
                LastName = txtLastName.Text.ToLower(),
                Address = txtAddress.Text.ToLower(),
                ZipCode = txtZipCode.Text.ToLower(),
                Phone = txtPhone.Text.ToLower(),
                Email = txtEmail.Text.ToLower(),
            };

            return contact;
        }
        private void SaveContactToFile(Contact contact)
        {
            var sb = new StringBuilder();
            sb.Append(contact.FirstName + ",");
            sb.Append(contact.LastName + ",");
            sb.Append(contact.Address + ",");
            sb.Append(contact.ZipCode + ",");
            sb.Append(contact.Phone + ",");
            sb.Append(contact.Email);

            try
            {
                using (var sw = new StreamWriter("Addressbook.txt", true))
                {
                    sw.WriteLine(sb.ToString());
                }
                lblMessage.ForeColor = Color.Green;
                lblMessage.Text = @"Contact has been saved";
            }
            catch (Exception)
                {
                lblMessage.ForeColor = Color.Red;
                lblMessage.Text = @"Something went wrong";
            }

            }
        private void btnSaveNew_Click(object sender, EventArgs e)
        {
            var contact = CreateContact();
            SaveContactToFile(contact);
            txtFirstName.Clear();
            txtLastName.Clear();
            txtAddress.Clear();
            txtZipCode.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            
        }

        private void btnSaveChange_Click(object sender, EventArgs e)
        {

        }

        private List<string> GetInfo()
        {
            List<string> Addressbook = new List<string>();
            string path = @"C:\Users\Troother\Documents\Visual Studio 2015\Projects\Github\Inlamningsuppgift Addressbok\Inlamningsuppgift Addressbok\bin\Debug\Addressbook.txt";
            StreamReader sr = new StreamReader(path);
            string line = "";
            while ((line = sr.ReadLine()) != null)
            {
                Addressbook.Add(line);
            }
            sr.Close();
            return Addressbook;
        }

        private void btnGetContacts_Click(object sender, EventArgs e)
        {
            listBoxContacts.Items.Clear();
            List<string> list = GetInfo();
            foreach (var line in list)
            {
                listBoxContacts.Items.Add(line);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            listBoxContacts.Items.Clear();
            lblMessageSearch.Text = "";
            Search.SearchContact(listBoxContacts,txtSearch.Text, lblMessageSearch);
        }
    }
}

