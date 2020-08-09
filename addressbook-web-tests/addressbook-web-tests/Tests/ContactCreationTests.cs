﻿using System;
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
            ContactData contact = new ContactData("TestName");
            contact.LastName = "Test Last Name";

            app.Contacts.Create(contact);
            app.Auth.Logout();
        }
    }
}
