using System;

namespace CabInvoiceGenrator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Cab Invoice Generator");
            InvoiceGeneartor invoiceGeneartor = new InvoiceGeneartor(RideType.Normal);
            double fare = invoiceGeneartor.CalcaulateFare(2.0, 5);
            Console.WriteLine($"Fare : {fare}");

            Ride[] rides = { new Ride(5,2.0), new Ride(1,1.0) };
            invoiceGeneartor.AddRides("Aakash", rides);

            invoiceGeneartor.GetInvoiceSummary("Aakash");
        }
    }
}
