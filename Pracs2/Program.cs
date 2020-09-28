using System;

namespace Pracs2
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Welcome to employee wages problem");
            Random random = new Random();

            int wages_per_hour = 20;
            int hours = 0;
            int wages = 0;
            
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
            wages = hours * wages_per_hour;
            Console.WriteLine("Total wages of an employee: "+wages);

        }
    }
}
