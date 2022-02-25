using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportes_Canas.Information;

namespace Transportes_Canas.ViewModel
{
    public class ClientViewModel : INotifyPropertyChanged
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
        private string address;
        private string telephone;
        private string email;
        private int idCity;
        private int idCountry;
        private int idState;
        private List<ClientInformation> listClient;
        private List<CountryInformation> listCountries;
        private List<StateInformation> listStates;
        private List<CityInformation> listCities;

        // Getters and Setters
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string Telephone { get => telephone; set => telephone = value; }
        public string Email { get => email; set => email = value; }
        public List<ClientInformation> ListClient { get => listClient; set => listClient = value; }
        public List<CountryInformation> ListCountries { get => listCountries; set => listCountries = value; }
        public List<StateInformation> ListStates { get => listStates; set => listStates = value; }
        public List<CityInformation> ListCities { get => listCities; set => listCities = value; }
        public int IdCity { get => idCity; set => idCity = value; }
        public int IdCountry { get => idCountry; set => idCountry = value; }
        public int IdState { get => idState; set => idState = value; }

        // Entity context
        TransportesCanasEntities ctx = new TransportesCanasEntities();

        // Constructor
        public ClientViewModel()
        {
            this.FillClientList();
            this.FillListCountries();
            this.FillListStatesByCountry();
            this.FillListCitiesByState();
            this.id = -1;
        }

        // Methods
        private void ResetValues()
        {
            this.name = "";
            this.address = "";
            this.telephone = "";
            this.email = "";
            this.id = -1;
            this.idCity = 0;
            this.FillListCountries();
            this.FillListStatesByCountry();
            this.FillListCitiesByState();
        }

        private void FillListCountries()
        {
            var d = (
                from place in ctx.Countries
                select new CountryInformation
                {
                    Id = place.Id,
                    Country = place.Name
                }
            ).ToList();

            this.listCountries = d;
        }

        public void FillListStatesByCountry()
        {
            var d = (
                from place in ctx.States
                where place.IdCountry == idCountry
                select new StateInformation
                {
                    Id = place.Id,
                    State = place.Name
                }
            ).ToList();

            this.listStates = d;
        }

        public void FillListCitiesByState()
        {
            var d = (
                from place in ctx.Cities
                where place.IdState == idState
                select new CityInformation
                {
                    Id = place.Id,
                    City = place.Name
                }
            ).ToList();

            this.listCities = d;
        }

        private void FillClientList()
        {
            var c = (
                from client in ctx.Clients
                select new ClientInformation
                {
                    Id = client.Id,
                    Name = client.Name,
                    Address = client.Address,
                    Email = client.Email,
                    Telephone = client.Telephone,
                    City = client.City.Name + ", " + client.City.State.Name + ", " + client.City.State.Country.Name
                }
            ).ToList();

            this.ListClient = c;
        }

        public Boolean SaveClient()
        {
            try
            {
                Client client = new Client
                {
                    Name = this.name,
                    Address = this.address,
                    Telephone = this.telephone,
                    Email = this.email,
                    IdCity = this.idCity
                };
                ctx.Clients.Add(client);

                if (ctx.SaveChanges() == 1)
                {
                    this.FillClientList();
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

        public void GetClient(int id)
        {
            var client = ctx.Clients.Where(d => d.Id == id).FirstOrDefault<Client>();
            this.id = client.Id;
            this.name = client.Name;
            this.address = client.Address;
            this.email = client.Email;
            this.telephone = client.Telephone;
            this.idCity = client.IdCity;
            NotifyPropertyChanged();
        }

        public Boolean UpdateClient()
        {
            try
            {
                var client = ctx.Clients.Where(d => d.Id == id).FirstOrDefault<Client>();

                client.Name = this.name;
                client.Address = this.address;
                client.Email = this.email;
                client.Telephone = this.telephone;
                client.IdCity = this.idCity;

                if (ctx.SaveChanges() == 1)
                {
                    this.FillClientList();
                    this.ResetValues();
                    NotifyPropertyChanged();
                    return true;
                }
                return false;
            } catch
            {
                return false;
            }
        }

        public Boolean DeleteClient()
        {
            try
            {
                var client = ctx.Clients.Where(d => d.Id == this.id).FirstOrDefault<Client>();
                ctx.Clients.Remove(client);
                if (ctx.SaveChanges() == 1)
                {
                    this.FillClientList();
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
