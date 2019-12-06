
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Newtonsoft.Json;

namespace CountryPresenter_Labb4
{
    public class CountryRepository
    {

        CountryList countryList = new CountryList();

        public CountryRepository()
        {
            GetJsonData();
        }


        public List<Country> getCountryList()
        {
            return countryList.countries;
        }

        public void GetJsonData()
        {
            string jsonFileName = "Model.countries.json";
            var assembly = typeof(MainPage).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream($"{assembly.GetName().Name}.{jsonFileName}");
            using (var reader = new StreamReader(stream))
            {
                var jsonString = reader.ReadToEnd();    
                countryList = JsonConvert.DeserializeObject<CountryList>(jsonString);

            }
        }
    }


    public class CountryList
    {
        public List<Country> countries { get; set; }
    }
}
