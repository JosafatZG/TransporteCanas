using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportes_Canas.Information;

namespace Transportes_Canas.ViewModel
{
    public class VehicleModelViewModel : INotifyPropertyChanged
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
        private string name;
        private int idBrand;
        private List<VehicleBrand> listBrand;
        private List<ModelInformation> listModel;

        // Getter and setter
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public List<VehicleBrand> ListBrand { get => listBrand; set => listBrand = value; }
        public List<ModelInformation> ListModel { get => listModel; set => listModel = value; }
        public int IdBrand { get => idBrand; set => idBrand = value; }

        // Entity context
        TransportesCanasEntities ctx = new TransportesCanasEntities();

        // Constructor
        public VehicleModelViewModel()
        {
            this.ResetValues();

        }

        private void ResetValues()
        {
            this.id = -1;
            this.name = "";
            this.idBrand = 0;
            this.FillBrandList();
            this.FillModelList();
        }

        public void FillBrandList()
        {
            this.listBrand = ctx.VehicleBrands.ToList();
        }

        private void FillModelList()
        {
            var t = (
                from model in ctx.VehicleModels
                select new ModelInformation
                {
                    Id = model.Id,
                    Name = model.Name,
                    Brand = model.VehicleBrand.Name
                }
            ).ToList();

            this.listModel = t;
        }

        public Boolean SaveModel()
        {
            try
            {
                VehicleModel model = new VehicleModel
                {
                    Name = this.name,
                    IdVehicleBrand = this.idBrand
                };
                ctx.VehicleModels.Add(model);

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

        public void GetModel(int id)
        {
            var model = ctx.VehicleModels.Where(d => d.Id == id).FirstOrDefault<VehicleModel>();
            this.id = model.Id;
            this.name = model.Name;
            this.idBrand = model.IdVehicleBrand;
            NotifyPropertyChanged();
        }

        public Boolean UpdateModel()
        {
            try
            {
                var brand = ctx.VehicleModels.Where(d => d.Id == this.id).FirstOrDefault<VehicleModel>();

                brand.Name = this.name;
                brand.IdVehicleBrand = this.idBrand;

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

        public Boolean DeleteModel()
        {
            try
            {
                var model = ctx.VehicleModels.Where(d => d.Id == this.id).FirstOrDefault<VehicleModel>();
                ctx.VehicleModels.Remove(model);
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
