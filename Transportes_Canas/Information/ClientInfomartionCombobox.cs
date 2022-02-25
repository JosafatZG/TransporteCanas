using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportes_Canas.Information
{
    public class ClientInfomartionCombobox
    {
        private int id;
        private string country;
        private string state;
        private string city;
        private string name;
        private string address;
        private string telephone;
        private string email;
        private string fullAddress;

        public int Id { get => id; set => id = value; }
        public string Country { get => country; set => country = value; }
        public string State { get => state; set => state = value; }
        public string City { get => city; set => city = value; }
        public string FullAddress { get => name + ". " + city + ", " + state + ", " + country + ". " + Address; set => fullAddress = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string Telephone { get => telephone; set => telephone = value; }
        public string Email { get => email; set => email = value; }
    }
}
