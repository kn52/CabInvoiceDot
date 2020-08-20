namespace Tests
{
    using CabInvoiceSln;
    using CabInvoiceSln.Model;
    using NUnit.Framework;

    /// <summary>
    /// Cab Invoice Test.
    /// </summary>
    public class Tests
    {
        CabInvoiceService cabInvoiceService;

        [SetUp]
        public void Setup()
        {
            cabInvoiceService = new CabInvoiceService();
        }

        /// <summary>
        /// Distance and Time to calculate normal fare.
        /// </summary>
        [Test]
        public void WhenGiven_DistanceAndTime_ShouldReturn_TotalFare()
        {
            double distance = 2;
            double time = 1.0;
            double TotalFare = cabInvoiceService.CalculateFare(distance, time, RideType.NORMAL);
            Assert.AreEqual(21,TotalFare);
        }

        /// <summary>
        /// Distance and Time to return minimum fare.
        /// </summary>
        [Test]
        public void WhenGiven_DistanceAndTime_ShouldReturn_MinimumFare()
        {
            double distance = 0.1;
            double time = 1.0;
            double TotalFare = cabInvoiceService.CalculateFare(distance, time, RideType.NORMAL);
            Assert.AreEqual(5, TotalFare);
        }

        /// <summary>
        /// Distance and Time to return normal rides summary.
        /// </summary>
        [Test]
        public void WhenGivenMultipleRides_ShouldReturn_Summary()
        {
            Ride[] ride ={ new Ride(2.0,2,RideType.NORMAL),
                new Ride(3.0,1,RideType.NORMAL) };
            CabInvoiceSummary ExpectedSummary = new CabInvoiceSummary(2, 53);
            CabInvoiceSummary ActualSummary = cabInvoiceService.CalculateMultipleRideFare(ride);
            Assert.AreEqual(ExpectedSummary, ActualSummary);
        }

        /// <summary>
        /// Distance and Time to return normal rides summary by user id.
        /// </summary>
        [Test]
        public void WhenGiven_UserAnd_Rides_ShouldReturn_InvoiceSummary()
        {
            string UserId = "abc@cb.com";
            Ride[] ride ={ new Ride(2.0,2,RideType.NORMAL),
                new Ride(3.0,1,RideType.NORMAL) };
            cabInvoiceService.AddRides(UserId, ride);
            CabInvoiceSummary ExceptedSummary = new CabInvoiceSummary(2, 53);
            CabInvoiceSummary ActualSummary = cabInvoiceService.GetInvoiceSummary(UserId);
            Assert.AreEqual(ExceptedSummary, ActualSummary);
        }

        /// <summary>
        /// Distance and Time to return premium rides summary by user id.
        /// </summary>
        [Test]
        public void WhenGiven_UserAnd_RideswithPremium_ShouldReturn_InvoiceSummary()
        {
            string UserId = "def@gh.com";

            Ride[] ride={ new Ride(2.0,2,RideType.PREMIUM),
                new Ride(3.0,1,RideType.PREMIUM) };
            cabInvoiceService.AddRides(UserId, ride);
            CabInvoiceSummary ExceptedSummary = new CabInvoiceSummary(2, 81);
            CabInvoiceSummary ActualSummary = cabInvoiceService.GetInvoiceSummary(UserId);
            Assert.AreEqual(ExceptedSummary, ActualSummary);
        }

        /// <summary>
        /// Distance and Time to return normal and premium rides summary by user id.
        /// </summary>
        [Test]
        public void WhenGiven_UserAnd_RideswithNormalAndPremium_ShouldReturn_InvoiceSummary()
        {
            string UserId = "abd@u.com";

            Ride[] ride ={ new Ride(2.0,2,RideType.PREMIUM),
                new Ride(4.0,3,RideType.NORMAL),
                new Ride(4.0,3,RideType.PREMIUM),
                new Ride(6.0,3,RideType.NORMAL),
                new Ride(3.0,1,RideType.PREMIUM) };
            cabInvoiceService.AddRides(UserId, ride);
            CabInvoiceSummary ExceptedSummary = new CabInvoiceSummary(5, 253);
            CabInvoiceSummary ActualSummary = cabInvoiceService.GetInvoiceSummary(UserId);
            Assert.AreEqual(ExceptedSummary, ActualSummary);
        }
    }
}