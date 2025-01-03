using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio_Chen.Core.Classes
{
    public class Address
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int StreetNumber { get; set; }
        //public Address(string city, string street, int streetNumber)
        //{
        //    City = city;
        //    Street = street;
        //    StreetNumber = streetNumber;
        //}
    }
}
