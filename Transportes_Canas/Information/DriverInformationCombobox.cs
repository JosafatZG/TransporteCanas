using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportes_Canas.Information
{
    public class DriverInformationCombobox
    {
        private int id;
        private String name;
        private String lastName;
        private String dui;
        private String nameInCombobox;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Dui { get => dui; set => dui = value; }
        public string NameInCombobox { get => lastName + ", " + name + "(" + dui + ")"; set => nameInCombobox = value; }
    }
}
