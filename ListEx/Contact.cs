using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListEx
{
    class Contact
    {

        public string Fname { get; set; }
        public string Lname { get; set; }
        public int Age { get; set; }


        public Contact(string f, string l, int a)
        {
            //cant populate this class unless have these values provided because the constructor is set up to have 3
            Fname = f;
            Lname = l;
            Age = a;
        }

        //override the method 
        public override string ToString()
        {
            return Fname + " " + Lname + " " + Age;
        }
    }
}
