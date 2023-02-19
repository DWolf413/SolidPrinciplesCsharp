using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    public class Employee
    {
        public string Fullname { get; set; }
        public int HoursWorked { get; set; }
        public int ExtraHours { get; set; }

        public Employee(string fullname, int hoursWorked, int extraHours)
        {
            Fullname = fullname;
            HoursWorked = hoursWorked;
            ExtraHours = extraHours;
        }

        public virtual decimal CalculateSalary(bool IsFullTime) 
        {
            decimal hourValue = IsFullTime ? 50 : 40;
            return hourValue * (HoursWorked + ExtraHours);
        }
    }
}
