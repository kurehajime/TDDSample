﻿using System.Collections.Generic;

namespace TDDSample.Rentals
{
    public sealed class Customer
    {
        private List<Rental> _rentals = new List<Rental>();

        public string Name { get; private set; }

        public Customer(string name)
        {
            Name = name;
        }

        public void AddRental(Rental rental)
        {
            _rentals.Add(rental);
        }

        public string Statement()
        {
            var total = 0;
            foreach (var r in _rentals)
            {
                total += r.CalcFee();
            }
            return $"{total} 円";
        }
    }
}