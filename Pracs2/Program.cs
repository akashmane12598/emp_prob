using System;

namespace Pracs2
{
    class EmpBuilder
    {
        private string company_name;
        private int emp_wages;
        private int total_days;
        private int max_hours;

        public EmpBuilder(string company_name, int emp_wages, int total_days, int max_hours)
        {
            this.company_name = company_name;
            this.emp_wages = emp_wages;
            this.total_days = total_days;
            this.max_hours = max_hours;
        }

        public void compute_emp()
        {
            int wages = calculate_wages(total_days, max_hours);
            Console.WriteLine("Total wages of an employee in the company "+company_name+" is " + wages);
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
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to employee wages problem");
            EmpBuilder emp1 = new EmpBuilder("Dmart", 20, 20, 100);
            EmpBuilder emp2 = new EmpBuilder("Amazon", 30, 25, 120);
            emp1.compute_emp();
            emp2.compute_emp();
        }
        
    }
}
