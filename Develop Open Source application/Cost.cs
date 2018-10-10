using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Develop_Open_Source_application
{
    //cost class
    class Cost
    {
        //null constuctor
        public Cost()
        {

        }

        //Calculate Costs
        public string CalcCost(double km)
        {
            string str = "$ " + km.ToString();  //$1 per km
            return str; //return result
        }
    }
}
