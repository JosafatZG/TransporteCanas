using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Transportes_Canas.Information;

namespace Transportes_Canas.ViewModel
{
    public class DriverViewModel : INotifyPropertyChanged
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
        private String name;
        private String lastName;
        private String dui;
        private String license;
        private String telephone;
        private String passport;
        private int statusId;
        private List<DriverStatu> driverStatus;
        private List<DriverInformation> listDriver;

        // Getters And Setters
        public int Id { get => id; set => id = value; }
        public string Name { get => name;
            set
            {
                name = value;
            }
        }
        public string LastName { get => lastName; set => lastName = value; }
        public string Dui { get => dui; set => dui = value; }
        public string License { get => license; set => license = value; }
        public string Telephone { get => telephone; set => telephone = value; }
        public string Passport { get => passport; set => passport = value; }
        public int StatusId { get => statusId; set => statusId = value; }
        public List<DriverInformation> ListDriver { get => listDriver; set => listDriver = value; }
        public List<DriverStatu> DriverStatus { get => driverStatus; set => driverStatus = value; }

        // Entity context
        TransportesCanasEntities ctx = new TransportesCanasEntities();

        // Constructor 
        public DriverViewModel()
        {
            this.FillDriverStatus();
            this.FillDriverList();
            this.id = -1;
        }

        // Methods

        private void FillDriverStatus()
        {
            this.driverStatus = ctx.DriverStatus.ToList();
        }

        private void FillDriverList()
        {
            var d = (
                from driver in ctx.Drivers
                join status in ctx.DriverStatus on driver.IdDriverStatus equals status.Id
                select new DriverInformation
                {
                    Id = driver.Id,
                    Name = driver.Name,
                    LastName = driver.LastName,
                    Dui = driver.Dui,
                    License = driver.License,
                    Passport = driver.Passport,
                    Telephone = driver.Telephone,
                    Status = status.Description
                }
            ).ToList();

            this.listDriver = d;
        }

        private void ResetValues()
        {
            this.name = "";
            this.lastName = "";
            this.Dui = "";
            this.License = "";
            this.passport = "";
            this.Telephone = "";
            this.statusId = 0;
            this.id = -1;
        }

        public Boolean SaveDriver()
        {
            try
            {
                Driver driver = new Driver
                {
                    Name = this.name,
                    LastName = this.LastName,
                    Dui = this.Dui,
                    License = this.License,
                    Passport = this.passport,
                    Telephone = this.telephone,
                    IdDriverStatus = this.StatusId
                };
                ctx.Drivers.Add(driver);

                if (ctx.SaveChanges() == 1)
                {
                    this.FillDriverList();
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

        public void GetDriver(int id)
        {
            var driver = ctx.Drivers.Where(d => d.Id == id).FirstOrDefault<Driver>();
            this.id = driver.Id;
            this.name = driver.Name;
            this.lastName = driver.LastName;
            this.dui = driver.Dui;
            this.license = driver.License;
            this.passport = driver.Passport;
            this.telephone = driver.Telephone;
            this.statusId = driver.IdDriverStatus;
            NotifyPropertyChanged();
        }

        public Boolean UpdateDriver()
        {
            try
            {
                var driver = ctx.Drivers.Where(d => d.Id == this.id).FirstOrDefault<Driver>();

                driver.Name = this.name;
                driver.LastName = this.lastName;
                driver.Dui = this.dui;
                driver.License = this.license;
                driver.Passport = this.passport;
                driver.Telephone = this.telephone;
                driver.IdDriverStatus = this.statusId;

                if (ctx.SaveChanges() == 1)
                {
                    this.FillDriverList();
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

        public Boolean DeleteDriver()
        {
            try
            {
                var driver = ctx.Drivers.Where(d => d.Id == id).FirstOrDefault<Driver>();
                ctx.Drivers.Remove(driver);
                if (ctx.SaveChanges() == 1)
                {
                    this.FillDriverList();
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
