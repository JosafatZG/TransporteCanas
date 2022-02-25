using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportes_Canas.Information;

namespace Transportes_Canas.ViewModel
{
    public class VehicleBrandViewModel : INotifyPropertyChanged
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
        private List<BrandInformation> brandList;

        // Getter And Setter
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public List<BrandInformation> BrandList { get => brandList; set => brandList = value; }

        // Entity context
        TransportesCanasEntities ctx = new TransportesCanasEntities();

        // Constructor 
        public VehicleBrandViewModel()
        {
            this.ResetValues();
        }

        private void FillBrandList()
        {
            var t = (
                from brand in ctx.VehicleBrands
                select new BrandInformation
                {
                    Id = brand.Id,
                    Name = brand.Name
                }
            ).ToList();

            this.brandList = t;
        }

        private void ResetValues()
        {
            this.FillBrandList();
            this.id = -1;
            this.name = "";
        }

        public Boolean SaveBrand()
        {
            try
            {
                VehicleBrand brand = new VehicleBrand
                {
                    Name = this.name
                };
                ctx.VehicleBrands.Add(brand);

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

        public void GetBrand(int id)
        {
            var brand = ctx.VehicleBrands.Where(d => d.Id == id).FirstOrDefault<VehicleBrand>();
            this.id = brand.Id;
            this.name = brand.Name;
            NotifyPropertyChanged();
        }

        public Boolean UpdateBrand()
        {
            try
            {
                var brand = ctx.VehicleBrands.Where(d => d.Id == this.id).FirstOrDefault<VehicleBrand>();

                brand.Name = this.name;

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

        public Boolean DeleteBrand()
        {
            try
            {
                var brand = ctx.VehicleBrands.Where(d => d.Id == this.id).FirstOrDefault<VehicleBrand>();
                ctx.VehicleBrands.Remove(brand);
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
