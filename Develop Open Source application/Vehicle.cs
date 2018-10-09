using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Develop_Open_Source_application
{
    public class Vehicle
    {
        public String Manufacturer { get; set; }
        public String Model { get; set; }
        public int MakeYear { get; set; }
        public string RegoNo { get; set; }
        public double TotalKm { get; set; }
        public string TankCapactiy { get; set; } 
        public string Colour { get; set; }
        public int Services { get; set; }
        public string Checkservice { get; set; }
        // TODO add Registration Number 
        // TODO add variable for OdometerReading (in KM), 
        // TODO add variable for TankCapacity (in litres)

        private FuelPurchase fuelPurchase;

        /**
         * Class constructor specifying name of make (manufacturer), model and year
         * of make.
         * @param manufacturer
         * @param model
         * @param makeYear
         */
        public Vehicle()
        {

        }
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

        // TODO Add missing getter and setter methods

        /**
         * Prints details for {@link Vehicle}
         */
        public string printDetails(string Manufacturer, string Model, int Year, string Rego, string Capacity, string Colour, string Odometer, double Distance, int Services, string Revenue, string ReqServ)
        {
            string value = "Manufacturer: " + Manufacturer + "\r\n" + "Model: " + Model + "\r\n" +
            "Year: " + Year + "\r\n" + "Regestration: " + Rego + "\r\n" +
            "Fuel Economy: " + Capacity + "\r\n" + "Colour: " + Colour + "\r\n" + "Odometer: " + Odometer + "\r\n" +
            "Distance Travelled: " + Distance + "\r\n" + "Total Services: " + Services + "\r\n" + "Revenue Recorded: " + Revenue + "\r\n" + "Requires a Service: " + ReqServ + "\r\n";
            return value;
            // TODO Display additional information about this vehicle
        }


        // TODO Create an addKilometers method which takes a parameter for distance travelled 
        // and adds it to the odometer reading. 
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
