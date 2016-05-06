using Microsoft.VisualStudio.TestTools.UnitTesting;
using SynUp_Desktop.model.dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynUp_Desktop.model.dao.Tests
{
    [TestClass()]
    public class ConnectionTests
    {
        [TestMethod()]
        public void createTaskTest()
        {

        }

        [TestMethod()]
        public void readTaskTest()
        {
            Assert.Equals(null , Connection.readTask("something"));
        }
    }
}