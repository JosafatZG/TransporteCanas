using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportes_Canas.Information;

namespace Transportes_Canas.ViewModel
{
    public class DestinationPlaceViewModel : INotifyPropertyChanged
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
        private int idCity;
        private int idCountry;
        private int idState;
        private String description;
        private List<DestinationPlaceInformation> listPlace;
        private List<CountryInformation> listCountries;
        private List<StateInformation> listStates;
        private List<CityInformation> listCities;

        // Getters and setters
        public int Id { get => id; set => id = value; }
        public int IdCountry { get => idCountry; set => idCountry = value; }
        public int IdState { get => idState; set => idState = value; }
        public int IdCity { get => idCity; set => idCity = value; }
        public string Description { get => description; set => description = value; }
        public List<DestinationPlaceInformation> ListPlace { get => listPlace; set => listPlace = value; }
        public List<CountryInformation> ListCountries { get => listCountries; set => listCountries = value; }
        public List<StateInformation> ListStates { get => listStates; set => listStates = value; }
        public List<CityInformation> ListCities { get => listCities; set => listCities = value; }

        // Entity context
        TransportesCanasEntities ctx = new TransportesCanasEntities();

        // Constructor 
        public DestinationPlaceViewModel()
        {
            this.idCity = 0;
            this.idCountry = 0;
            this.idState = 0;
            this.FillList();
            this.FillListCountries();
            this.FillListStatesByCountry();
            this.FillListCitiesByState();
            this.id = -1;
            this.description = "";
        }

        // Methods
        private void FillList()
        {
            var d = (
                from place in ctx.DestinationPlaces
                /* join city in ctx.Cities on place.IdCity equals city.Id
                join state in ctx.States on city.IdState equals state.Id
                join country in ctx.Countries on state.IdCountry equals country.Id*/
                select new DestinationPlaceInformation
                {
                    Id = place.Id,
                    Country = place.City.State.Country.Name,
                    State = place.City.State.Name,
                    City = place.City.Name,
                    Description = place.Description
                }
            ).ToList();

            this.ListPlace = d;
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

        private void ResetValues()
        {
            this.idCity = 0;
            this.id = -1;
            this.description = "";
        }

        public Boolean SavePlace()
        {
            DestinationPlace place = new DestinationPlace
            {
                IdCity = this.idCity,
                Description = this.description
            };
            ctx.DestinationPlaces.Add(place);

            if (ctx.SaveChanges() == 1)
            {
                this.FillList();
                this.ResetValues();
                NotifyPropertyChanged();
                return true;
            }
            return false;
        }

        public void GetPlace(int id)
        {
            var place = ctx.DestinationPlaces.Where(d => d.Id == id).FirstOrDefault<DestinationPlace>();
            this.id = place.Id;
            this.idCountry = place.City.State.Country.Id;
            this.idState = place.City.State.Id;
            this.idCity = place.IdCity;
            this.description = place.Description;
            NotifyPropertyChanged();
        }

        public Boolean UpdatePlace()
        {
            var place = ctx.DestinationPlaces.Where(d => d.Id == this.id).FirstOrDefault<DestinationPlace>();

            place.Id = this.id;
            place.IdCity = this.idCity;
            place.Description = this.description;

            if (ctx.SaveChanges() == 1)
            {
                this.FillList();
                this.ResetValues();
                NotifyPropertyChanged();
                return true;
            }
            return false;
        }

        public Boolean DeletePlace()
        {
            try
            {
                var place = ctx.DestinationPlaces.Where(d => d.Id == id).FirstOrDefault<DestinationPlace>();
                ctx.DestinationPlaces.Remove(place);
                if (ctx.SaveChanges() == 1)
                {
                    this.FillList();
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
