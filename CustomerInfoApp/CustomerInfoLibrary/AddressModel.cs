using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerInfoLibrary
{
    public class AddressModel
    {
        public string Street { get; set; }
        public string Suburb { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string FullAddress => $"{Street}, {Suburb}, {City}, {ZipCode}";
    }
}
