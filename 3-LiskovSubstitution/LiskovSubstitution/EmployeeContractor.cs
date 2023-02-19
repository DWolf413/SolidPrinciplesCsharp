using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    public class EmployeeContractor : Employee
    {
        public EmployeeContractor(string fullname, int hoursWorked) : base (fullname, hoursWorked) 
        { 
        }

        public override decimal CalculateSalary()
        {
            decimal hourValue = 40;
            return hourValue * HoursWorked;
        }

    }
}
