using System;
using System.Collections.Generic;
using System.Text;

namespace Pracs2
{
    class EmpWageBuilder : Company
    {
        private int totalCompany = 0;

        private CompanyEmp[] companyEmp;

        public EmpWageBuilder()
        {
            this.companyEmp = new CompanyEmp[5];
        }

        public void addCompany(string company_name, int emp_wages, int total_days, int max_hours)
        {
            companyEmp[this.totalCompany] = new CompanyEmp(company_name, emp_wages, total_days, max_hours);
            totalCompany++;
        }

        public void compute_emp()
        {
            for (int i = 0; i < this.totalCompany; i++)
            {
                int wages = calculate_wages(companyEmp[i].total_days, companyEmp[i].max_hours);
                Console.WriteLine("Total wages of an employee in the company " + companyEmp[i].company_name + " is " + wages);
            }
        }

        public int calculate_wages(int total_days, int max_hours)
        {
            Random random = new Random();
            int wages_per_hour = 20;
            int hours = 0;
            int wages = 0;
            int total_hours = 0;
            int days = 1;
            while (days <= total_days && total_hours <= max_hours)
            {
                int n = random.Next(0, 3);
                switch (n)
                {
                    case 0:
                        hours = 0;
                        break;
                    case 1:
                        hours = 8;
                        break;
                    case 2:
                        hours = 4;
                        break;
                }
                total_hours += hours;
                Console.WriteLine("Day: " + days + " Working Hours: " + hours);
                days++;
            }
            wages = total_hours * wages_per_hour;
            return wages;
        }
    }
}
