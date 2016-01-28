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

        List<Contact> friends = new List<Contact>();
        //list object declaration


        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            
            //try catch to catch user inout of text
            int age = int.Parse(txtAge.Text);


            Contact con = new Contact(firstName, lastName, age);
            //must pass values here, will show error as contact.cs demands it

            //use the lines below if not using constructor in Contact.cs
            //Contact con = new Contact();
            //con.Fname = firstName;
            //con.Lname = lastName;
            //con.Age = age;

            //variables start with lowercase, properties start with Capital

            friends.Add(con); //must use the nicknames
            

            MessageBox.Show("Data added");

            //txtFirstName.Text = "";
            //txtLastName.Text = "";
            //txtAge.Text = "";
            txtFirstName.Clear();
            txtLastName.Clear();
            txtAge.Clear();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            //

            //lblDisplay.Text = "";
            foreach (Contact c in friends) //data type Contact, variable (any word) in collection friends
            {

                lblDisplay.Text += c.ToString() + "\n";
                //override the toString method to display the int age
                //overriding - changing the functionality of a method
            }

        }
    }
}
