﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactRemovalTests1 : AuthTestBase
    {
        [Test]
        public void ContactRemovalTest()
        {            
            app.Contacts.RemoveContact(1);           
        }            
        
    }
}
