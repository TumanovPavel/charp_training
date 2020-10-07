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
            ContactData toBeRemoved = oldContacts[0];
            
            app.Contacts.Remove();
            Assert.AreEqual(oldContacts.Count - 1, app.Contacts.GetContactsCount());
            oldContacts.RemoveAt(0);
            List<ContactData> newContacts = app.Contacts.GetContactList();

            Assert.AreEqual(oldContacts, newContacts);
            foreach (ContactData contact in newContacts)
            {
                Assert.AreNotEqual(contact.Id, toBeRemoved.Id);
            }
        }
    }
}
