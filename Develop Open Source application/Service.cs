using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Develop_Open_Source_application
{
    public class Service
    {
        // Constant to indicate that the vehicle needs to be serviced every 10,000km
        public static int SERVICE_KILOMETER_LIMIT = 10000;

        private int lastServiceOdometerKm = 0;
        private string lastServiceDate;

        // return the last service
        public int getLastServiceOdometerKm()
        {
            return this.lastServiceOdometerKm;
        }

        //method to issue a service result for the vehicle
        public string recordService(int services, double distance)
        {
            int nextService = (services + 1) * SERVICE_KILOMETER_LIMIT;
            if (distance >= nextService)
            {
                return "Y";
            }
            else
            {
                return "N";
            }
        }

        // return how many services the car has had
        public int getServiceCount(int services)
        {
            services++;
            return services;
        }
    }
}
