using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ObjectClassConstructorInheritanceThisvsBase.Models
{
    internal class Administrator : Person
    {
        public string Position;
        public string Department;
        public int AccessLevel;

        public Administrator(string name, string surname, int age, string email, string id,
                             string position, string department, int accessLevel)
            : base(name, surname, age, email, id)
        {
            this.Position = position;
            this.Department = department;
            this.AccessLevel = accessLevel;
        }

        public void ShowAdminInfo()
        {
            Console.WriteLine("----- Administrator Infomation -----");
            Console.WriteLine("Ad: " + FirstName);
            Console.WriteLine("Soyad: " + LastName);
            Console.WriteLine("Position: " + Position);
            Console.WriteLine("Department: " + Department);
            Console.WriteLine("Access Level: " + AccessLevel);
        }

        public void GrantAccess(Student student)
        {
            Console.WriteLine(student.FirstName + " adli telebeye sistem girisi verildi.");
        }
    }
}
