using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ObjectClassConstructorInheritanceThisvsBase.Models
{
    internal class Teacher : Person
    {
        public string Department;
        public string MainSubject;
        public decimal BaseSalary;
        public int ExperienceYears;

        public Teacher(string name, string surname, int age, string email, string id,
                       string department, string mainSubject, decimal baseSalary, int experienceYears)
            : base(name, surname, age, email, id)
        {
            this.Department = department;
            this.MainSubject = mainSubject;
            this.BaseSalary = baseSalary;
            this.ExperienceYears = experienceYears;
        }

        public void ShowTeacherInfo()
        {
            Console.WriteLine("----- Teacher Information-----");
            Console.WriteLine("Ad: " + FirstName);
            Console.WriteLine("Soyad: " + LastName);
            Console.WriteLine("Department: " + Department);
            Console.WriteLine("Main Subject: " + MainSubject);
            Console.WriteLine("Experience Years: " + ExperienceYears);
        }

        public decimal CalculateSalary()
        {
            return BaseSalary + (ExperienceYears * 50);
        }
    }
}
