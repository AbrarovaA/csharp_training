using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactModificationTests : AuthTestBase
    {
        [Test]
        public void ContactModificationTest()
        {
            ContactData newData = new ContactData("updfirstname", "updlastname");

            if (app.Contacts.IsElementPresent(By.Name("selected[]")) == true)
            {
                app.Contacts.Modify(1, newData);
            }
            else
            {                
                app.Contacts.CreateContact(newData);
                app.Contacts.Modify(1, newData);
            }
        }
    }
}
