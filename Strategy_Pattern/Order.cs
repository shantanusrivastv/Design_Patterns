using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    public class Order
    {
        public enum ShippingOptions
        {
            UPS = 100,
            FedEx = 200,
            USPS = 300,
        };

        public ShippingOptions ShippingMethod { get; set; }

        public Address Destination { get; set; }
        public Address Origin { get; set; }
    }

    public class Address
    {
        public string ContactName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }

        public string PostalCode { get; set; }
    }

}
