using NUnit.Framework;
using System.Collections.Generic;

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
            List<ContactData> oldContacts = app.Contacts.GetContactList();

            app.Contacts.Modify(newData);
            List<ContactData> newContacts = app.Contacts.GetContactList();
            oldContacts[0].FirstName = newData.FirstName;
            oldContacts[0].LastName = newData.LastName;
            oldContacts.Sort();
            newContacts.Sort();
            Assert.AreEqual(oldContacts, newContacts);

        }
    }
}
