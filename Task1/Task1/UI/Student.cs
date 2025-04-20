using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.UI
{
    class Student
    {
        public static BL.Student getStudentInfo()
        {
            Console.WriteLine("Enter Name of Student: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Program of Student: ");
            string program = Console.ReadLine();
            Console.WriteLine("Enter Year: ");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Fee of Student: ");
            double fee = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Address: ");
            string address = Console.ReadLine();

            BL.Student std = new BL.Student(name, address, program, year, fee);
            return std;
        }

        public static void SetStudentAttributes(string name, string address, string program, int year, double fee)
        {
            BL.Student bl = new BL.Student();
            bl.setAddress(address);
            bl.setProgram(program);
            bl.setYear(year);
            bl.setFee(fee);
        }

        public static void GetStudentAttributes()
        {
            BL.Student bl = new BL.Student();
            string name = bl.toString();
            Console.WriteLine(name);
            
        }

    }
}
