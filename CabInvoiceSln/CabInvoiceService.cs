using System;

namespace CabInvoiceSln
{
    public class CabInvoiceService
    {
        CabInvoiceRepository cabInvoiceRepository;

        public CabInvoiceService()
        {
            this.cabInvoiceRepository = new CabInvoiceRepository();
        }

        public double CalculateFare(double distance, double time, string rideType)
        {
            if(rideType.Equals("PREMIUM"))
            {
                return Math.Max((distance * 15 + time * 2), 20);
            }
            
            return Math.Max((distance * 10 + time * 1), 5);
        }


        public CabInvoiceSummary CalculateMultipleRideFare(Ride[] rides)
        {
            double TotalFare = 0.0;
            foreach(Ride ride in rides)
            {
                TotalFare += this.CalculateFare(ride.Distance, ride.Time,ride.RideType);
            }

            return new CabInvoiceSummary(rides.Length,TotalFare);
        }

        public void AddRides(string userId, Ride[] ride)
        {
            this.cabInvoiceRepository.AddRides(userId, ride);
        }

        public CabInvoiceSummary GetInvoiceSummary(string userId)
        {
            return this.CalculateMultipleRideFare(cabInvoiceRepository.GetRides(userId));
        }
    }
}
