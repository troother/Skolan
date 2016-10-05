using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Xml.Schema;

namespace Inlamningsuppgift_Addressbok
{
    public partial class Form1 : Form
    {
        List<Contact> _contact = new List<Contact>();
        //Search Search = new Search();

        private string _currentId;

        public Form1()
        {
            InitializeComponent();

            Refresh();
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

            //try
            //{
            //    using (var sw = new StreamWriter("Addressbook.txt", true))
            //    {
            //        sw.WriteLine(sb.ToString());
            //    }
            //    lblMessage.ForeColor = Color.Green;
            //    lblMessage.Text = @"Contact has been saved";
            //}
            //catch (Exception)
            //    {
            //    lblMessage.ForeColor = Color.Red;
            //    lblMessage.Text = @"Something went wrong";
            //}

        }

        //public void DeleteLine(string id)
        //{
        //    var book = GetInfo();
        //    var contact = FindItemOnId(id, book);
        //    book.Remove(contact);
        //}

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
                Contact contact = new Contact() {FirstName = contactArray[0], LastName = contactArray[1], Address = contactArray[2], ZipCode = contactArray[3], Phone = contactArray[4], Email = contactArray[5], Id = contactArray[6]};
                Addressbook.Add(contact);
            }

            sr.Close();

            return Addressbook;
        }        

        private void listBoxContacts_SelectedIndexChanged(object sender, EventArgs e)

        {
            if (listBoxContacts.SelectedIndex != -1)
            {

                var listBox = (ListBox)sender;
                var contact = (Contact)listBox.SelectedItem;

                txtFirstName.Text = contact.FirstName;
                txtLastName.Text = contact.LastName;
                txtAddress.Text = contact.Address;
                txtZipCode.Text = contact.ZipCode;
                txtPhone.Text = contact.Phone;
                txtEmail.Text = contact.Email;
                _currentId = contact.Id;

            }

        }

        public new void Refresh()
        {
            List<Contact> list = GetInfo();

            listBoxContacts.DataSource = GetInfo();
            listBoxContacts.DisplayMember = "FirstName";
        }

        public new void ClearContactFields()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtAddress.Clear();
            txtZipCode.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
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

            Refresh();
        }

        public void RemoveLine(string FileName, int LineToRemove)
        {
            var arrLine = File.ReadAllLines(FileName).ToList();
            arrLine.RemoveAt(LineToRemove);

            File.WriteAllLines(FileName, arrLine);
        }

        private void btnSaveChange_Click(object sender, EventArgs e)
        {
            //get selected id from listbox
            var currentUser = _currentId;

            //open file into memory

            var lines = File.ReadAllLines(@"C:\Users\Troother\Documents\Visual Studio 2015\Projects\Github\Inlamningsuppgift Addressbok\Inlamningsuppgift Addressbok\bin\Debug\Addressbook.txt");
            var line = 0;

            //loop through all lines

            for (var i = 0; i < lines.Length; i++)
            {
                if (lines[i].Contains(_currentId))
                {
                    //find correct line
                    line = i;
                    break;
                }
            }
            
            //delete line

            RemoveLine(@"C:\Users\Troother\Documents\Visual Studio 2015\Projects\Github\Inlamningsuppgift Addressbok\Inlamningsuppgift Addressbok\bin\Debug\Addressbook.txt", line);

            ClearContactFields();
        }

        private void btnGetContacts_Click(object sender, EventArgs e)
        {
            Refresh();
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

            ClearContactFields();

            Refresh();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<Contact> searchResult = new List<Contact>();
            string searchText = txtSearch.Text.ToLower();

            foreach (var contact in GetInfo())
            {

                if (contact.FirstName.Contains(searchText))
                {
                    searchResult.Add(contact);
                }
                else if (contact.Address.Contains(searchText))
                {
                    searchResult.Add(contact);
                }

            }
            listBoxContacts.DataSource = searchResult;
            listBoxContacts.DisplayMember = "FirstName";

        }
    }
}