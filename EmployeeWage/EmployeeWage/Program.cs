using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("UC1");
            Attandance attandance = new Attandance();
            attandance.Attendance();
            Console.WriteLine();

            Console.WriteLine("UC2");
            Calculate calculate = new Calculate();
            calculate.EmpCalculate();
            Console.WriteLine();

            Console.WriteLine("UC3");
            PartTime part = new PartTime();
            part.EmpPartTime();
            Console.WriteLine();

            Console.WriteLine("UC4");
            SwitchCase switchs = new SwitchCase();
            switchs.EmpSwitchCase();
            Console.WriteLine();

            Console.WriteLine("UC5");
            CalculateMonth calculateMonth = new CalculateMonth();
            calculateMonth.CalculateWage();
            Console.WriteLine();

            Console.WriteLine("UC6");
            CalculateTotalHrs calculateTotalHrs = new CalculateTotalHrs();
            calculateTotalHrs.CalculateMonthHrs();
            Console.WriteLine();
        }
    }
}
