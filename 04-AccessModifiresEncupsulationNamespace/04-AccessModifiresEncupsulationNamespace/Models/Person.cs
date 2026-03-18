using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_AccessModifiresEncupsulationNamespace.Models
{
    public class Person
    {
        //public string name;
        //protected  string name;
        //internal string name;
        //private string name;
        //protected internal  string name;


        private string name;
        public string surname;

        public Person()
        {

            
        }

        public void GetInfo()
        {
            Console.WriteLine(this.name);
        }

    }
}
