// <copyright file="CabInvoiceService.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CabInvoiceSln
{
    using System;
    using System.Linq;
    using CabInvoiceSln.Exception;
    using CabInvoiceSln.Model;
    using CabInvoiceSln.Repository;

    /// <summary>
    /// Cab Invoice Service class.
    /// </summary>
    public class CabInvoiceService
    {
        private readonly CabInvoiceRepository cabInvoiceRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="CabInvoiceService"/> class.
        /// </summary>
        public CabInvoiceService()
        {
            this.cabInvoiceRepository = new CabInvoiceRepository();
        }

        /// <summary>
        /// Calculate total fare of a ride.
        /// </summary>
        /// <param name="distance">Distance travelled.</param>
        /// <param name="time">Time Taken to travel.</param>
        /// <param name="rideType">Type of ride.</param>
        /// <returns>Total fare of a ride.</returns>
        public double CalculateFare(double distance, double time, RideType rideType) => rideType == null
            ? throw new CabInvoiceException("Invalid Ride Type", CabInvoiceException.ExceptionType.INVALID_RYDE_TYPE)
            : Math.Max((distance * rideType.FarePerKm) + (time * rideType.FarePerMinute), rideType.MinimumFare);

        /// <summary>
        /// Calculate fare for multiple rides.
        /// </summary>
        /// <param name="rides">List of rides.</param>
        /// <returns>Summary of rides.</returns>
        public CabInvoiceSummary CalculateMultipleRideFare(Ride[] rides) => new CabInvoiceSummary(rides.Length, rides.ToList()
                .Sum(ride => this.CalculateFare(ride.Distance, ride.Time, ride.RideType)));

        /// <summary>
        /// Add R=rides to repository.
        /// </summary>
        /// <param name="userId">User id.</param>
        /// <param name="ride">List of rides.</param>
        public void AddRides(string userId, Ride[] ride) => this.cabInvoiceRepository.AddRides(userId, ride);

        /// <summary>
        /// Get Invoice Summary.
        /// </summary>
        /// <param name="userId">User Id.</param>
        /// <returns>Summary of rides.</returns>
        public CabInvoiceSummary GetInvoiceSummary(string userId) => this.CalculateMultipleRideFare(this.cabInvoiceRepository.GetRides(userId));
    }
}
