// <copyright file="RideType.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CabInvoiceSln.Model
{
    /// <summary>
    /// Ryde type class.
    /// </summary>
    public class RideType
    {
        /// <summary>
        /// Normal ride.
        /// </summary>
        private static readonly RideType NORMAL = new RideType(15, 2, 20);

        /// <summary>
        /// Premium ride.
        /// </summary>
        private static readonly RideType PREMIUM = new RideType(15, 2, 20);

        private readonly double distancePerKm;

        private readonly double distancePerMinute;

        private readonly double minimumFare;

        /// <summary>
        /// Initializes a new instance of the <see cref="RideType"/> class.
        /// </summary>
        /// <param name="distancePerKm">Distance cost.</param>
        /// <param name="distancePerMinute">Time cost.</param>
        /// <param name="minimumFare">Minimum Fare.</param>
        public RideType(double distancePerKm, double distancePerMinute, double minimumFare)
        {
            this.distancePerKm = distancePerKm;
            this.distancePerMinute = distancePerMinute;
            this.minimumFare = minimumFare;
        }
    }
}
