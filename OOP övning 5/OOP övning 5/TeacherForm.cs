using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_övning_5
{
    public partial class TeacherForm : Form
    {
        private Teacher teacher;
        public TeacherForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            teacher = new Teacher();
            MessageBox.Show(teacher.InChargeOfCourses().Aggregate((current1, current) => string.Format($"{current1}, {current}")));
        }
    }
}
