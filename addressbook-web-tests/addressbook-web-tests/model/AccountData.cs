using System;
using System.Collections.Generic;
using System.Text;

namespace WebAddressbookTests
{
    public class AccountData
    {
        public string Username { set; get; }
        public string Password { set; get; }
        public AccountData(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }
    }
}
