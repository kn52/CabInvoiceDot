using CabInvoiceSln;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        CabInvoiceService cabInvoiceService;

        [SetUp]
        public void Setup()
        {
            cabInvoiceService = new CabInvoiceService();
        }

        [Test]
        public void WhenGiven_DistanceAndTime_ShouldReturn_TotalFare()
        {
            double distance = 2;
            int time = 1;
            double TotalFare = cabInvoiceService.CalculateFare(distance, time);
            Assert.AreEqual(21,TotalFare);
        }

        [Test]
        public void WhenGiven_DistanceAndTime_ShouldReturn_MinimumFare()
        {
            double distance = 0.1;
            int time = 1;
            double TotalFare = cabInvoiceService.CalculateFare(distance, time);
            Assert.AreEqual(5, TotalFare);
        }

        [Test]
        public void WhenGivenMultipleRides_SHouldReturn_Summary()
        {
            Ride[] ride ={ new Ride(2.0,2),
                new Ride(3,1) };
            double TotalFare = cabInvoiceService.CalculateMultipleRideFare(ride);
            Assert.AreEqual(53, TotalFare);
        }
    }
}