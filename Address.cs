using System;

namespace Foodies_api.Models
{
    public class Address 
    {
        public string StreetAddress {set; get;}
        public string State { set; get; } 
        public int Zipcode { set; get; }
    }
}