using System;

namespace Pracs2
{
    class Program
    {
        public static void Main(string[] args)
        {
          
          
            int wages_per_hour = 20;
            int hours = 0;
            int wages = 0;
            int total_hours = 0;

            Random random = new Random();
            
            for(int i = 1; i <= 20; i++)
            {
                int emp_rec = random.Next(0, 3);
                switch (emp_rec)
                {
                    case 0:
                        hours = 0;
                        break;
                    case 1:
                        hours = 8;
                        break;
                    case 2:
                        hours= 4;
                        break;
                }
                total_hours += hours;

                if (total_hours >= 100)
                {
                    break;
                }

            }
            wages = total_hours * wages_per_hour;
            Console.WriteLine("Total wages of an employee: "+wages);

        }
    }
}
