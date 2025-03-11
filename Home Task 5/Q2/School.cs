using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class School
    {
        public string schoolname;
        public string location;
        public Student[] schools;
        private int count;

        public School(string name, string location)
        {
            schoolname = name;
            this.location = location;
            schools = new Student[10];
            count = 0;
        }



        public void addstudent(Student std1)
        {
            schools[count++] = std1;
            Console.WriteLine($"Student :  is addedd to school {schoolname} . ");

        }

        public void Displayinfo()
        {
            Console.WriteLine("\nSchool name = " + schoolname);
            Console.WriteLine("Location = " + location);
            Console.WriteLine("Vumber of students in school are : " + count);
            Console.WriteLine("\n");
        }
    }
}
