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
            Attandance attandance = new Attandance();
            attandance.Attendance();
            Console.WriteLine();

            Calculate calculate  = new Calculate();
            calculate.EmpCalculate();
            Console.WriteLine();

            PartTime part = new PartTime();
            part.EmpPartTime();
            Console.WriteLine();

            SwitchCase switchs = new SwitchCase();
            switchs.EmpSwitchCase();
            Console.WriteLine();
        }
    }
}
