using System;

namespace Pracs2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to employee wages problem");
            Random random = new Random();
            int n = random.Next(0, 3);
            int wages_per_hour = 20;
            int hours = 0;
            int wages = 0;
     
            if (n == 1)
            {
                hours = 8;
            }
            else if (n == 2)
            {
                hours = 4;
            }
            wages = hours * wages_per_hour;
            Console.WriteLine("Total wages of an employee: "+wages);

        }
    }
}
