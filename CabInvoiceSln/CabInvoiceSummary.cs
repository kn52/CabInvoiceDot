using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceSln
{
    public class CabInvoiceSummary
    {
        public double AverageFare;
        public double NumberOfRides;
        public double TotalFare;

        public CabInvoiceSummary(double numberOfRides, double totalFare)
        {
            this.NumberOfRides = numberOfRides;
            this.TotalFare = totalFare;
            this.AverageFare = totalFare / numberOfRides;
        }

        public override bool Equals(object obj)
        {
            var summary = obj as CabInvoiceSummary;
            return summary != null &&
                   AverageFare == summary.AverageFare &&
                   NumberOfRides == summary.NumberOfRides &&
                   TotalFare == summary.TotalFare;
        }

        public override int GetHashCode()
        {
            var hashCode = 1576399205;
            hashCode = hashCode * -1521134295 + AverageFare.GetHashCode();
            hashCode = hashCode * -1521134295 + NumberOfRides.GetHashCode();
            hashCode = hashCode * -1521134295 + TotalFare.GetHashCode();
            return hashCode;
        }
    }
}
