using System;
using System.Collections.Generic;
using System.Text;

namespace WebAddressbookTests
{
    public class GroupData : IEquatable<GroupData>, IComparable<GroupData>
    {
        public string Header  { set; get; }
        public string Footer  { set; get; }
        public string Name { set; get; }
        public string Id { set; get; }
        public GroupData(string name)
        {
            this.Name = name;
        }

        public bool Equals(GroupData other)
        {
            if (Object.ReferenceEquals(other, null))
                return false;
            if (Object.ReferenceEquals(this, other))
                return true;
            return Name == other.Name;
        }

        public int CompareTo(GroupData other)
        {
            if (Object.ReferenceEquals(other, null))
                return 1;
            return Name.CompareTo(other.Name);
        }

        public override int GetHashCode() 
            => Name.GetHashCode();

        public override string ToString()
        {
            return "Name = " + Name;
        }
    }
}
