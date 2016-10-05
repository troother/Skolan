//using System;
//using System.Collections.Generic;
//using System.Drawing;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace Inlamningsuppgift_Addressbok
//{
//    internal class Search
//    {
//        public void SearchContact(ListBox myListBox, string searchWord, Label messageSearch)
//        {
//            if (string.IsNullOrWhiteSpace(searchWord))
//            {
//                messageSearch.Text = @"No search word";
//            }
//            else
//            {
//                if (File.Exists(@"C:\Users\Troother\Documents\Visual Studio 2015\Projects\Github\Inlamningsuppgift Addressbok\Inlamningsuppgift Addressbok\bin\Debug\Addressbook.txt"))
//                {
//                    var lines = File.ReadAllLines(@"C:\Users\Troother\Documents\Visual Studio 2015\Projects\Github\Inlamningsuppgift Addressbok\Inlamningsuppgift Addressbok\bin\Debug\Addressbook.txt");

//                    foreach (var row in lines)
//                    {
//                        if (row.Contains(searchWord.ToLower()))
//                        {
//                            string[] information = row.Split(',');
//                            myListBox.Items.Add(information[0]);
//                        }
//                    }
//                }
//                else
//                {
//                    messageSearch.Text = @"No contact exists";
//                }
//            }
//        }
//    }
//}