using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportes_Canas.Information;

namespace Transportes_Canas.ViewModel
{
    public class AssignmentViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName = "")
        {
            if (this.PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        // Properties
        private int id;
        private int idWorkTrip;
        private int idDriver;
        private int idClient;
        private int idAssignmentStatus;
        private string ticketNumber;
        private int idTruck;
        private int idTruckBox;
        private DateTime startDate;
        private DateTime endDate;
        private DateTime startSearchDate;
        private DateTime endSearchDate;

        private List<ClientInfomartionCombobox> clientList;
        private List<WorkTripInformation> workTripList;
        private List<TruckInformation> truckList;
        private List<TruckBoxInformation> truckBoxList;
        private List<AssignmentStatu> assigmentStatusList;
        private List<DriverInformationCombobox> driverList;
        private List<AssignmentInformation> assignmentList;

        // Getter and Setters
        public int Id { get => id; set => id = value; }
        public int IdWorkTrip { get => idWorkTrip; set => idWorkTrip = value; }
        public int IdDriver { get => idDriver; set => idDriver = value; }
        public int IdAssignmentStatus { get => idAssignmentStatus; set => idAssignmentStatus = value; }
        public string TicketNumber { get => ticketNumber; set => ticketNumber = value; }
        public int IdTruck { get => idTruck; set => idTruck = value; }
        public int IdTruckBox { get => idTruckBox; set => idTruckBox = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public DateTime EndDate { get => endDate; set => endDate = value; }
        public List<ClientInfomartionCombobox> ClientList { get => clientList; set => clientList = value; }
        public List<WorkTripInformation> WorkTripList { get => workTripList; set => workTripList = value; }
        public List<TruckInformation> TruckList { get => truckList; set => truckList = value; }
        public List<TruckBoxInformation> TruckBoxList { get => truckBoxList; set => truckBoxList = value; }
        public List<AssignmentStatu> AssigmentStatusList { get => assigmentStatusList; set => assigmentStatusList = value; }
        public List<DriverInformationCombobox> DriverList { get => driverList; set => driverList = value; }
        public List<AssignmentInformation> AssignmentList { get => assignmentList; set => assignmentList = value; }
        public int IdClient { get => idClient; set => idClient = value; }
        public DateTime StartSearchDate { get => startSearchDate; set => startSearchDate = value; }
        public DateTime EndSearchDate { get => endSearchDate; set => endSearchDate = value; }

        // Entity context
        TransportesCanasEntities ctx = new TransportesCanasEntities();

        // Constructor  
        public AssignmentViewModel()
        {
            this.startSearchDate = DateTime.Now.AddDays(-7);
            this.endSearchDate = DateTime.Now.AddDays(1);
            this.FillClientList();
            this.FillTruckList();
            this.FillTruckBoxList();
            this.FillAssignmentStatusList();
            this.FillDrivertList();
            this.FillWorkTripByClientId();
            this.FillAssignmentList();

            this.id = -1;
            this.idWorkTrip = 0;
            this.idDriver = 0;
            this.idAssignmentStatus = 0;
            this.ticketNumber = "";
            this.idTruck = 0;
            this.idTruckBox = 0;
            this.startDate = DateTime.Now;
            this.endDate = DateTime.Now;
        }

        // Methods
        private void ResetValues()
        {
            this.FillClientList();
            this.FillTruckList();
            this.FillTruckBoxList();
            this.FillAssignmentStatusList();
            this.FillDrivertList();
            this.FillWorkTripByClientId();
            this.FillAssignmentList();

            this.id = -1;
            this.idWorkTrip = 0;
            this.idDriver = 0;
            this.idAssignmentStatus = 0;
            this.ticketNumber = "";
            this.idTruck = 0;
            this.idTruckBox = 0;
            this.startDate = DateTime.Now;
            this.endDate = DateTime.Now;
        }

        private void FillClientList()
        {
            var t = (
                from client in ctx.Clients
                select new ClientInfomartionCombobox
                {
                    Id = client.Id,
                    Name = client.Name,
                    Address = client.Address,
                    Telephone = client.Telephone,
                    Email = client.Email,
                    City = client.City.Name,
                    State = client.City.State.Name,
                    Country = client.City.State.Country.Name
                }
            ).ToList();

            this.clientList = t;
        }

        public void FillAssignmentList()
        {

            var t = (
                from assignment in ctx.Assignments
                where (assignment.StartDate >= this.startSearchDate && assignment.EndDate <= this.endSearchDate)
                select new AssignmentInformation
                {
                    Id = assignment.Id,
                    DriverName = assignment.Driver.LastName + ", " + assignment.Driver.Name + " (" + assignment.Driver.Dui + ")",
                    Truck = assignment.Truck.VehicleLicense,
                    TruckBox = assignment.TruckBox.VehicleLicense,
                    ClientName = assignment.WorkTrip.Client.Name,
                    StartDate = assignment.StartDate,
                    EndDate = assignment.EndDate,
                    Status = assignment.AssignmentStatu.Description,
                    WorkTrip = assignment.WorkTrip.Description,
                    Ticket = assignment.TicketNumber
                }
            ).ToList();

            this.AssignmentList = t;

        }

        private void FillDrivertList()
        {
            var d = (
                from driver in ctx.Drivers
                join status in ctx.DriverStatus on driver.IdDriverStatus equals status.Id
                where status.Id == 1
                select new DriverInformationCombobox
                {
                    Id = driver.Id,
                    Name = driver.Name,
                    LastName = driver.LastName,
                    Dui = driver.Dui
                }
            ).ToList();
            
            this.driverList = d;
        }

        public void FillWorkTripByClientId()
        {
            var d = (
                from w in ctx.WorkTrips
                where w.IdClient == this.idClient
                select new WorkTripInformation
                {
                    Id = w.Id,
                    // w.DestinationPlace.City.State.Country.Name + ", " + w.DestinationPlace.City.State.Name + ", " + w.DestinationPlace.City.Name + ", " +
                    Destination = w.DestinationPlace.Description.ToString(),
                    // w.OriginPlace.City.State.Country.Name + ", " + w.OriginPlace.City.State.Name + ", " + w.OriginPlace.City.Name + ", " +
                    Origin = w.OriginPlace.Description,
                    Client = w.Client.Name,
                    Price = w.Price,
                    MotoristPayment1 = w.MotoristPayment,
                    Description = w.Description,
                }
            ).ToList();

            this.workTripList = d;
        }

        private void FillTruckList()
        {
            var t = (
                from truck in ctx.Trucks
                join status in ctx.VehicleStatus on truck.IdVehiceStatus equals status.Id
                where status.Id == 1
                select new TruckInformation
                {
                    Id = truck.Id,
                    Model = truck.VehicleModel.Name,
                    Brand = truck.VehicleModel.VehicleBrand.Name,
                    License = truck.VehicleLicense,
                    Year = truck.Year,
                    Status = status.Description
                }
            ).ToList();

            this.truckList = t;
        }

        private void FillTruckBoxList()
        {
            var t = (
                from truck in ctx.TruckBoxes
                join type in ctx.VehicleTypes on truck.IdVehicleType equals type.Id
                join status in ctx.VehicleStatus on truck.IdVehiceStatus equals status.Id
                where status.Id == 1
                select new TruckBoxInformation
                {
                    Id = truck.Id,
                    Model = truck.VehicleModel.Name,
                    Brand = truck.VehicleModel.VehicleBrand.Name,
                    License = truck.VehicleLicense,
                    Year = truck.Year,
                    Status = status.Description,
                    Type = type.Description
                }
            ).ToList();

            this.TruckBoxList = t;
        }

        private void FillAssignmentStatusList()
        {
            this.assigmentStatusList = ctx.AssignmentStatus.ToList();
        }

        public Boolean SaveAssignment()
        {
            Assignment assignment = new Assignment
            {
                IdWorkTrip = this.idWorkTrip,
                IdDriver = this.idDriver,
                IdAssignmentStatus = this.idAssignmentStatus,
                TicketNumber = this.ticketNumber,
                IdTruck = this.idTruck,
                IdTruckBox = this.idTruckBox,
                StartDate = this.startDate,
                EndDate = this.endDate
            };
            ctx.Assignments.Add(assignment);

            if (ctx.SaveChanges() == 1)
            {
                this.ResetValues();
                NotifyPropertyChanged();
                return true;
            }
            return false;
        }

        public Boolean AssignmentActivedByTruckAndTruckBox()
        {
            var assignment = ctx.Assignments.Where(a => ((a.IdTruck == this.idTruck  || a.IdTruckBox == this.idTruckBox) && a.AssignmentStatu.Id == 1) ).FirstOrDefault<Assignment>();
            return assignment == null;
        }

        public Boolean AssignmentActivedByTruckAndTruckBoxUpdate()
        {
            var assignment = ctx.Assignments.Where(a => ((a.IdTruck == this.idTruck || a.IdTruckBox == this.idTruckBox) && a.AssignmentStatu.Id == 1 && a.Id != this.id)).FirstOrDefault<Assignment>();
            return assignment == null;
        }
        public void GetAssignment(int id)
        {
            var assignment = ctx.Assignments.Where(d => d.Id == id).FirstOrDefault<Assignment>();
            this.id = assignment.Id;
            this.idClient = assignment.WorkTrip.Client.Id;
            this.idWorkTrip = assignment.IdWorkTrip;
            this.idDriver = assignment.IdDriver;
            this.idAssignmentStatus = assignment.IdAssignmentStatus;
            this.ticketNumber = assignment.TicketNumber;
            this.idTruck = assignment.IdTruck;
            this.idTruckBox = assignment.IdTruckBox;
            this.startDate = assignment.StartDate;
            this.endDate = assignment.EndDate;
            NotifyPropertyChanged();
        }

        public Boolean UpdateAssignment()
        {
            var assignment = ctx.Assignments.Where(d => d.Id == id).FirstOrDefault<Assignment>();

            assignment.IdWorkTrip = this.idWorkTrip;
            assignment.IdDriver = this.idDriver;
            assignment.IdAssignmentStatus = this.idAssignmentStatus;
            assignment.TicketNumber = this.ticketNumber;
            assignment.IdTruck = this.idTruck;
            assignment.IdTruckBox = this.idTruckBox;
            assignment.StartDate = this.startDate;
            assignment.EndDate = this.endDate;

            if (ctx.SaveChanges() == 1)
            {
                this.ResetValues();
                NotifyPropertyChanged();
                return true;
            }
            return false;
        }

        public Boolean DeleteAssignment()
        {
            try
            {
                var assignment = ctx.Assignments.Where(d => d.Id == id).FirstOrDefault<Assignment>();
                ctx.Assignments.Remove(assignment);
                if (ctx.SaveChanges() == 1)
                {
                    this.ResetValues();
                    NotifyPropertyChanged();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public void GetAssignmentInProgress()
        {
            var t = (
                from assignment in ctx.Assignments
                where assignment.IdAssignmentStatus == 1 && (assignment.StartDate >= this.startSearchDate && assignment.EndDate <= this.endSearchDate)
                select new AssignmentInformation
                {
                    Id = assignment.Id,
                    DriverName = assignment.Driver.LastName + ", " + assignment.Driver.Name + " (" + assignment.Driver.Dui + ")",
                    Truck = assignment.Truck.VehicleLicense,
                    TruckBox = assignment.TruckBox.VehicleLicense,
                    ClientName = assignment.WorkTrip.Client.Name,
                    StartDate = assignment.StartDate,
                    EndDate = assignment.EndDate,
                    Status = assignment.AssignmentStatu.Description,
                    WorkTrip = assignment.WorkTrip.Description,
                    Ticket = assignment.TicketNumber
                }
            ).ToList();

            this.AssignmentList = t;
            NotifyPropertyChanged();
        }

        public void GetAssignmentDone()
        {
            var t = (
                from assignment in ctx.Assignments
                where assignment.IdAssignmentStatus == 2 && (assignment.StartDate >= this.startSearchDate && assignment.EndDate <= this.endSearchDate)
                select new AssignmentInformation
                {
                    Id = assignment.Id,
                    DriverName = assignment.Driver.LastName + ", " + assignment.Driver.Name + " (" + assignment.Driver.Dui + ")",
                    Truck = assignment.Truck.VehicleLicense,
                    TruckBox = assignment.TruckBox.VehicleLicense,
                    ClientName = assignment.WorkTrip.Client.Name,
                    StartDate = assignment.StartDate,
                    EndDate = assignment.EndDate,
                    Status = assignment.AssignmentStatu.Description,
                    WorkTrip = assignment.WorkTrip.Description,
                    Ticket = assignment.TicketNumber
                }
            ).ToList();

            this.AssignmentList = t;
            NotifyPropertyChanged();
        }

        public void GetAssignmentPaid()
        {
            var t = (
                from assignment in ctx.Assignments
                where assignment.IdAssignmentStatus == 3 && (assignment.StartDate >= this.startSearchDate && assignment.EndDate <= this.endSearchDate)
                select new AssignmentInformation
                {
                    Id = assignment.Id,
                    DriverName = assignment.Driver.LastName + ", " + assignment.Driver.Name + " (" + assignment.Driver.Dui + ")",
                    Truck = assignment.Truck.VehicleLicense,
                    TruckBox = assignment.TruckBox.VehicleLicense,
                    ClientName = assignment.WorkTrip.Client.Name,
                    StartDate = assignment.StartDate,
                    EndDate = assignment.EndDate,
                    Status = assignment.AssignmentStatu.Description,
                    WorkTrip = assignment.WorkTrip.Description,
                    Ticket = assignment.TicketNumber
                }
            ).ToList();

            this.AssignmentList = t;
            NotifyPropertyChanged();
        }

        public void FillAssignmentAllList()
        {

            var t = (
                from assignment in ctx.Assignments
                where assignment.StartDate >= this.startSearchDate && assignment.EndDate <= this.endSearchDate
                select new AssignmentInformation
                {
                    Id = assignment.Id,
                    DriverName = assignment.Driver.LastName + ", " + assignment.Driver.Name + " (" + assignment.Driver.Dui + ")",
                    Truck = assignment.Truck.VehicleLicense,
                    TruckBox = assignment.TruckBox.VehicleLicense,
                    ClientName = assignment.WorkTrip.Client.Name,
                    StartDate = assignment.StartDate,
                    EndDate = assignment.EndDate,
                    Status = assignment.AssignmentStatu.Description,
                    WorkTrip = assignment.WorkTrip.Description,
                    Ticket = assignment.TicketNumber
                }
            ).ToList();

            this.AssignmentList = t;
            NotifyPropertyChanged();
        }
    }
}
