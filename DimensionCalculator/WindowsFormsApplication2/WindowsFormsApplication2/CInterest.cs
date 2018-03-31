using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DimensionCalculator
{
    class CInterest2
    {

        public CInterest2()
        {

        }

        // summary //

        // create an Interest rate constructor with an an overloaded method //
        // class member must consist out of three parameters //
        public double CalculateInterest(double startAmmount, double Interest, double Period)
        {
            double EndAmmount = (((startAmmount / Period) * Interest) / 100);
            return EndAmmount;

        }

        // class member which does not take a period parameter //
        public double CalculateInterest(double StartAmmount, double Interest)
        {
            double EndAmmount = (StartAmmount * (Interest / 100) * 1);
            return EndAmmount;

        }
    }
}
