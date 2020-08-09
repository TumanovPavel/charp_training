using System;
using System.Collections.Generic;
using System.Text;

namespace WebAddressbookTests
{
    public class GroupData
    {
        private string header = "";
        private string footer = "";
        public string Name { set; get; }
        public GroupData(string name)
        {
            this.Name = name;
        }

        public string Header
        {
            get
            {
                return header;
            }
            set
            {
                header = value;
            }
        }
        public string Footer
        {
            get
            {
                return footer;
            }
            set
            {
                footer = value;
            }
        }

    }
}
