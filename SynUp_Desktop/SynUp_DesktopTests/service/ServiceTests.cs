﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
        /// <summary>
        /// Create task test succedded on 05/05/2016
        /// </summary>
        /// <author>Pablo Ardèvol Garcia</author>
        [TestMethod()]
        public void createTaskTest()
        {            
            bool resultat = false;
            TaskService servei = new TaskService();
            //String code, String name, DateTime priorityDate, String description, String localization, String project
            resultat = servei.createTask("3","Projecte",DateTime.Now,null,null,null,null,0);
            Assert.AreEqual(true, resultat);                 
        }
    }
}