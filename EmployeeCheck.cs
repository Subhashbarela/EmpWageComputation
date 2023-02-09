using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class EmployeeCheck
    {
        public static void CheckEmp()
        {
            int Emp_is_present = 1;
            Random random = new Random();
            int empCheck = random.Next(2);
            if (empCheck == 1)
            {
                Console.WriteLine("employee is present");
            }
            else
            {
                Console.WriteLine("employee is absent");
            }
        }
    }
}
