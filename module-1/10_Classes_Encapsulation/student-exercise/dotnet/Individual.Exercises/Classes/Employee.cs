using System;
using System.Collections.Generic;
using System.Text;

namespace Individual.Exercises.Classes
{
    public class Employee
    {

        public Employee(int employeeId, string firstName, string lastName, double salary)
        {
            this.EmployeeId = employeeId;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.AnnualSalary = salary;
        }


        /// <summary>
        /// Gets the employee id.
        /// </summary>
        public int EmployeeId { get; }

        /// <summary>
        /// Gets the employee's first name.
        /// </summary>
        public string FirstName { get; }

        /// <summary>
        /// Gets the employee's last name.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets the employee's full name
        /// </summary>
        public string FullName //{ get; }
        {
            get
            {
                return  this.LastName + ", " + this.FirstName;
            }
        }

        /// <summary>
        /// Gets or sets the employee's department
        /// </summary>
        public string Department { get; set; }

        /// <summary>
        /// Gets the employee's annual salary.
        /// </summary>
        public double AnnualSalary { get; private set; }

        public void RaiseSalary (double percent)
        {
            double amountToRaise = percent / 100;
            this.AnnualSalary = (amountToRaise * AnnualSalary) + AnnualSalary;

        }
    }
}
