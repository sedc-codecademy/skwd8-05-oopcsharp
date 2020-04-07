using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Class07.Excersise.Entities
{
    public class Sales : Empoyee
    {
        public int SuccessSaleRevenue { get; set; }

        public Sales(string fName, string lName, double salary, int success)
            :base(fName, lName, salary)
        {
            SuccessSaleRevenue = success;
        }

        public double GetSalary()
        {
            if (SuccessSaleRevenue <= 2000)
            {
                return Salary + 500;
            }
            else if (SuccessSaleRevenue <= 5000)
            {
                return Salary + 800;
            }
            else if (SuccessSaleRevenue > 5000)
            {
                return Salary + 2000;
            }
            else
            {
                return Salary;
            }
        }
    }
}
