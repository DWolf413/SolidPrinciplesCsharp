using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    public abstract class Employee
    {
        public string Fullname { get; set; }
        public int HoursWorked { get; set; }


        public Employee(string fullname, int hoursWorked)
        {
            Fullname = fullname;
            HoursWorked = hoursWorked;
            
        }

        public abstract decimal CalculateSalary(); 

    }
}
