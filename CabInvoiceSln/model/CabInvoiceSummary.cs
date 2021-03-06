﻿// <copyright file="CabInvoiceSummary.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CabInvoiceSln.Model
{
    /// <summary>
    /// Cab Invoice Summary class.
    /// </summary>
    public class CabInvoiceSummary
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CabInvoiceSummary"/> class.
        /// </summary>
        /// <param name="numberOfRides">Number of rides.</param>
        /// <param name="totalFare">Total fare.</param>
        public CabInvoiceSummary(double numberOfRides, double totalFare)
        {
            this.NumberOfRides = numberOfRides;
            this.TotalFare = totalFare;
            this.AverageFare = totalFare / numberOfRides;
        }

        /// <summary>
        /// Gets average fare.
        /// </summary>
        public double AverageFare { get; }

        /// <summary>
        /// Gets no of rides.
        /// </summary>
        public double NumberOfRides { get; }

        /// <summary>
        /// Gets total fare.
        /// </summary>
        public double TotalFare { get; }

        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="obj">Object to compare.</param>
        /// <returns>Boolean true or false.</returns>
        public override bool Equals(object obj)
        {
            CabInvoiceSummary summary = obj as CabInvoiceSummary;
            return (obj as CabInvoiceSummary) != null &&
                   this.AverageFare == summary.AverageFare &&
                   this.NumberOfRides == summary.NumberOfRides &&
                   this.TotalFare == summary.TotalFare;
        }

        /// <summary>
        /// Get Hash Code.
        /// </summary>
        /// <returns>Hash code.</returns>
        public override int GetHashCode()
        {
            return 0;
        }
    }
}
