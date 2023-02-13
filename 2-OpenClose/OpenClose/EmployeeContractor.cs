using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClose
{
    public class EmployeeContractor : Employee
    {
        public EmployeeContractor(string fullname, int hoursWorked)
        {
            Fullname = fullname;
            HoursWorked = hoursWorked;
        }

        public override decimal CalcaulateSalaryMonthly()
        {
            decimal hourValue = 20000M;
            decimal salary = hourValue * HoursWorked;
            return salary;

        }
    }
}
