using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Employee
    {
        public string FisrtName { get; set; }
        public string LastName { get; set; }
        public double HoursWorked { get; set; }
        public double PayRate { get; set; }
        public double ComputePay()
        {
            return HoursWorked * PayRate;
        }
    }
}
