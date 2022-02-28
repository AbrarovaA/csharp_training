using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupRemovalTests : AuthTestBase
    {
        [Test]
        public void GroupRemovalTest()
        {
            GroupData firstgroup = new GroupData("firstgroup");
            firstgroup.Header = null;
            firstgroup.Footer = null;

            app.Groups.Remove(1, firstgroup);           
        }            
                               
              
    }

}

