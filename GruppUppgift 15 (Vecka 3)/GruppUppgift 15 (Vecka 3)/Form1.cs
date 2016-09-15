using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GruppUppgift_15__Vecka_3_
{
    public partial class Form1 : Form
    {
        private List<Bokning> Bookings;
         
        public Form1()
        {
            InitializeComponent();
            Bookings = new List<Bokning>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void SaveBooking(Course bantyp, DateTime day, DateTime start, DateTime end)
        {
            Kund customer = GetCustomer();
            Bana bana = new Bana();
            bana.TypeOfCourse = bantyp;

            Bokning booking = new Bokning();

            booking.Course = bana;
            booking.Customer = customer;
            booking.Date = day;
            booking.StartTime = start;
            booking.EndTime = end;

            Bookings.Add(booking);

        }

        private Kund GetCustomer()
        {
            Kund customer = new Kund();

            customer.Address = txtAddress.Text;
            customer.Email = txtEmail.Text;
            customer.FirstName = txtFirstname.Text;
            customer.LastName = txtLastname.Text;
            customer.Zipcode = txtZip.Text;
            customer.Phone = txtPhone.Text;

            return customer;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string test1 = comboStart.Text;
            test1 = test1.Replace(":00", "");
            string test2 = comboEnd.Text;
            test2 = test2.Replace(":00", "");

            var start = new DateTime(2000,10,5,Int32.Parse(test1),00,0);
            var end = new DateTime(2000, 10, 5, Int32.Parse(test2),00, 0);
            var day = Convert.ToDateTime(calendarSport.SelectionRange.Start.ToString());


            SaveBooking(Convert.ToInt32(comboSport.SelectedIndex),day,start,end);



        }
    }
}
