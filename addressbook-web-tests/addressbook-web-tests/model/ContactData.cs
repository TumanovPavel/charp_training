using System;
using System.Collections.Generic;
using System.Text;

namespace WebAddressbookTests
{
    public class ContactData : IEquatable <ContactData>, IComparable<ContactData>
    {
        private string allPhones;
        private string allemails;

        public string FirstName { set; get; }

        public string LastName { set; get; }
        
        public string Id { set; get; }
        
        public string Address { set; get; }
        
        public string MobilePhone { set; get; }
        
        public string HomePhone { set; get; }
        
        public string WorkPhone { set; get; }
        
        public string Email { set; get; }
                
        public string Email2 { set; get; }
        
        public string Email3 { set; get; }
               
         public string AllPhones
        {
            get
            {
                if (allPhones != null)
                    return allPhones;
                else
                    return (CleanUp(HomePhone) + CleanUp(MobilePhone) + CleanUp(WorkPhone)).Trim();
            }
            set
            {
                allPhones = value;
            }
        }

        public string AllEmails
        {
            get
            {
                if (allemails != null)
                {
                    return allemails;
                }
                else
                {
                    return (CleanUpEmails(Email) + CleanUpEmails(Email2) + CleanUpEmails(Email3)).Trim();
                }

            }
            set
            {
                allemails = value;
            }
        }

        private string CleanUp(string phone)
        {
            if (phone == null || phone =="")
                return "";
            return phone.Replace(" ", "").Replace("-", "").Replace("(", "").Replace(")", "") + "\r\n";
        }

        private string CleanUpEmails(string email)
        {
            if (email == null || email == "")
                return "";
            return email.Replace(" ", "") + "\r\n";
        }

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
