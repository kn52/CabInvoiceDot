using System;

namespace CabInvoiceSln
{
    public class CabInvoice
    {
        public double CalculateFare(double distance, int time)
        {
            double totalFare = distance * 10 + time * 1;
            return Math.Max(totalFare, 5);
        }
    }
}
