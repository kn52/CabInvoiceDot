// <copyright file="Ride.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CabInvoiceSln
{
    /// <summary>
    /// Ride class.
    /// </summary>
    public class Ride
    {
        /// <summary>
        /// Distance.
        /// </summary>
        public double Distance;

        /// <summary>
        /// Total time.
        /// </summary>
        public double Time;

        /// <summary>
        /// Ride.
        /// </summary>
        public string RideType;

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
    }
}
