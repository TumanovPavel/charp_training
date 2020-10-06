using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupModificationTests : AuthTestBase
    {
        [Test]
        public void GroupModificationTest()
        {
            if (!app.Groups.GroupIsPresent())
                app.Groups.Create(new GroupData("Test1"));

            GroupData newData = new GroupData("zzz");
            newData.Header = "tttt";
            newData.Footer = "cccc";

            app.Groups.Modify(1, newData);
        }
    }
}
