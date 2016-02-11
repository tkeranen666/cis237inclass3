using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass3
{
    // Use : to denote that this class should inherit from class listed after : .
    class SalaryEmployee : Employee
    {
        // add backing field for salary
        private decimal slarary;

        // add property for salary
        public decimal Salary
        {
            get
            {
                return this.slarary;
            }
        }

        /// <summary>
        /// 3 parameter constructor that takes the following arguments
        /// </summary>
        /// <param name="firstName">First name of employee</param>
        /// <param name="lastName">Last name of employee</param>
        /// <param name="salary">Yearly salary earned</param>

        public SalaryEmployee(string firstName, string lastName, decimal salary) : base(firstName, lastName)
        {
           // Assign passed in salary to class level one.
           // this.firstName = firstName;
            this.slarary = salary;
        }

        /// <summary>
        /// Print out information of class in readable format
        /// </summary>
        /// <returns>String consisting of first name, last name, and salary</returns>
        public override string ToString()
        {
            // base.ToString() calls the ToString method of the parent class.
            // We can get a full string of all properties by concating the parent's ToString with the salary of this class. We leave the work of creating the parent's
            // information to the parent class.
           return base.ToString() + " " + this.slarary.ToString("C");
        }
    }
}
