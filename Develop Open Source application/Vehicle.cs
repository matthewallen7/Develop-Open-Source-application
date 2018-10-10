using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Develop_Open_Source_application
{
    public class Vehicle
    {
        //getter and setter methods
        public String Manufacturer { get; set; }
        public String Model { get; set; }
        public int MakeYear { get; set; }
        public string RegoNo { get; set; }
        public double TotalKm { get; set; }
        public string TankCapactiy { get; set; }
        public string Colour { get; set; }
        public int Services { get; set; }
        public string Checkservice { get; set; }
        private FuelPurchase fuelPurchase;

        //null constructor
        public Vehicle()
        {

        }

        //class constructor method
        public Vehicle(String manufacturer, String model, int year, string regoNo, double totalKm, string capacity, string colour, int servcies, string checkservices)
        {
            Manufacturer = manufacturer;
            Model = model;
            MakeYear = year;
            RegoNo = regoNo;
            TotalKm = totalKm;
            TankCapactiy = capacity;
            Colour = colour;
            Services = servcies;
            Checkservice = checkservices;
            fuelPurchase = new FuelPurchase();
        }

        //print details for the user
        public string printDetails(string Manufacturer, string Model, int Year, string Rego, string Capacity, string Colour, double Odometer, double Distance, int Services, string Revenue, string ReqServ)
        {
            string value = "Manufacturer: " + Manufacturer + "\r\n" + "Model: " + Model + "\r\n" +
            "Year: " + Year + "\r\n" + "Regestration: " + Rego + "\r\n" +
            "Fuel Economy: " + Capacity + "\r\n" + "Colour: " + Colour + "\r\n" + "Odometer: " + Odometer + "\r\n" +
            "Distance Travelled: " + Distance + "\r\n" + "Total Services: " + Services + "\r\n" + "Revenue Recorded: " + Revenue + "\r\n" + "Requires a Service: " + ReqServ + "\r\n";
            return value;
            // TODO Display additional information about this vehicle
        }

        //calculate the total km the user has done
        public double addKilometers(double meters, double total)
        {
            double difference = total - meters;
            return difference;
        }

        // adds fuel to the car
        public void addFuel(double litres, double price)
        {
            fuelPurchase.purchaseFuel(litres, price);
        }
    }
}
