using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical
{
    internal class Registration
    {
        private string firstname, lastname;
        private int age;

        //constructor
        public Registration(string firsname, string lastname, int age) 
        { 
            this.firstname = firsname;
            this.lastname = lastname;
            this.age = age;
        }

        //getters
        public string getFirstname()
        {
            return this.firstname;
        }

        public string getLastname()
        {
            return this.lastname;
        }

        public int getAge()
        {
            return this.age;
        }

        public virtual void displayInfo()
        {
            Console.WriteLine($"Name: {this.firstname} {this.lastname}");
            Console.WriteLine("Age: " + this.age);
        }

    }
}
