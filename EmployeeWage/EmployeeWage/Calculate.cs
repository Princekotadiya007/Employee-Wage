using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class Calculate
    {
        public void EmpCalculate()
        {

            int EMP_PER_Hour = 20;
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 2);

            if(empCheck == 0)
            {
                empHrs = 8;
                Console.WriteLine("Employee is present");
            }
            else
            {
                empHrs = 4;
                Console.WriteLine("Employee is not present");
            }
            empWage = empHrs * EMP_PER_Hour;
            Console.WriteLine("Emp wage :" + empWage);
        }
    }
}
