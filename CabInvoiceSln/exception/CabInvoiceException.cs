// <copyright file="CabInvoiceException.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CabInvoiceSln.Exception
{
    using System;

    /// <summary>
    /// Cab Invoice Exception.
    /// </summary>
    public class CabInvoiceException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CabInvoiceException"/> class.
        /// </summary>
        /// <param name="message">Custom message.</param>
        /// <param name="exceptionType">Exception type.</param>
        public CabInvoiceException(string message, ExceptionType exceptionType)
            : base(string.Format(message))
        {
            this.TypeException = exceptionType;
        }

        /// <summary>
        /// Exception Type.
        /// </summary>
        public enum ExceptionType
        {
            /// <summary>
            /// Invalid ride type.
            /// </summary>
            INVALID_RYDE_TYPE,

            /// <summary>
            /// Invalid user id.
            /// </summary>
            INVALID_USERID,

            /// <summary>
            /// Invalid rides found.
            /// </summary>
            NO_RIDE_FOUND,
        }

        /// <summary>
        /// Gets type exception.
        /// </summary>
        public ExceptionType TypeException { get; }
    }
}
