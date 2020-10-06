using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using WebAddressbookTests;
using NUnit.Framework;
using System.Collections.Generic;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupCreationTests : AuthTestBase
    {
 
        [Test]
        public void GroupCreationTest()
        {
            GroupData group = new GroupData("Test1");
            group.Header = "q";
            group.Footer = "q";

/*            List<GroupData> oldGroups = app.Groups.GetGroupList;

            app.Groups.Create(group);
            
            List<GroupData> newGroups = app.Groups.GetGroupList;

            Assert.AreEqual(oldGroups.Count + 1, newGroups.Count);
*/        }

        [Test]
        public void EmptyGroupCreationTest()
        {
            GroupData group = new GroupData("");
            group.Header = "";
            group.Footer = "";

            app.Groups.Create(group);
        }
    }
}
