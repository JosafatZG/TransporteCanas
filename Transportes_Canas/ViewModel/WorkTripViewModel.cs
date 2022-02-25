using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportes_Canas.Information;

namespace Transportes_Canas.ViewModel
{
    public class WorkTripViewModel : INotifyPropertyChanged
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
        private int idClient;
        private int idDestination;
        private int idOrigin;
        private string price;
        private string driverPayment;
        private string description;
        private List<DestinationPlaceInformation> destinationPlaceList;
        private List<DestinationPlaceInformation> originPlaceList;
        private List<ClientInfomartionCombobox> clientList;
        private List<WorkTripInformation> workTripList;

        // Getter And Setter
        public int Id { get => id; set => id = value; }
        public int IdClient { get => idClient; set => idClient = value; }
        public int IdDestination { get => idDestination; set => idDestination = value; }
        public int IdOrigin { get => idOrigin; set => idOrigin = value; }
        public string Price { get => price; set => price = value; }
        public string DriverPayment { get => driverPayment; set => driverPayment = value; }
        public string Description { get => description; set => description = value; }
        public List<DestinationPlaceInformation> DestinationPlaceList { get => destinationPlaceList; set => destinationPlaceList = value; }
        public List<DestinationPlaceInformation> OriginPlaceList { get => originPlaceList; set => originPlaceList = value; }
        public List<ClientInfomartionCombobox> ClientList { get => clientList; set => clientList = value; }
        public List<WorkTripInformation> WorkTripList { get => workTripList; set => workTripList = value; }

        // Entity context
        TransportesCanasEntities ctx = new TransportesCanasEntities();

        // Constructor 
        public WorkTripViewModel()
        {
            this.FillWorkTripList();
            this.FillClientList();
            this.FillDestinationPlaceList();
            this.FillOriginPlaceList();
            this.id = -1;
            this.idClient = 0;
            this.idDestination = 0;
            this.idOrigin = 0;
            this.price = "0.00";
            this.driverPayment = "0.00";
            this.description = "";
        }

        // Methods

        private void ResetValues()
        {
            this.FillWorkTripList();
            this.FillClientList();
            this.FillDestinationPlaceList();
            this.FillOriginPlaceList();
            this.id = -1;
            this.idClient = 0;
            this.idDestination = 0;
            this.idOrigin = 0;
            this.price = "0.00";
            this.driverPayment = "0.00";
            this.description = "";
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

        private void FillWorkTripList()
        {
          
            var t = (
                from w in ctx.WorkTrips
                select new WorkTripInformation
                {
                    Id = w.Id,
                    CityOrigin = w.OriginPlace.City.State.Country.Name + ", " + w.OriginPlace.City.State.Name + ", " + w.OriginPlace.City.Name,
                    CityDestination = w.DestinationPlace.City.State.Country.Name + ", " + w.DestinationPlace.City.State.Name + ", " + w.DestinationPlace.City.Name,
                    Destination = w.DestinationPlace.Description.ToString(),
                    Origin =  w.OriginPlace.Description,
                    Client = w.Client.Name,
                    Price = w.Price,
                    MotoristPayment1 = w.MotoristPayment,
                    Description = w.Description
                }
            ).ToList();

            this.workTripList = t;
        }

        private object nvarchar(int v)
        {
            throw new NotImplementedException();
        }

        private void FillDestinationPlaceList()
        {

            var d = (
                from destination in ctx.DestinationPlaces
                select new DestinationPlaceInformation
                {
                    Id = destination.Id,
                    Country = destination.City.State.Country.Name,
                    State = destination.City.State.Name,
                    City = destination.City.Name,
                    Description = destination.Description
                }
            ).ToList();

            this.destinationPlaceList = d;
        }

        private void FillOriginPlaceList()
        {
            var d = (
                from destination in ctx.OriginPlaces
                select new DestinationPlaceInformation
                {
                    Id = destination.Id,
                    Country = destination.City.State.Country.Name,
                    State = destination.City.State.Name,
                    City = destination.City.Name,
                    Description = destination.Description
                }
            ).ToList();

            this.originPlaceList = d;
        }

        public Boolean SaveWorkTrip()
        {
            try
            {
                WorkTrip w = new WorkTrip
                {
                    IdClient = this.idClient,
                    IdDestination = this.idDestination,
                    IdOrigin = this.idOrigin,
                    Description = this.description,
                    Price = Decimal.Parse(this.price.ToString()),
                    MotoristPayment = Decimal.Parse(this.driverPayment.ToString())
                };
                ctx.WorkTrips.Add(w);

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

        public void GetWorkTrip(int id)
        {
            var workTrip = ctx.WorkTrips.Where(d => d.Id == id).FirstOrDefault<WorkTrip>();
            this.id = workTrip.Id;
            this.idClient = workTrip.IdClient;
            this.idDestination = workTrip.IdDestination;
            this.idOrigin = workTrip.IdOrigin;
            this.description = workTrip.Description;
            this.driverPayment = workTrip.MotoristPayment.ToString();
            this.price = workTrip.Price.ToString();

            NotifyPropertyChanged();
        }

        public Boolean UpdateWorkTrip()
        {
            try
            {
                var workTrip = ctx.WorkTrips.Where(d => d.Id == this.id).FirstOrDefault<WorkTrip>();

                workTrip.Id = this.id;
                workTrip.IdClient = this.idClient;
                workTrip.IdDestination = this.idDestination;
                workTrip.IdOrigin = this.idOrigin;
                workTrip.Description = this.description;
                workTrip.Price = Decimal.Parse(this.price.ToString());
                workTrip.MotoristPayment = Decimal.Parse(this.driverPayment.ToString());

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

        public Boolean DeleteWorkTrip()
        {
            try
            {
                var workTrip = ctx.WorkTrips.Where(d => d.Id == this.id).FirstOrDefault<WorkTrip>();
                ctx.WorkTrips.Remove(workTrip);
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
    }
}
