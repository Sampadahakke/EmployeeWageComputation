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
        const int NUM_OF_WORKING_DAYS = 20;
        const int MAX_HRS_IN_MONTH = 100;
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


        //Calculation of Daily Wage
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


        //Calculation of Part Time Wage
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


        // Calculation of Employee Wage Using Switch Case
        public void SwitchCase()
        {
            int EmpHrs = 0;
            int EmpWage = 0;
            Random random = new Random();
            int EmpCheck = random.Next(0, 3);

            switch (EmpCheck)
            {
                case IS_PART_TIME:
                    EmpHrs = 4;
                    break;

                case IS_FULL_TIME:
                    EmpHrs = 8;
                    break;

                default:
                    EmpHrs = 0;
                    break;
            }
            EmpWage = EmpHrs * Emp_Rate_Per_Hour;
            Console.WriteLine("Employee Wage = " + EmpWage);
            Console.ReadLine();
        }


        //Calculation of Monthly Wage
        public void MonthlyEmpWage()
        {
            int empHrs = 0, empWage = 0, totalEmpWage = 0;
            for (int day = 0; day < NUM_OF_WORKING_DAYS; day++)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                empWage = empHrs * Emp_Rate_Per_Hour;
                totalEmpWage += empWage;
                Console.WriteLine("Employee Wage : " + empWage);
            }
            Console.WriteLine("Total Employee Wage : " + totalEmpWage);
        }


        //Condition
        public void TotalHrMonthCondition()
        {
            int EmpHrs = 0, TotalEmpHrs = 0, TotalWorkingDays = 0;
            while (TotalEmpHrs <= MAX_HRS_IN_MONTH && TotalWorkingDays < NUM_OF_WORKING_DAYS)
            {
                TotalWorkingDays++;
                Random random = new Random();
                int EmpCheck = random.Next(0, 3);
                switch (EmpCheck)
                {
                    case IS_FULL_TIME:
                        EmpHrs = 8;
                        break;

                    case IS_PART_TIME:
                        EmpHrs = 4;
                        break;

                    default:
                        EmpHrs = 0;
                        break;
                }
                TotalEmpHrs += EmpHrs;
                Console.WriteLine("Days#:" + TotalWorkingDays + "Employee Hrs:" + EmpCheck);

            }
            int TotalEmpWage = TotalEmpHrs * Emp_Rate_Per_Hour;
            Console.WriteLine("Total Employee Wage =" + TotalEmpWage);
            Console.ReadLine();

        }
    }
}