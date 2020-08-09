using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using WebAddressbookTests;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {
 
        [Test]
        public void GroupCreationTest()
        {
            GroupData group = new GroupData("Test1");
            group.Header = "q";
            group.Footer = "q";

            app.Groups.Create(group);
            app.Auth.Logout();
        }

        [Test]
        public void EmptyGroupCreationTest()
        {
            GroupData group = new GroupData("");
            group.Header = "";
            group.Footer = "";

            app.Groups.Create(group);
            app.Auth.Logout();
        }
    }
}
