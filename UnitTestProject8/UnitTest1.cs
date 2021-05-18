using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TDD_Cab_Invoice;

namespace UnitTestProject8
{
    [TestClass]
    /// <summary>
    /// Adding class to do tests for program
    /// </summary>
    public class Tests
    {
        /// <summary>
        /// Test Case UC-5 to Calculate Fare for Primium Ride type
        /// </summary>
        [TestMethod]
        public void GivenRides_WhenPremiumAndNormal_ShouldSupportBoth()
        {
            //Creating instance of invoice generator 
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator(RideType.PREMIUM);
            double distance = 3.0;
            int time = 20;

            double fare = invoiceGenerator.CalculateFare(distance, time);
            double expected = 85;

            //Asserting Values
            Assert.AreEqual(expected, fare);
        }
    }
}
