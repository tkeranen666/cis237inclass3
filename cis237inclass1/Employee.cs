using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass3
{
    // this is an abstract class. It is made abstract by adding the 'abstract' keyword before the word class
    abstract class Employee : IEmployee
    {
        //Backing fields
        protected string firstName;
        protected string lastName;

        //properties for the backing fields
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        //One Method that is public. Can be accessed from other classes
        public string GetFullName()
        {
            return this.firstName + " " + this.lastName;
        }

        //Override method that will print all of the fields
        //It overrides the default ToString that every object gets for free!
        public override string ToString()
        {
            return this.firstName + " " + this.lastName;
        }

        // Abstract class must have no method body. Hence the ; at the end.
        // No method body, must be implemented/overridden by children classes
        // We made this method abstract because based on information that this class has, we have no idea how to calculate a salary, let alone format one.
        // Declaring it abstract leaves the implementation details to the child class to figure out.
        public abstract string GetFormattedSalary();

        // Can be overridden, but doesn't need to be.
        // Must have method body, even if empty.
        // We made this method virtual because we already have all of the needed information to provide method body. we simply left it virtual in case
        // a subclass would like to override it for some reason.
        public virtual string GetLastNameFirstName()
        {
            return this.lastName + ", " + this.firstName;
        }

        //3 Parameter constructor
        public Employee(string firstName, string lastName)
        {
            //Assign the passed in values to the fields
            this.firstName = firstName;
            this.lastName = lastName;
        }

        //Default constructor
        public Employee()
        {
            //Lets just leave this blank
        }
    }
}
