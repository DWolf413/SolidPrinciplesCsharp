using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    public class EmployeeFullTime : Employee
    {
        public int ExtraHours { get; set; }
        public EmployeeFullTime(string fullname, int hoursWorked, int extraHours) : base(fullname, hoursWorked)
        {
            ExtraHours = extraHours;
        }

        public override decimal CalculateSalary()
        {
            decimal hourValue = 50;
            return hourValue * (HoursWorked + ExtraHours);
        }
}
}
