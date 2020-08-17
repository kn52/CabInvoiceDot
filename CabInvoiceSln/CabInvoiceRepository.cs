using System.Collections.Generic;
using System.Linq;

namespace CabInvoiceSln
{
    public class CabInvoiceRepository
    {
        readonly Dictionary<string, List<Ride>> UserRides = new Dictionary<string, List<Ride>>();

        public void AddRides(string userId, Ride[] ride)
        {
            if (!UserRides.ContainsKey(userId))
            {
                this.UserRides.Add(userId, new List<Ride>(ride));
            }
        }

        public Ride[] GetRides(string userId)
        {
            return UserRides[userId].ToArray();
        }
    }
}
