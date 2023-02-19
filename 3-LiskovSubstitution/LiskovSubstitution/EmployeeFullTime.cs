using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    public class EmployeeFullTime : Employee
    {
        public EmployeeFullTime(string fullname, int hoursWorked, int extraHours) : base(fullname, hoursWorked, extraHours)
        {
        }
    }
}
