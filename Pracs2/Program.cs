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

        }
    }
}
