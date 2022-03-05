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
    public class GroupModificationTests : AuthTestBase
    {
        [Test]
        public void GroupModificationTest()

        {
            GroupData newData = new GroupData("ddd");
            newData.Header = null;
            newData.Footer = null;

            app.Navigator.GoToGroupsPage();

            if (app.Groups.IsElementPresent(By.Name("selected[]")) != true)
            {
                app.Groups.Creat(newData);
            }                          
               
            app.Groups.Modify(1, newData);
            
        }
    }
}
