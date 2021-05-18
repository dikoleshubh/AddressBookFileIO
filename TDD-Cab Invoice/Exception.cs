﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Cab_Invoice
{
    public class CabInvoiceException : Exception
    {
        // Enum for defining different type of custom exception       
        public ExceptionType type;

        // Initializes a new instance of the class.

        public CabInvoiceException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
        public enum ExceptionType
        {
            INVALID_DISTANCE, INVALID_TIME, NULL_RIDES, INVALID_USER_ID
        }
    }
}
