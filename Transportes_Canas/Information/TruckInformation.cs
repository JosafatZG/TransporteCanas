using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportes_Canas.Information
{
    public class TruckInformation
    {
        private int id;
        private string license;
        private string brand;
        private string model;
        private int year;
        private string status;

        public int Id { get => id; set => id = value; }
        public string License { get => license; set => license = value; }
        public string Brand { get => brand; set => brand = value; }
        public string Model { get => model; set => model = value; }
        public int Year { get => year; set => year = value; }
        public string Status { get => status; set => status = value; }
    }
}
