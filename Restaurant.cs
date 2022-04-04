using System;

namespace Foodies_api.Models
{
    public partial class Restaurant
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Latitude { get; set; }

        public decimal Longitude { get; set; }

        public int Rating { get; set; }

        public List<Address> Addresses { get; set; } = new List<Address>();
    }
}
