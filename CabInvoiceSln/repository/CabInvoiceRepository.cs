// <copyright file="CabInvoiceRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CabInvoiceSln.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;
    using CabInvoiceSln.Exception;
    using CabInvoiceSln.Model;

    /// <summary>
    /// Cab Invoice Repository class.
    /// </summary>
    public class CabInvoiceRepository
    {
        /// <summary>
        /// Email regex expression for email verification.
        /// </summary>
        private readonly Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

        /// <summary>
        /// Dictionary of list of rides along with userid as key.
        /// </summary>
        private readonly Dictionary<string, List<Ride>> userRides = new Dictionary<string, List<Ride>>();

        /// <summary>
        /// Add rides.
        /// </summary>
        /// <param name="userId">User Id.</param>
        /// <param name="ride">List of rides.</param>
        public void AddRides(string userId, Ride[] ride)
        {
            this.ValidUserId(userId);
            if (this.userRides.Keys.Any(key => key == userId))
            {
                this.userRides[userId].AddRange(new List<Ride>(ride));
            }

            this.userRides.Add(userId, new List<Ride>(ride));
        }

        /// <summary>
        /// Get ride list.
        /// </summary>
        /// <param name="userId">User Id.</param>
        /// <returns>List of rides.</returns>
        public Ride[] GetRides(string userId) => this.userRides.Keys.Any(key => key == userId) ? this.userRides[userId].ToArray()
                : throw new CabInvoiceException("No Such Rides", CabInvoiceException.ExceptionType.NO_RIDE_FOUND);

        /// <summary>
        /// Validating user.
        /// </summary>
        /// <param name="userId">User Id to validate.</param>
        private void ValidUserId(string userId)
        {
            if (userId == null)
            {
                throw new CabInvoiceException("Null User Id", CabInvoiceException.ExceptionType.NULL_USERID);
            }

            if (!this.regex.IsMatch(userId))
            {
                throw new CabInvoiceException("Invalid User Id", CabInvoiceException.ExceptionType.INVALID_USERID);
            }
        }
    }
}
