using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            BL.Student std = UI.Student.getStudentInfo();
            UI.Student.SetStudentAttributes(std.getName(), std.getAddress(),std.getProgram() ,std.getYear(), std.getFee() );
            UI.Student.GetStudentAttributes();
            
        }
    }
}