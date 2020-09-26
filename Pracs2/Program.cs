using System;

namespace Pracs2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            int emp_rec = random.Next(0, 3);
            int wages_per_hour = 20;
            int hours = 0;
            int wages = 0;
     
            if (emp_rec == 1)
            {
                hours = 8;
            }
            else if (emp_rec == 2)
            {
                hours = 4;
            }
            wages = hours * wages_per_hour;
            Console.WriteLine("Total wages of an employee: "+wages);

        }
    }
}
