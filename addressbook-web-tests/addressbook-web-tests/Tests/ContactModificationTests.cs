using NUnit.Framework;

namespace WebAddressbookTests

{
    [TestFixture]
    public class ContactModificationTests : AuthTestBase
    {
        [Test]
        public void ContactModificationTest()
        {
            if (!app.Contacts.ContactIsPresent())
                app.Contacts.Create(new ContactData("TestName"));

            ContactData newData = new ContactData("Test");
            newData.LastName = "Modification";

            app.Contacts.Modify(newData);
        }
    }
}
