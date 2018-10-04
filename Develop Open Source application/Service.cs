﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Develop_Open_Source_application
{
    class Service
    {
        // Constant to indicate that the vehicle needs to be serviced every 10,000km
        public static int SERVICE_KILOMETER_LIMIT = 10000;

        private int lastServiceOdometerKm = 0;
        private int serviceCount = 0;
        // TODO add lastServiceDate

        // return the last service
        public int getLastServiceOdometerKm()
        {
            return this.lastServiceOdometerKm;
        }

        /**
         * The function recordService expects the total distance traveled by the car, 
         * saves it and increase serviceCount.
         * @param distance 
         */
        public void recordService(int distance)
        {
            this.lastServiceOdometerKm = distance;
            this.serviceCount++;
        }

        // return how many services the car has had
        public int getServiceCount()
        {
            return this.serviceCount;
        }

        /**
         * Calculates the total services by dividing kilometers by
         * {@link #SERVICE_KILOMETER_LIMIT} and floors the value. 
         * 
         * @return the number of services needed per SERVICE_KILOMETER_LIMIT
         */
        //public int getTotalScheduledServices()
        //{
        //    //return (int) Math.Floor(lastServiceOdometerKm / SERVICE_KILOMETER_LIMIT);
        //}
    }
}
