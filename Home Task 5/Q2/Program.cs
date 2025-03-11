using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student std1 = new Student(101, "Fahad");
            Student std2 = new Student(102, "Zeshan");
            Student std3 = new Student(103, "Abdullah");

            School s1 = new School("New Queens", "NYC");
            s1.addstudent(std1);
            s1.addstudent(std2);
            s1.addstudent(std3);
            s1.Displayinfo();


            Teacher t1 = new Teacher(10001, "Naeem", "Maths");
            Teacher t2 = new Teacher(10002, "Naseer", "Statistics");
            Teacher t3 = new Teacher(10003, "Qadeer", "OOp");

            t1.AssignGrade(std1, 65);
            t1.AssignGrade(std2, 15);
            t1.AssignGrade(std3, 51);

            t2.AssignGrade(std1, 67);
            t2.AssignGrade(std2, 23);
            t2.AssignGrade(std3, 90);

            t3.AssignGrade(std1, 64);
            t3.AssignGrade(std2, 46);
            t3.AssignGrade(std3, 55);

            std1.display();
            std2.display();
            std3.display();
        }
    }
}
