using CabInvoiceSln;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        CabInvoice cabInvoice;

        [SetUp]
        public void Setup()
        {
            cabInvoice = new CabInvoice();
        }

        [Test]
        public void WhenGiven_DistanceAndTime_ShouldReturn_TotalFare()
        {
            double distance = 2;
            int time = 1;
            double totalFare = cabInvoice.CalculateFare(distance, time);
            Assert.AreEqual(21,totalFare);
        }
    }
}