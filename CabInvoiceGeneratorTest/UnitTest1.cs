using CabInvoiceGenerator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CabInvoiceGenartorTest
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

    }
}