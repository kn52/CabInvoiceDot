// <copyright file="Ride.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CabInvoiceSln.Model
{
    /// <summary>
    /// Ride class.
    /// </summary>
    public class Ride
    {
        /// <summary>
        /// Distance.
        /// </summary>
        private readonly double distance;

        /// <summary>
        /// Total time.
        /// </summary>
        private readonly double time;

        /// <summary>
        /// Ride.
        /// </summary>
        private readonly string rideType;

        /// <summary>
        /// Initializes a new instance of the <see cref="Ride"/> class.
        /// </summary>
        /// <param name="distance">Distance travelled.</param>
        /// <param name="time">Total time taken to travel.</param>
        /// <param name="rideType">Ride type.</param>
        public Ride(double distance, double time, string rideType)
        {
            this.Distance = distance;
            this.Time = time;
            this.RideType = rideType;
        }

        /// <summary>
        /// Gets distance travel.
        /// </summary>
        public double Distance { get; }

        /// <summary>
        /// Gets time taken.
        /// </summary>
        public double Time { get; }

        /// <summary>
        /// Gets type of ride.
        /// </summary>
        public string RideType { get; }
    }
}
