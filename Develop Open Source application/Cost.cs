using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Develop_Open_Source_application
{
    class Cost
    {
        public Cost()
        {

        }

        public string CalcCost(double km)
        {
            string str = "$ " + km.ToString();
            return str;
        }
    }
}
