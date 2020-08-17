using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceSln
{
    public class Ride
    {
        public double Distance;
        public double Time;
        public string RideType;

        public Ride(double distance, double time, string rideType)
        {
            Distance = distance;
            Time = time;
            RideType = rideType;
        }
    }
}
