using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportes_Canas.Information
{
    public class WorkTripInformation
    {
        private int id;
        private string origin;
        private string cityOrigin;
        private string destination;
        private string cityDestination;
        private string description;
        private string client;
        private decimal price;
        private decimal MotoristPayment;

        public int Id { get => id; set => id = value; }
        public string CityOrigin { get => cityOrigin; set => cityOrigin = value; }
        public string Origin { get => origin; set => origin = value; }
        public string CityDestination { get => cityDestination; set => cityDestination = value; }
        public string Destination { get => destination; set => destination = value; }
        public string Description { get => description; set => description = value; }
        public string Client { get => client; set => client = value; }
        public decimal Price { get => price; set => price = value; }
        public decimal MotoristPayment1 { get => MotoristPayment; set => MotoristPayment = value; }   
    }
}
