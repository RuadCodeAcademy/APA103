using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ObjectClassConstructorInheritanceThisvsBase.Models
{
    internal class Student : Person
    {
        public string StudentNumber;
        public string Faculty;
        public double GPA;
        public int Year;

        public Student(string name, string surname, int age, string email, string id,
                       string studentNumber, string faculty, double gpa, int year)
            : base(name, surname, age, email, id)
        {
            this.StudentNumber = studentNumber;
            this.Faculty = faculty;
            this.GPA = gpa;
            this.Year = year;
        }

        public void ShowStudentInfo()
        {
            Console.WriteLine("----- Student Information-----");
            Console.WriteLine("Ad: " + FirstName);
            Console.WriteLine("Soyad: " + LastName);
            Console.WriteLine("Yas: " + Age);
            Console.WriteLine("Email: " + Email);
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Student Number: " + StudentNumber);
            Console.WriteLine("Faculty: " + Faculty);
            Console.WriteLine("Year: " + Year);
            Console.WriteLine("GPA: " + GPA);
        }

        public double CalculateScholarship()
        {
            if (GPA >= 90)
                return 500;
            else if (GPA >= 80)
                return 350;
            else if (GPA >= 70)
                return 200;
            else
                return 0;
        }
    }
}

