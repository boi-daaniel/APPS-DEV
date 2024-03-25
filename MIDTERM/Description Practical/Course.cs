using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical
{
    internal class Course : Registration
    {
        private string coursedesc;
        private int yearlevel;

        public Course(string firstname,string lastname, int age, string coursedesc, int yearlevel) : base(firstname, lastname, age)
        {
            this.coursedesc = coursedesc;
            this.yearlevel = yearlevel;
        }

        public string getCoursedesc()
        {
            return this.coursedesc;
        }
        
        public int getYearlevel()
        {
            return this.yearlevel;
        }

        public override void displayInfo()
        {
            base.displayInfo();
            Console.WriteLine("Course: " + this.coursedesc);
            Console.WriteLine("Year Level: " + this.yearlevel);
        }
    }
}
