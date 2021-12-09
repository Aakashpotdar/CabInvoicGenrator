using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGenrator
{
    public class Ride
    {
        public int time;
        public double distance;
        public Ride(int time,double distance)
        {
            this.distance = distance;
            this.time = time;
        }
    }
}
