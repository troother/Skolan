using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Inlamningsuppgift_Addressbok
{
    public partial class Form1 : Form
    {
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

            try
            {
                using (var sw = new StreamWriter("Addressbook.txt", true))
                {
                    sw.WriteLine(sb.ToString());
                }
            }

            catch (Exception)
            {
                lblMessage.ForeColor = Color.Red;

                lblMessage.Text = @"Something went wrong";
            }
        }

        private List<Contact> GetInfo()
        {
            List<Contact> addressbook = new List<Contact>();

            string path = @"C:\Users\Troother\Documents\Visual Studio 2015\Projects\Github\Inlamningsuppgift Addressbok\Inlamningsuppgift Addressbok\bin\Debug\Addressbook.txt";

            StreamReader sr = new StreamReader(path);

            string line;

            while ((line = sr.ReadLine()) != null)
            {
                var contactArray = line.Split(',');

                Contact contact = new Contact() { FirstName = contactArray[0], LastName = contactArray[1], Address = contactArray[2], ZipCode = contactArray[3], Phone = contactArray[4], Email = contactArray[5], Id = contactArray[6] };

                addressbook.Add(contact);
            }

            sr.Close();

            return addressbook;
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
            listBoxContacts.DataSource = GetInfo();

            listBoxContacts.DisplayMember = "FirstName";
        }

        public void ClearContactFields()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtAddress.Clear();
            txtZipCode.Clear();
            txtPhone.Clear();
            txtEmail.Clear();

        }

        public bool CheckTextBoxes()
        {
            if (txtFirstName.Text.Contains(',') || txtLastName.Text.Contains(',') || txtAddress.Text.Contains(',') || txtZipCode.Text.Contains(',') || txtPhone.Text.Contains(',') || txtEmail.Text.Contains(','))
            {
                MessageBox.Show("You cannot use ',' in any column");

                return false;
            }

            return true;
        }

        public void RemoveLine(string fileName, int lineToRemove)
        {
            var arrLine = File.ReadAllLines(fileName).ToList();

            arrLine.RemoveAt(lineToRemove);

            File.WriteAllLines(fileName, arrLine);
        }

        private void btnSaveNew_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxes())
            {
                var contact = CreateContact();

                SaveContactToFile(contact);

                ClearContactFields();

                Refresh();
            }
        }

        private void btnSaveChange_Click(object sender, EventArgs e)
        {
            if(CheckTextBoxes())
            if (_currentId != null)
            {

                var lines = File.ReadAllLines(@"C:\Users\Troother\Documents\Visual Studio 2015\Projects\Github\Inlamningsuppgift Addressbok\Inlamningsuppgift Addressbok\bin\Debug\Addressbook.txt");
                var line = 0;

                for (var i = 0; i < lines.Length; i++)
                {
                    if (lines[i].Contains(_currentId))
                    {
                        line = i;
                        break;
                    }
                }

                RemoveLine(@"C:\Users\Troother\Documents\Visual Studio 2015\Projects\Github\Inlamningsuppgift Addressbok\Inlamningsuppgift Addressbok\bin\Debug\Addressbook.txt", line);

                var contact = new Contact()
                {
                    FirstName = txtFirstName.Text.ToLower(),
                    LastName = txtLastName.Text.ToLower(),
                    Address = txtAddress.Text.ToLower(),
                    ZipCode = txtZipCode.Text.ToLower(),
                    Phone = txtPhone.Text.ToLower(),
                    Email = txtEmail.Text.ToLower(),
                    Id = _currentId
                };

                SaveContactToFile(contact);
                GetInfo().Add(contact);
            }
            ClearContactFields();

            Refresh();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (_currentId != null)
            {
                var lines =
                    File.ReadAllLines(@"C:\Users\Troother\Documents\Visual Studio 2015\Projects\Github\Inlamningsuppgift Addressbok\Inlamningsuppgift Addressbok\bin\Debug\Addressbook.txt");
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
                _currentId = null;

                File.WriteAllLines(@"C:\Users\Troother\Documents\Visual Studio 2015\Projects\Github\Inlamningsuppgift Addressbok\Inlamningsuppgift Addressbok\bin\Debug\Addressbook.txt", arrLine);

            }
            else


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

            ClearContactFields();

            listBoxContacts.DataSource = searchResult;

            listBoxContacts.DisplayMember = "FirstName";

        }
    }
}