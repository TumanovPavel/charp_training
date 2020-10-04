using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactRemovalTests : AuthTestBase
    {
        [Test]
        public void ContactRemovalTest()
        {
            if (!IsElementPresent(By.Name("selected[]")))
                app.Contacts.Create(new ContactData("TestName"));
            
            app.Contacts.Remove();
        }
    }
}
