using System;
using System.Collections.Generic;
using System.Text;

namespace WebAddressbookTests
{
    public class ContactData : IEquatable <ContactData>, IComparable<ContactData>
    {

        public string FirstName { set; get; }

        public string LastName { set; get; }

        public ContactData(string firstName)
        {
            FirstName = firstName;
        }

        public ContactData(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public bool Equals(ContactData other)
        {
            if (Object.ReferenceEquals(other, null))
                return false;
            if (Object.ReferenceEquals(this, other))
                return true;
            return FirstName == other.FirstName && LastName == other.LastName;
        }

        public override int GetHashCode()
            => FirstName.GetHashCode();

        public int CompareTo(ContactData other)
        {
            if (Object.ReferenceEquals(other, null))
                return 1;
            if (LastName.CompareTo(other.LastName) == 0)
                return LastName.CompareTo(other.LastName);
            return FirstName.CompareTo(other.FirstName);
        }

        public override string ToString()
        {
            return "LastName = " + LastName + "FirstName = " + FirstName;
        }
    }
}
