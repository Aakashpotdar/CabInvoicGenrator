using CabInvoiceGenrator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CabInvoicGenratorTesting
{
    [TestClass]
    public class UnitTest1
    {
        InvoiceGeneartor invoiceGeneartor = null;

        [TestMethod]
        public void GivenDistanceAndTimeShouldTotalFare()
        {
            invoiceGeneartor = new InvoiceGeneartor(RideType.Normal);
            double distance = 2.0;
            int time = 5;
            double fare = invoiceGeneartor.CalcaulateFare(distance, time);
            double expected = 25;

            Assert.AreEqual(expected, fare);

        }


        [TestMethod]
        public void GivenMultipleRidesShouldReturnInvoiceSummary()
        {
            invoiceGeneartor = new InvoiceGeneartor(RideType.Normal);
            Ride[] rides = { new Ride(5,2.0), new Ride(1,0.1) };

            InvoiceSummary summary = invoiceGeneartor.CalcaulateFare(rides);
            InvoiceSummary excpectedSummary = new InvoiceSummary(2, 30.0);

            Assert.AreEqual(excpectedSummary, summary);
        }
        [TestMethod]
        public void EnhancedInvoice()
        {
            invoiceGeneartor = new InvoiceGeneartor(RideType.Normal);
            Ride[] rides = { new Ride(5, 2.0), new Ride(1, 0.1),new Ride(4,2.4) };
            InvoiceSummary summary1 = invoiceGeneartor.CalcaulateFare(rides);
            InvoiceSummary summary2 = invoiceGeneartor.GetInvoiceSummary("aakash");
            InvoiceSummary excpectedSummary = new InvoiceSummary(2, 30.0);

            Assert.AreEqual(excpectedSummary, summary2);
        }
    }
}
