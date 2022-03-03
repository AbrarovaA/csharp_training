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
    public class ContactRemovalTests1 : AuthTestBase
    {
        [Test]
        public void ContactRemovalTest()
        {
            if (app.Contacts.IsElementPresent(By.Name("selected[]")) == true)
            {
                app.Contacts.RemoveContact(1);
            }
            else
            {
                ContactData firstcontact = new ContactData("myname", "mylastname");
                app.Contacts.CreateContact(firstcontact);
                app.Contacts.RemoveContact(1);
            }
        }          
        
        
    }
}
