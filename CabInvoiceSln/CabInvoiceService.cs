using System;

namespace CabInvoiceSln
{
    public class CabInvoiceService
    {
        public double CalculateFare(double distance, double time)
        {
            return Math.Max((distance * 10 + time * 1), 5);
        }

        public double CalculateMultipleRideFare(Ride[] rides)
        {
            double TotalFare = 0.0;
            foreach(Ride ride in rides)
            {
                TotalFare += this.CalculateFare(ride.distance, ride.time);
            }

            return TotalFare;
        } 
    }
}
