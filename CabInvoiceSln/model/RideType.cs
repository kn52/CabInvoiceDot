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
        /// Initializes a new instance of the <see cref="RideType"/> class.
        /// </summary>
        /// <param name="distancePerKm">Distance cost.</param>
        /// <param name="distancePerMinute">Time cost.</param>
        /// <param name="minimumFare">Minimum Fare.</param>
        private RideType(double distancePerKm, double distancePerMinute, double minimumFare)
        {
            this.FarePerKm = distancePerKm;
            this.FarePerMinute = distancePerMinute;
            this.MinimumFare = minimumFare;
        }

        /// <summary>
        /// Gets normal ride.
        /// </summary>
        public static RideType NORMAL { get; } = new RideType(10, 1, 5);

        /// <summary>
        /// Gets premium ride.
        /// </summary>
        public static RideType PREMIUM { get; } = new RideType(15, 2, 20);

        /// <summary>
        /// Gets fare per km.
        /// </summary>
        public double FarePerKm { get; }

        /// <summary>
        /// Gets fare per minute.
        /// </summary>
        public double FarePerMinute { get; }

        /// <summary>
        /// Gets minimum fare.
        /// </summary>
        public double MinimumFare { get; }
    }
}
