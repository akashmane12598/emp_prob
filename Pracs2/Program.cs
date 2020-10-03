using System;

namespace Pracs2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to employee wages problem");
            EmpWageBuilder emp1 = new EmpWageBuilder();
            emp1.addCompany("Dmart", 20, 20, 100);
            emp1.addCompany("Amazon", 30, 25, 120);
            emp1.compute_emp();
        }

    }
}
