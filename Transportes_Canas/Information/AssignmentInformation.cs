using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportes_Canas.Information
{
    public class AssignmentInformation
    {
        private int id;
        private string driverName;
        private string clientName;
        private string workTrip;
        private string truck;
        private string truckBox;
        private DateTime startDate;
        private DateTime endDate;
        private string status;
        private string ticket;

        public int Id { get => id; set => id = value; }
        public string DriverName { get => driverName; set => driverName = value; }
        public string ClientName { get => clientName; set => clientName = value; }
        public string WorkTrip { get => workTrip; set => workTrip = value; }
        public string Truck { get => truck; set => truck = value; }
        public string TruckBox { get => truckBox; set => truckBox = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public DateTime EndDate { get => endDate; set => endDate = value; }
        public string Status { get => status; set => status = value; }
        public string Ticket { get => ticket; set => ticket = value; }
    }
}
