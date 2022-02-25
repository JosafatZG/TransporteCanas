using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportes_Canas.Information
{
    public class DriverInformation
    {
        private int id;
        private String name;
        private String lastName;
        private String dui;
        private String license;
        private String telephone;
        private String passport;
        private String status;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Dui { get => dui; set => dui = value; }
        public string License { get => license; set => license = value; }
        public string Telephone { get => telephone; set => telephone = value; }
        public string Passport { get => passport; set => passport = value; }
        public string Status { get => status; set => status = value; }
    }
}
