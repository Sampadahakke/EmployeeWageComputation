using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class EmployeeWage
    {
        const int IS_FULL_TIME = 1;
        const int IS_PART_TIME = 2;
        const int Emp_Rate_Per_Hour = 20;
        public void EmployeeAttendance()
        {

            Random random = new Random();
            int EmpCheck = random.Next(0, 2);

            if (EmpCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
            Console.ReadLine();
        }

        public void DailyWage()
        {
            int EmpHrs = 0;
            int EmpWage = 0;

            Random random = new Random();
            int EmpCheck = random.Next(0, 2);

            if (EmpCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is present");
                EmpHrs = 8;
            }
            else
            {
                Console.WriteLine("Employee is absent");
                EmpHrs = 0;
            }
            EmpWage = EmpHrs * Emp_Rate_Per_Hour;
            Console.WriteLine("Therefore EmpWage is " + EmpWage);
            Console.ReadLine();
        }

        public void PartTimeEmpWage()
        {
            int EmpHrs = 0;
            int EmpWage = 0;
            Random random = new Random();
            int EmpCheck = random.Next(0, 3);

            if (EmpCheck == IS_FULL_TIME)
            {
                EmpHrs = 8;
            }
            else if (EmpCheck == IS_PART_TIME)
            {
                EmpHrs = 4;
            }
            else
            {
                EmpHrs = 0;
            }
            EmpWage = EmpHrs * Emp_Rate_Per_Hour;
            Console.WriteLine("Employeewage = " + EmpWage);
            Console.ReadLine();

        }
    }
}
