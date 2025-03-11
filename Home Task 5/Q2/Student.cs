using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Student
    {
        private int Student_ID;
        private string Name;
        private int[] grades;
        private int Grade;

        public Student (int ID, string Name)
        {
            this.Student_ID = ID;
            this.Name = Name;
            grades = new int[3];
            Grade = 0;
        }
        public void SetGrade(int grade)
        {
            grades[Grade] = grade;
            Grade++;
        }
        public double AvgGrade()
        {
            if (Grade ==0)return 0;
            double sum = 0;
            for(int i = 0; i < Grade; i++)
            {
                sum += grades[i];
            }
            return sum / Grade;
        }
        public int studentid()
        {
            return Student_ID;
        }
        public string name()
        {
            return Name;
        }
        public void display()
        {
            double average = AvgGrade();
            Console.WriteLine("\nStudent Names: " + Name);
            Console.WriteLine("ID : " + Student_ID );
            Console.WriteLine("Average Grade : " + average);
        }
    }
}
