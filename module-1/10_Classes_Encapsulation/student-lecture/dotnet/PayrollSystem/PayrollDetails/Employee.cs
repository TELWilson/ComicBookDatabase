using System;
using System.Collections.Generic;
using System.Text;

namespace PayrollSystem.PayrollDetails
{
    public class Employee
    {
        private string firstName;
        private string lastName;
        private decimal totalIncome;

        public Employee(int id, string firstName, string lastName)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        public int Id { get; }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    this.firstName = value;
                }
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    this.lastName = value;
                }
            }
        }

        public string FullName
        {
            get
            {
                return this.FirstName + " " + this.LastName;
            }
        }

        public decimal Salary { get; set; }

        public void Pay()
        {
            Console.WriteLine("It is payday for " + this.FullName);
            //this.totalIncome += this.Salary / 26.0M;
            this.Pay(this.Salary / 26.0M);
        }

        public void Pay(decimal amount)
        {

            decimal amountToDeduct = Employee.CalculateWithholdingAmount(amount);

            this.totalIncome += amount - amountToDeduct;

            this.totalIncome += amount;
        }

        private static decimal CalculateWithholdingAmount (decimal amount)
        {
            return amount * 0.05m;
        }


    }
}
