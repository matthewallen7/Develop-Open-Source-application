using Microsoft.VisualStudio.TestTools.UnitTesting;
using Develop_Open_Source_application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Develop_Open_Source_application.Tests
{
    [TestClass()]
    public class ServiceTests
    {
        [TestMethod()]
        public void recordServiceTest()
        {
            Service test = new Service();
            string no = test.recordService(10, 109000);
            string yes = test.recordService(10, 110000);
            Assert.IsTrue(no == "N" && yes == "Y");
        }
    }
}