using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListEx
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            int age = int.Parse(txtAge.Text);


            Contact con = new Contact(firstName, lastName, age);
            //must pass values here, will show error as contact.cs demands it
            //con.Fname = firstName;
            //con.Lname = lastName;
            //con.Age = age;




        }

        private void btnShow_Click(object sender, EventArgs e)
        {
           

        }
    }
}
