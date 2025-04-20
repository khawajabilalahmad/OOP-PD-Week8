using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.BL
{
    class Person
    {
        protected string name;
        protected string address;

        public Person(string name, string address)
        {
            this.name = name;
            this.address = address;
        }

        public Person()
        { }

        public string getName()
        {
            return name;
        }

        public string getAddress()
        {
            return address;
        }

        public string toString()
        {
            return ("Person[ " + name + " , " + address + "]");
        }

        public void setAddress(string address)
        {
            this.address = address;
        }
    }
}
