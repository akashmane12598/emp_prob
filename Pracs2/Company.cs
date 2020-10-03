using System;
using System.Collections.Generic;
using System.Text;

namespace Pracs2
{
    interface Company
    {
        void addCompany(string company_name, int emp_wages, int total_days, int max_hours);
        void compute_emp();
        int calculate_wages(int total_days, int max_hours);

    }
}
