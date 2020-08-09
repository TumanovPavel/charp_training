using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactCreationTests : TestBase
    {

        [Test]
        public void ContactCreationTest()
        {
            navigator.OpenHomePage();
            loginHelper.Login(new AccountData("admin", "secret"));
            contactHelper.InitContactCreation();
            ContactData contact = new ContactData("TestName");
            contact.LastName = "Test Last Name";
            contactHelper.FillContactForm(contact);
            contactHelper.SubmitContactCreation();
            contactHelper.ReturnToContactPage();
            loginHelper.Logout();
        }
    }
}
