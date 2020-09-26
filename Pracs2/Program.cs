using System;

namespace Pracs2
{
    class Program
    {
        public static void Main(string[] args)
        {
          
            Console.WriteLine("Enter 1 for present and 0 for absent");
            Random random = new Random();
            //int n = Convert.ToInt32(Console.ReadLine());
            int n = random.Next(0, 2);
            String att = "";
            if (n == 1)
            {
                att += "Present";
            }
            else
            {
                att += "Absent";
            }
            Console.WriteLine(att);
            int wages_per_hour = 20;
            int hours = 0;
            int wages = 0;
            
            //int n1 = random.Next(0, 2);
            if (n == 1)
            {
                hours = 8;
            }
            wages = hours * wages_per_hour;
            Console.WriteLine("Total wages of an employee: "+wages);

        }
    }
}
