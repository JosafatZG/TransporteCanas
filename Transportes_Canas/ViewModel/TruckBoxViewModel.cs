using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportes_Canas.Information;

namespace Transportes_Canas.ViewModel
{
    public class TruckBoxViewModel : INotifyPropertyChanged
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
        private int idVehicleType;
        private int idVehicleBrand;
        private int idVehicleModel;
        private List<VehicleStatu> truckSBoxtatus;
        private List<VehicleType> truckBoxType;
        private List<TruckBoxInformation> listTruck;
        private List<VehicleBrand> listBrand;
        private List<VehicleModel> listModel;

        // Getters And Setters
        public int Id { get => id; set => id = value; }
        public string VehicleLicense { get => vehicleLicense; set => vehicleLicense = value; }
        public int Year { get => year; set => year = value; }
        public int IdVehicleStatus { get => idVehicleStatus; set => idVehicleStatus = value; }
        public int IdVehicleType { get => idVehicleType; set => idVehicleType = value; }
        public List<VehicleStatu> TruckSBoxtatus { get => truckSBoxtatus; set => truckSBoxtatus = value; }
        public List<VehicleType> TruckBoxType { get => truckBoxType; set => truckBoxType = value; }
        public List<TruckBoxInformation> ListTruck { get => listTruck; set => listTruck = value; }
        public int IdVehicleModel { get => idVehicleModel; set => idVehicleModel = value; }
        public int IdVehicleBrand { get => idVehicleBrand; set => idVehicleBrand = value; }
        public List<VehicleBrand> ListBrand { get => listBrand; set => listBrand = value; }
        public List<VehicleModel> ListModel { get => listModel; set => listModel = value; }

        // Entity context
        TransportesCanasEntities ctx = new TransportesCanasEntities();

        // Constructor
        public TruckBoxViewModel()
        {
            this.FillTruckStatus();
            this.FillTruckBoxType();
            this.FillTruckBoxList();
            this.FillBrandList();
            this.id = -1;
            this.idVehicleBrand = 0;
            this.idVehicleModel = 0;
            this.idVehicleStatus = 0;
            this.idVehicleType = 0;
            this.FillModelListByBrand();
        }

        // Methods
        private void FillTruckStatus()
        {
            this.truckSBoxtatus = ctx.VehicleStatus.ToList();
        }

        private void FillTruckBoxType()
        {
            this.truckBoxType = ctx.VehicleTypes.ToList();
        }

        public void FillBrandList()
        {
            this.listBrand = ctx.VehicleBrands.ToList();
        }

        public void FillModelListByBrand()
        {
            this.listModel = ctx.VehicleModels.Where(d => d.IdVehicleBrand == this.idVehicleBrand).ToList(); ;
        }

        private void FillTruckBoxList()
        {
            var t = (
                from truck in ctx.TruckBoxes
                join type in ctx.VehicleTypes on truck.IdVehicleType equals type.Id
                join status in ctx.VehicleStatus on truck.IdVehiceStatus equals status.Id
                select new TruckBoxInformation
                {
                    Id = truck.Id,
                    Brand = truck.VehicleModel.VehicleBrand.Name,
                    Model = truck.VehicleModel.Name,
                    License = truck.VehicleLicense,
                    Year = truck.Year,
                    Status = status.Description,
                    Type = type.Description
                }
            ).ToList();

            this.listTruck = t;
        }

        private void ResetValues()
        {
            this.year = 1920;
            this.vehicleLicense = "";
            this.idVehicleStatus = 0;
            this.idVehicleType = 0;
            this.id = -1;
            this.idVehicleBrand = 0;
            this.idVehicleModel = 0;
        }

        public Boolean SaveTruckBox()
        {
            try
            {
                TruckBox truck = new TruckBox
                {
                    IdVehicleModel = this.idVehicleModel,
                    VehicleLicense = this.vehicleLicense,
                    Year = this.year,
                    IdVehiceStatus = this.idVehicleStatus,
                    IdVehicleType = this.idVehicleType
                };
                ctx.TruckBoxes.Add(truck);

                if (ctx.SaveChanges() == 1)
                {
                    this.FillTruckBoxList();
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

        public void GetTruckBox(int id)
        {
            var truck = ctx.TruckBoxes.Where(d => d.Id == id).FirstOrDefault<TruckBox>();
            this.id = truck.Id;
            this.idVehicleModel = truck.IdVehicleModel;
            this.idVehicleBrand = truck.VehicleModel.VehicleBrand.Id;
            this.vehicleLicense = truck.VehicleLicense;
            this.year = truck.Year;
            this.idVehicleStatus = truck.IdVehiceStatus;
            this.idVehicleType = truck.IdVehicleType;

            NotifyPropertyChanged();
        }

        public Boolean UpdateTruckBox()
        {
            try
            {
                var truck = ctx.TruckBoxes.Where(d => d.Id == this.id).FirstOrDefault<TruckBox>();

                truck.Id = this.id;
                truck.IdVehicleModel = this.idVehicleModel;
                truck.VehicleLicense = this.vehicleLicense;
                truck.Year = this.year;
                truck.IdVehiceStatus = this.idVehicleStatus;
                truck.IdVehicleType = this.idVehicleType;

                if (ctx.SaveChanges() == 1)
                {
                    this.FillTruckBoxList();
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

        public Boolean DeleteTruckBox()
        {
            try
            {
                var truck = ctx.TruckBoxes.Where(d => d.Id == this.id).FirstOrDefault<TruckBox>();
                ctx.TruckBoxes.Remove(truck);
                if (ctx.SaveChanges() == 1)
                {
                    this.FillTruckBoxList();
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
