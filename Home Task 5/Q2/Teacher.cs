using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Teacher
    {
        private int Teacher_ID;
        private string Teacher_Name;
        private string Subject;

        public Teacher (int ID, string Name,string Subject)
        {
            Teacher_ID = ID;
            Teacher_Name = Name;
            this.Subject = Subject;
        }
        public void AssignGrade(Student std,int Grade)
        {
            std.SetGrade(Grade);
        }
        public int getTeacher_ID() { return Teacher_ID; }
        public string getTeacher_Name() { return Teacher_Name; }
        public string getTeacher_Subject() { return Subject; }

    }
}
