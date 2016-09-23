﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inlamningsuppgift_Addressbok
{
    class Search
    {
        public void SearchContact(ListBox myListBox, string searchWord)
        {
            if (string.IsNullOrWhiteSpace(searchWord))
            {
                return;
            }
            if (File.Exists(@"C:\Users\Troother\Documents\Visual Studio 2015\Projects\Github\Inlamningsuppgift Addressbok\Inlamningsuppgift Addressbok\bin\Debug\Addressbook.txt"))
            {
                var lines = File.ReadAllLines(@"C:\Users\Troother\Documents\Visual Studio 2015\Projects\Github\Inlamningsuppgift Addressbok\Inlamningsuppgift Addressbok\bin\Debug\Addressbook.txt");

                foreach (var row in lines)
                {
                    if (row.Contains(searchWord.ToLower()))
                    {
                        string[] information = row.Split(',');
                        myListBox.Items.Add(information[0] + "," + information[1]);
                    }
                }
            }
        }
    }
}