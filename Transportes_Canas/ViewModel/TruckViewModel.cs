using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportes_Canas.Information;

namespace Transportes_Canas.ViewModel
{
    public class TruckViewModel : INotifyPropertyChanged
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
        private string vehicleLicense;
        private int year;
        private int idVehicleStatus;
        private int idVehicleBrand;
        private int idVehicleModel;
        private List<VehicleStatu> truckStatus;
        private List<TruckInformation> listTruck;
        private List<VehicleBrand> listBrand;
        private List<VehicleModel> listModel;

        // Getter And Setter
        public int Id { get => id; set => id = value; }
        public string VehicleLicense { get => vehicleLicense; set => vehicleLicense = value; }
        public int Year { get => year; set => year = value; }
        public int IdVehicleStatus { get => idVehicleStatus; set => idVehicleStatus = value; }
        public List<VehicleStatu> TruckStatus { get => truckStatus; set => truckStatus = value; }
        public List<TruckInformation> ListTruck { get => listTruck; set => listTruck = value; }
        public List<VehicleBrand> ListBrand { get => listBrand; set => listBrand = value; }
        public List<VehicleModel> ListModel { get => listModel; set => listModel = value; }
        public int IdVehicleBrand { get => idVehicleBrand; set => idVehicleBrand = value; }
        public int IdVehicleModel { get => idVehicleModel; set => idVehicleModel = value; }


        // Entity context
        TransportesCanasEntities ctx = new TransportesCanasEntities();

        // Constructor 
        public TruckViewModel()
        {
            this.FillTruckStatus();
            this.FillTruckList();
            this.FillBrandList();
            this.id = -1;
            this.idVehicleBrand = 0;
            this.idVehicleModel = 0;
            this.FillModelListByBrand();
        }

        // Methods
        private void FillTruckStatus()
        {
            this.TruckStatus = ctx.VehicleStatus.ToList();
        }

        public void FillBrandList()
        {
            this.listBrand = ctx.VehicleBrands.ToList();
        }

        public void FillModelListByBrand()
        {
            this.listModel = ctx.VehicleModels.Where(d => d.IdVehicleBrand == this.idVehicleBrand).ToList(); ;
        }

        private void FillTruckList()
        {
            var t = (
                from truck in ctx.Trucks
                join status in ctx.VehicleStatus on truck.IdVehiceStatus equals status.Id
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

            this.listTruck = t;
        }

        private void ResetValues()
        {
            this.year = 1920;
            this.vehicleLicense = "";
            this.idVehicleStatus = 0;
            this.idVehicleBrand = 0;
            this.idVehicleModel = 0;
            this.id = -1;
        }

        public Boolean SaveTruck()
        {
            try
            {
                Truck truck = new Truck
                {
                    IdVehicleModel = this.idVehicleModel,
                    VehicleLicense = this.vehicleLicense,
                    Year = this.year,
                    IdVehiceStatus = this.idVehicleStatus
                };
                ctx.Trucks.Add(truck);

                if (ctx.SaveChanges() == 1)
                {
                    this.FillTruckList();
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

        public void GetTruck(int id)
        {
            var truck = ctx.Trucks.Where(d => d.Id == id).FirstOrDefault<Truck>();
            this.id = truck.Id;
            this.idVehicleModel = truck.IdVehicleModel;
            this.IdVehicleBrand = truck.VehicleModel.VehicleBrand.Id;
            this.vehicleLicense = truck.VehicleLicense;
            this.year = truck.Year;
            this.idVehicleStatus = truck.IdVehiceStatus;
            NotifyPropertyChanged();
        }

        public Boolean UpdateTruck()
        {
            try {
                var truck = ctx.Trucks.Where(d => d.Id == this.id).FirstOrDefault<Truck>();

                truck.Id = this.id;
                truck.IdVehicleModel = this.idVehicleModel;
                truck.VehicleLicense = this.vehicleLicense;
                truck.Year = this.year;
                truck.IdVehiceStatus = this.idVehicleStatus;

                if (ctx.SaveChanges() == 1)
                {
                    this.FillTruckList();
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

        public Boolean DeleteTruck()
        {
            try
            {
                var truck = ctx.Trucks.Where(d => d.Id == this.id).FirstOrDefault<Truck>();
                ctx.Trucks.Remove(truck);
                if (ctx.SaveChanges() == 1)
                {
                    this.FillTruckList();
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
