﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    public class EmployeeContractor : Employee
    {
        public EmployeeContractor(string fullname, int hoursWorked, int extraHours) : base (fullname, hoursWorked, extraHours) 
        { 
        }

    }
}
