﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Develop_Open_Source_application
{
    class Journey
    {
        private double kilometers;

        /**
         * Class constructor
         */
        public Journey()
        {
            this.kilometers = 0;
        }

        /** 
         * Appends the distance parameter to {@link #kilometers}
         * @param kilometers the distance traveled 
         */
        public void addKilometers(double kilometers)
        {
            this.kilometers += kilometers;
        }



        /**
         * Getter method for total Kilometers traveled in this journey.
         * @return {@link #kilometers}
         */
        public double getKilometers()
        {
            return kilometers;
        }
    }
}
