using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Develop_Open_Source_application
{
    //fuel purchase class
    class FuelPurchase
    {
        //declare veriables
        private double fuelEconomy;
        private double litres = 0;
        private double cost = 0;

        // null constructor
        public FuelPurchase()
        {

        }

        //get fuel enconomy method
        public double getFuelEconomy()
        {
            return fuelEconomy;
            //return this.cost / this.litres;
        }

        //get fuel method
        public double getFuel()
        {
            return this.litres;
        }

        // set the fuel enconomy
        public void setFuelEconomy(double fuelEconomy)
        {
            this.fuelEconomy = fuelEconomy;
        }

        //purchase fuel method
        public void purchaseFuel(double amount, double price)
        {
            this.litres += amount;
            this.cost += price;
        }
    }
}
