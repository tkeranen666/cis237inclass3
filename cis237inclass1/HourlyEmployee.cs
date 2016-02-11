using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass3
{
    class HourlyEmployee : Employee
    {
        // constants for the hours per week, and the weeks per year
        const decimal HOURS_PER_WEEK = 40;
        const decimal WEEKS_PER_YEAR = 52;

        // Create backing field for hourly rate
        private decimal hourlyRate;

        // 3 parameter constructor that uses the parent's constructor to do some work
        public HourlyEmployee(string firstName, string lastName, decimal hourlyRate) :
            base(firstName, lastName)
        {
            this.hourlyRate = hourlyRate;
        }

        // public property for Salary backing field
        public decimal Salary
        {
            get
            {
                return this.hourlyRate * HOURS_PER_WEEK * WEEKS_PER_YEAR;
            }
        }

        // public override of Tostring method. It uses parent's tostring method to get some of it's work done.
        public override string ToString()
        {
            return base.ToString() + " " + Salary.ToString("C");
        }
    }
}
