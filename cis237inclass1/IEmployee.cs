using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass3
{
    interface IEmployee
    {
        // An interface only contains method declaration and properties/
        // there is no need to put an access modifier down. That is handled by class that implements this interface
        // any class that implements this interface must implement the following methods. Even if they are abstract with no method body.
        // we are specifying only public methods
        string GetFormattedSalary();
        string GetLastNameFirstName();

        // any class that implements this interface must implement the following properties
        string FirstName
        {
            get;
            set;
        }

        string LastName
        {
            get;
            set;
        }
    }
}
