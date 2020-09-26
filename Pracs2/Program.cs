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
            Random random = new Random();
            int n = random.Next(0, 2);
            if (n == 1)
            {
                hours = 8;
            }
            wages = hours * wages_per_hour;
            Console.WriteLine("Total wages of an employee: "+wages);

        }
    }
}
