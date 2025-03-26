using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class Student : Person
    {
        public string Major;
        public int GraduationYear;

        public Student(string name, string email, string id, string major, int graduationYear)
            : base(name, email, id)
        {
            Major = major;
            GraduationYear = graduationYear;
            GraduationYear = graduationYear;
        }
            public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Major: {Major}, Graduation Year: {GraduationYear}");
        }
    }
    
}