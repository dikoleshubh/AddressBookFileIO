using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TDD_Cab_Invoice;

namespace UnitTestProject8
{
    [TestClass]
    public class Tests
    {

        [TestMethod]
        public void SummaryTest()
        {
            //Creating instance of invoice generator 
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            Ride[] rides = { new Ride(2.0, 5), new Ride(0.1, 1) };
            RideRepository rideRepository = new RideRepository();
            string userId = "Dhiraj";
            rideRepository.AddRide(userId, rides);
            Ride[] rideData = rideRepository.GetRides(userId);
            //Generating Summary for rides
            InvoiceSummary summary = invoiceGenerator.CalculateFare(rides);
            InvoiceSummary expectedSummary = new InvoiceSummary(2, 30.0, 15);

            //Asserting values with average in equals to formula in invoice summary
            Assert.AreEqual(expectedSummary, summary);
        }
    }
}
