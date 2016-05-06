using Microsoft.VisualStudio.TestTools.UnitTesting;
using SynUp_Desktop.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynUp_Desktop.service.Tests
{
    [TestClass()]
    public class ServiceTests
    {
        [TestMethod()]
        public void createTaskTest()
        {
            
            bool resultat = false;

            Service servei = new Service();

            //String code, String name, DateTime priorityDate, String description, String localization, String project
            resultat = servei.createTask("3","Projecte",DateTime.Now,null,null,null);

            Assert.AreEqual(true, resultat);     
            
        }
    }
}