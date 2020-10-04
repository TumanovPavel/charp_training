using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;

namespace WebAddressbookTests

{
    [TestFixture]
    public class ContactModificationTests : AuthTestBase
    {
        [Test]
        public void ContactModificationTest()
        {
            if (!IsElementPresent(By.Name("selected[]")))
                app.Contacts.Create(new ContactData("TestName"));

            ContactData newData = new ContactData("Test");
            newData.LastName = "Modification";

            app.Contacts.Modify(newData);
        }
    }
}
