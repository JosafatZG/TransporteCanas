using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportes_Canas.Information
{
    public class ClientInformation
    {
        private int id;
        private string name;
        private string address;
        private string telephone;
        private string email;
        private string city;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string Telephone { get => telephone; set => telephone = value; }
        public string Email { get => email; set => email = value; }
        public string City { get => city; set => city = value; }
    }
}
