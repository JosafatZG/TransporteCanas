using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportes_Canas.Information
{
    public class VehicleModelInformation
    {
        private int id;
        private string name;
        private string brand;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Brand { get => brand; set => brand = value; }
    }
}
