using NUnit.Framework;


namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupRemovalTests : AuthTestBase
    {
        [Test]
        public void GroupRemovalTest()
        {
            if (!app.Groups.GroupIsPresent())
                app.Groups.Create(new GroupData("Test1"));

            app.Groups.Remove(1);
        }
  }
}
