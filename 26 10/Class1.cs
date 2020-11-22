using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_10
{
    class Employee
    {
        public string Surname { get; set; }
        public double Salary { get; set; }
        public string Position { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string SurnameCity => Surname + " " + City;
        public override string ToString()
        {
            return Surname + " " + City + " " + Street;
        }
    }
}
