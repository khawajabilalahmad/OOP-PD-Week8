using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.BL
{
    class Staff : Person
    {
        private string school;
        private double pay;

        public Staff(string name, string address,string school, double pay) : base (name,address)
        {
            this.school = school;
            this.address = address;
        }

        public string getSchool()
        {
            return school;
        }

        public void setSchool()
        {
            this.school = school;
        }

        public double getPay()
        {
            return pay;
        }

        public void setPay()
        {
            this.pay = pay;
        }

        public new string toString()
        {
            string statement = base.toString();
            statement = "Staff" + statement + ", " + school + ", " + pay + "]";
            return statement;
        }

    }
}
