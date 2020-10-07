using NUnit.Framework;
using System.Collections.Generic;


namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupRemovalTests : AuthTestBase
    {
        [Test]
        public void GroupRemovalTest()
        {
            app.Navigator.GoToGroupsPage();
            if (!app.Groups.GroupIsPresent())
                app.Groups.Create(new GroupData("Test1"));

            List<GroupData> oldGroups = app.Groups.GetGroupList();
            app.Groups.Remove(0);
            oldGroups.RemoveAt(0);
            List<GroupData> newGroups = app.Groups.GetGroupList();

            Assert.AreEqual(oldGroups, newGroups);
        }
    }
}
