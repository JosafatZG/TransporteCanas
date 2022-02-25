using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportes_Canas.Information
{
    public class DestinationPlaceInformation
    {
        private int id;
        private String country;
        private String state;
        private String city;
        private String description;
        private String fullName;

        public int Id { get => id; set => id = value; }
        public string Country { get => country; set => country = value; }
        public string State { get => state; set => state = value; }
        public string City { get => city; set => city = value; }
        public string Description { get => description; set => description = value; }
        public string FullName { get => country + ", " + state + ", " + city + ", " + description; set => fullName = value; }
    }
}
