using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    public class EmployeeWage
    {
        const int WAGE_PER_HR = 20,FULL_DAY_HR =8,IS_PRESENT =0,IS_FULL_TIME=1,PART_TIME_HR = 4, IS_PART_TIME = 2, TOTAL_WORKING_DAYS = 20;
        Random random = new Random();
        public void Attendance()
        {
           
        int empCheck = random.Next(0, 2);
        if(empCheck ==0)
            Console.WriteLine("Employee is present");
        else
            Console.WriteLine("Employee is present");
        }
        public void EmpWage()
        {
            int dailyEmpWage = 0, empHrs =0;
            int empCheck = random.Next(0, 3);
            for (int i = 0; i < TOTAL_WORKING_DAYS; i++)
            {
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHrs = FULL_DAY_HR;
                        break;
                    case IS_PART_TIME:
                        empHrs = PART_TIME_HR;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
            }
            //if (empCheck == IS_FULL_TIME)
            //    empHrs = FULL_DAY_HR;
            //else if (empCheck == IS_PART_TIME)
            //    empHrs = PART_TIME_HR;
            //else
            //    empHrs = 0;
            dailyEmpWage = WAGE_PER_HR * empHrs;
            Console.WriteLine("Daily Emp Wage "+ dailyEmpWage);
        }
        
    }
}
