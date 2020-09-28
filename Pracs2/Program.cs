using System;

namespace Pracs2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to employee wages problem");
            compute_emp("Dmart",20,20,100);
        }
        public static void compute_emp(string company_name,int emp_wages, int total_days, int max_hours) 
        {
            int wages;
            wages = calculate_wages(total_days, max_hours);
            Console.WriteLine("Total wages of an employee: " + wages);
        }
        public static int calculate_wages(int total_days, int max_hours)
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
                if (n == 2)
                {
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
                    days++;
                }
            }
            wages = total_hours * wages_per_hour;
            return wages;
        }
    }
}
