// <copyright file="CabInvoiceRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CabInvoiceSln
{
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Cab Invoice Repository class.
    /// </summary>
    public class CabInvoiceRepository
    {
        private readonly Dictionary<string, List<Ride>> userRides = new Dictionary<string, List<Ride>>();

        /// <summary>
        /// Add rides.
        /// </summary>
        /// <param name="userId">User Id.</param>
        /// <param name="ride">List of rides.</param>
        public void AddRides(string userId, Ride[] ride)
        {
            if (!this.userRides.ContainsKey(userId))
            {
                this.userRides.Add(userId, new List<Ride>(ride));
            }
        }

        /// <summary>
        /// Get ride list.
        /// </summary>
        /// <param name="userId">User Id.</param>
        /// <returns>List of rides.</returns>
        public Ride[] GetRides(string userId)
        {
            return this.userRides[userId].ToArray();
        }
    }
}
