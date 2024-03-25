using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical 
{
    internal class WorkExperience : Course
{
        private string workdesc;
        private int noofexperience;

        public WorkExperience(string firstname, string lastname, int age, string coursedesc, int yearlevel, string workdesc, int noofexperience) : base(firstname, lastname, age, coursedesc, yearlevel)
        {
            this.workdesc = workdesc;
            this.noofexperience = noofexperience; 
        }

        public string getWorkDesc()
        {
            return this.workdesc;
        }

        public int getNoofexperience()
        {
            return this.noofexperience;
        }

        public override void displayInfo()
        {
            base.displayInfo();
            Console.WriteLine("Work Description: " + this.workdesc);
            Console.WriteLine("No. of Experience: " + this.noofexperience);
        }
    }
}
