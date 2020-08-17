using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceSln
{
    public class CabInvoiceSummary
    {
        public double averageFare;
        public double numberOfRides;
        public double totalFare;

        public CabInvoiceSummary(double numberOfRides, double totalFare)
        {
            this.numberOfRides = numberOfRides;
            this.totalFare = totalFare;
            this.averageFare = totalFare / numberOfRides;
        }
    }
}
