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
using System.Xml.Schema;

namespace Inlamningsuppgift_Addressbok
{
    public partial class Form1 : Form
    {
        List<Contact> _contact = new List<Contact>();

        Search Search = new Search();
        private string _currentId;

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
                Id = Guid.NewGuid().ToString(),
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
            sb.Append(contact.Email + ",");
            sb.Append(contact.Id);

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

            //    var fillOut = listBoxContacts.SelectedItem.ToString().Split(',');

            //    var test = GetInfo();

            //    var objekt = test.Find(x => x._currentId).


        }

        public void DeleteLine(string id)
        {
            var book = GetInfo();
            var contact = FindItemOnId(id, book);
            book.Remove(contact);
            
        }



        private Contact FindItemOnId(string id, List<Contact> contacts)
        {
            foreach (var contact in contacts)
            {
                if (contact.Id == id)
                {
                    return contact;
                }
            }
            return null;
        }


        private List<Contact> GetInfo()
        {
            List<Contact> Addressbook = new List<Contact>();
            string path = @"C:\Users\Troother\Documents\Visual Studio 2015\Projects\Github\Inlamningsuppgift Addressbok\Inlamningsuppgift Addressbok\bin\Debug\Addressbook.txt";
            StreamReader sr = new StreamReader(path);
            string line = "";
            while ((line = sr.ReadLine()) != null)
            {
                var contactArray = line.Split(',');
                Contact contact = new Contact() {FirstName = contactArray[0], LastName = Name = contactArray[1], Address = contactArray[2], ZipCode = contactArray[3], Phone = contactArray[4], Email = contactArray[5], Id = contactArray[6]};
                Addressbook.Add(contact);
            }
            sr.Close();
            return Addressbook;
        }
        //private List<string> GetInfo()
        //{

        //    List<string> Addressbook = new List<string>();
        //    string path = @"C:\Users\Troother\Documents\Visual Studio 2015\Projects\Github\Inlamningsuppgift Addressbok\Inlamningsuppgift Addressbok\bin\Debug\Addressbook.txt";
        //    StreamReader sr = new StreamReader(path);
        //    string line = "";
        //    while ((line = sr.ReadLine()) != null)
        //    {
        //        Addressbook.Add(line);
        //    }
        //    sr.Close();
        //    return Addressbook;
        //}

        private void btnGetContacts_Click(object sender, EventArgs e)
        {
            listBoxContacts.Items.Clear();
            List<Contact> list = GetInfo();
            foreach (var line in list)
            {
                ListViewItem item = new ListViewItem(line.FirstName);
                listBoxContacts.Items.Add(item);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            listBoxContacts.Items.Clear();
            lblMessageSearch.Text = "";
            Search.SearchContact(listBoxContacts,txtSearch.Text, lblMessageSearch);
        }

        private void listBoxContacts_SelectedIndexChanged(object sender, EventArgs e, ListBox myListBox)
        {

            var fillOut = listBoxContacts.SelectedItem.ToString().Split(',');

            txtFirstName.Text = fillOut[0];
            txtLastName.Text = fillOut[1];
            txtAddress.Text = fillOut[2];
            txtZipCode.Text = fillOut[3];
            txtPhone.Text = fillOut[4];
            txtEmail.Text = fillOut[5];
            _currentId = fillOut[6];
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

            var lines = File.ReadAllLines(@"C:\Users\Troother\Documents\Visual Studio 2015\Projects\Github\Inlamningsuppgift Addressbok\Inlamningsuppgift Addressbok\bin\Debug\Addressbook.txt");
            var line = 0;
            for (var i = 0; i < lines.Length; i++)
            {
                if (lines[i].Contains(_currentId))
                {
                    line = i;
                }
            }

            var arrLine = File.ReadAllLines(@"C:\Users\Troother\Documents\Visual Studio 2015\Projects\Github\Inlamningsuppgift Addressbok\Inlamningsuppgift Addressbok\bin\Debug\Addressbook.txt").ToList();
            arrLine.RemoveAt(line);

            File.WriteAllLines(@"C:\Users\Troother\Documents\Visual Studio 2015\Projects\Github\Inlamningsuppgift Addressbok\Inlamningsuppgift Addressbok\bin\Debug\Addressbook.txt", arrLine);
            txtFirstName.Clear();
            txtLastName.Clear();
            txtAddress.Clear();
            txtZipCode.Clear();
            txtPhone.Clear();
            txtEmail.Clear();

        }
    }
}