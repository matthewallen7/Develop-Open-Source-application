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
    public class VehicleTests
    {
        [TestMethod()]
        public void printDetailsTest()
        {
            Vehicle test = new Vehicle();
            string output = test.printDetails("Audi", "Spyder", 2018, "1PLS110", "11.4L/100km", "Red", "35000", 5000, 3, "5000", "N");
            Assert.IsTrue(output == "Manufacturer: " + "Audi" + "\r\n" + "Model: " + "Spyder" + "\r\n" +
            "Year: " + 2018 + "\r\n" + "Regestration: " + "1PLS110" + "\r\n" +
            "Fuel Economy: " + "11.4L/100km" + "\r\n" + "Colour: " + "Red" + "\r\n" + "Odometer: " + "35000" + "\r\n" +
            "Distance Travelled: " + 5000 + "\r\n" + "Total Services: " + 3 + "\r\n" + "Revenue Recorded: " + "5000" + "\r\n" + "Requires a Service: " + "N" + "\r\n");
        }

        [TestMethod()]
        public void addKilometersTest()
        {
            Vehicle test = new Vehicle();
            double value = test.addKilometers(30000, 35000);
            Assert.IsTrue(value == 5000);
        }
    }
}