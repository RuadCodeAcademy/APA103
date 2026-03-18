using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_AccessModifiresEncupsulationNamespace.Models
{
    internal class Car
    {
        public string _model;
        private int _HorsePower;

        public int HorsePower
        {
            get
            {
                if(_HorsePower < 100)
                {
                    Console.WriteLine("can't drive");
                }
                else
                {
                    Console.WriteLine("can drive");
                }


          


                return _HorsePower;

            }
            set
            {
                if (value < 100)
                {
                    Console.WriteLine("Please enter value pawer");
                    
                }

                _HorsePower = value;



            }
        }
    }
}
