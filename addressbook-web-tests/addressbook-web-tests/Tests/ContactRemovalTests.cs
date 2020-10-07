using NUnit.Framework;
using System.Collections.Generic;

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
            List<ContactData> oldContacts = app.Contacts.GetContactList();

            app.Contacts.Remove();
            oldContacts.RemoveAt(0);
            List<ContactData> newContacts = app.Contacts.GetContactList();

            Assert.AreEqual(oldContacts, newContacts);
        }
    }
}
