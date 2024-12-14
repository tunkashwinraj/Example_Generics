using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    static class EmployeeExtension
    {
        public static double ComputeOvertimePay(this Employee employee,
       double overtimeRate)
        {
            if (employee.HoursWorked > 40)
            {
                double extraHours = employee.HoursWorked - 40;
                double overtimePay = extraHours * employee.PayRate * overtimeRate;
                return overtimePay;
            }
            else
                return 0;
        }
    }
}
