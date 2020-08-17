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

        public double CalculateFare(double distance, double time)
        {
            return Math.Max((distance * 10 + time * 1), 5);
        }


        public CabInvoiceSummary CalculateMultipleRideFare(Ride[] rides)
        {
            double TotalFare = 0.0;
            foreach(Ride ride in rides)
            {
                TotalFare += this.CalculateFare(ride.distance, ride.time);
            }

            return new CabInvoiceSummary(rides.Length,TotalFare);
        }

        public void AddRides(String userId, Ride[] ride)
        {
            this.cabInvoiceRepository.addRides(userId, ride);
        }

        public CabInvoiceSummary GetInvoiceSummary(String userId)
        {
            return this.CalculateMultipleRideFare(cabInvoiceRepository.GetRides(userId));
        }
    }
}
