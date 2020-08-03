using System;
using System.Collections.Generic;
using System.Text;

namespace WebAddressbookTests
{
    class ContactData
    {

        public string FirstName { set; get; }

        public string LastName { set; get; }

        public ContactData(string firstName)
        {
            FirstName = firstName;
        }
    }
}
