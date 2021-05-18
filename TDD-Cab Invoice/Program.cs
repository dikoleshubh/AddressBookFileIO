﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Cab_Invoice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********Welcome to Cab Invoice Program***********");
            //Creating Object
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator((RideType.NORMAL));
            //Calculate Fare double
            double fare = invoiceGenerator.CalculateFare(2.0, 5);
            Console.WriteLine($"Fare: {fare}");

            Console.ReadLine();

        }

    }
}
