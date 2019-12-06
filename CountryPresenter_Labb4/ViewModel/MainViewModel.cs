using System.Collections.Generic;
using Xamarin.Forms;


namespace CountryPresenter_Labb4
{


    public class MainViewModel : SimpleViewModel
    {
        public List<Country> Countries { get; set; }
        public Command NextCountryCommand { get; set; }
        public Command PreviousCountryCommand { get; set; }
        private Country SelectedCountry;
        private int CurrentCountryIndex;

        public MainViewModel()
        {
            var countryRepository = new CountryRepository();
            Countries = countryRepository.getCountryList();
            CurrentCountry = Countries[0];
            NextCountryCommand = new Command(onNextButtonClicked);
            PreviousCountryCommand = new Command(onPreviousButtonClicked);
        }

        

        public Country CurrentCountry
        {
            get
            {
                return SelectedCountry;
            }
            set
            {
                SetPropertyValue(ref SelectedCountry, value);
                RaiseAllPropertiesChanged();
            }
        }

        public string Currency
        {
            get
            {
                return CurrentCountry.Currency;
            }
        }

        public string Name
        {
            get
            {
                return CurrentCountry.Name;
            }

        }


        public string Description
        {
            get
            {
                return CurrentCountry.Description;
            }

        }

        public string Population
        {
            get
            {
                return CurrentCountry.Population;
            }

        }

        public ImageSource ImageUrl
        {
            get
            {
                return CurrentCountry.PictureUrl;
            }

        }

        public void onNextButtonClicked()
        {
            CurrentCountryIndex++;
            if (CurrentCountryIndex <= Countries.Count-1)
            {
                CurrentCountry = Countries[CurrentCountryIndex];
            }
            else
            {
                CurrentCountryIndex = Countries.Count - 1; 
            }
            
            
        }

        public void onPreviousButtonClicked()
        {
            CurrentCountryIndex--;
            if (CurrentCountryIndex >= 0)
            { 
                CurrentCountry = Countries[CurrentCountryIndex];
            }
            else
            {
                CurrentCountryIndex = 0; 
            }
            
           
        }
    }

}
