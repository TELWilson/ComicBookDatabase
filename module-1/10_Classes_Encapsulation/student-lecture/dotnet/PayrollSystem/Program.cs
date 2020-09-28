using System;
using PayrollSystem.PayrollDetails;

namespace PayrollSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Company hooli = new Company("Hooli", "42 Wallaby Way");
            Employee moss = new Employee(1, "Moss", "Crowd");

            hooli.Hire(moss, 75000M);

            Employee roy = new Employee(2, "Roy", "Jerkface");

            moss.LastName = "Awesome";
            hooli.Pay();
            //PayEmployees(hooli);

            moss.Pay(1000M);

            
            Console.WriteLine("That's all folks");

        }

        private static void PayEmployees(Company company)
        {
            company.Pay();
        }
    }
}
