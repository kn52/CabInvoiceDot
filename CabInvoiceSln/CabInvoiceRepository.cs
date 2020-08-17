using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceSln
{
    public class CabInvoiceRepository
    {
        Dictionary<string, List<Ride>> user = new Dictionary<string, List<Ride>>();

        public void addRides(String userId, Ride[] ride)
        {
            List<Ride> rides = this.user[userId];
            if (rides == null)
                user.Add(userId, new List<Ride>(ride));
        }

        public Ride[] GetRides(String userId)
        {
            return user[userId].ToArray();
        }
    }
}
