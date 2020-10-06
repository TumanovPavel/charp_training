using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactRemovalTests : AuthTestBase
    {
        [Test]
        public void ContactRemovalTest()
        {
            if (!app.Contacts.ContactIsPresent())
                app.Contacts.Create(new ContactData("TestName"));
            
            app.Contacts.Remove();
        }
    }
}
