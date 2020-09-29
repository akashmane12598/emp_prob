using System;
using System.Collections.Generic;
using System.Text;

namespace Pracs2
{
    class CompanyEmp
    {
        public string company_name;
        public int emp_wages;
        public int total_days;
        public int max_hours;
        public int totalWages;

        public CompanyEmp(string company_name, int emp_wages, int total_days, int max_hours)
        {
            this.company_name = company_name;
            this.emp_wages = emp_wages;
            this.total_days = total_days;
            this.max_hours = max_hours;
        }
        public void setTotalWages(int totalWages)
        {
            this.totalWages = totalWages;
        }

    }
}
