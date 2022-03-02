using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;


namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupRemovalTests : AuthTestBase
    {
        [Test]
        public void GroupRemovalTest()

        {
            app.Navigator.GoToGroupsPage();         

            if (app.Groups.IsElementPresent(By.Name("selected[]")) == true)
            {                
                app.Groups.Remove(1);
            }
            else 
            {
                GroupData firstgroup = new GroupData("1");
                app.Groups.Creat(firstgroup);
                app.Groups.Remove(1);
            }
                   
                     
        }            
                               
              
    }

}

