using _03_ObjectClassConstructorInheritanceThisvsBase.Models;

namespace _03_ObjectClassConstructorInheritanceThisvsBase
{

    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Ali", "Aliyev", 20, "ali@mail.com", "P1", "ST1", "IT", 88.5, 2);
            Student s2 = new Student("Veli", "Memmedov", 21, "veli@mail.com", "P2", "ST2", "IT", 92.0, 3);
            Student s3 = new Student("Aysel", "Quliyeva", 19, "aysel@mail.com", "P3", "ST3", "Design", 68.5, 1);

            Teacher t1 = new Teacher("Rashad", "Huseynov", 40, "rashad@mail.com", "T1",
                                     "Computer Science", "Programming", 800, 15);

            Teacher t2 = new Teacher("Leyla", "Kerimova", 35, "leyla@mail.com", "T2",
                                     "Mathematics", "Algebra", 800, 8);

            Administrator admin = new Administrator("Nigar", "Aliyeva", 45, "nigar@mail.com",
                                                    "A1", "Dekan", "IT", 5);

            s1.ShowStudentInfo();
            Console.WriteLine("Teqaud: " + s1.CalculateScholarship());

            s2.ShowStudentInfo();
            Console.WriteLine("Teqaud: " + s2.CalculateScholarship());

            s3.ShowStudentInfo();
            Console.WriteLine("Teqaud: " + s3.CalculateScholarship());

            t1.ShowTeacherInfo();
            Console.WriteLine("Maas: " + t1.CalculateSalary());

            t2.ShowTeacherInfo();
            Console.WriteLine("Maas: " + t2.CalculateSalary());

            admin.ShowAdminInfo();

            admin.GrantAccess(s1);

            double totalScholarship =
                s1.CalculateScholarship() +
                s2.CalculateScholarship() +
                s3.CalculateScholarship();

            decimal totalSalary =
                t1.CalculateSalary() +
                t2.CalculateSalary();

            Console.WriteLine("Umumi teqaud xerci: " + totalScholarship);
            Console.WriteLine("Umumi maas xerci: " + totalSalary);
        }
    }

}
