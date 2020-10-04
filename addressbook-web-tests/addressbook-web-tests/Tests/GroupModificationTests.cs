using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupModificationTests : AuthTestBase
    {
        [Test]
        public void GroupModificationTest()
        {
            if (!IsElementPresent(By.ClassName("group")))
                app.Groups.Create(new GroupData("Test1"));

            GroupData newData = new GroupData("zzz");
            newData.Header = "tttt";
            newData.Footer = "cccc";

            app.Groups.Modify(1, newData);
        }
    }
}
