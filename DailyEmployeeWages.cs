using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class DailyEmployeeWages
    {
        public static void empWage()
        {
            int Is_Full_Time = 1;
            int Emp_Rate_Per_Hour = 20;
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = (random.Next(2));
            if (empHrs == Is_Full_Time)
            {
                empHrs = 8;
            }
            else
            {
                Console.WriteLine(" Employee is Absent.....");
                empHrs = 0;
            }
            empWage = empHrs * Emp_Rate_Per_Hour;
            Console.WriteLine("Employee Wage is :" + empWage);
        }
    }
}
