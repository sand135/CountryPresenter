using System;
using System.Reflection;
using Xamarin.Forms;

namespace CountryPresenter_Labb4.Extensions
{
    public static class CountryExtensions
    {
       public static ImageSource GetImageSource(this Country country)
        {
            
            return ImageSource.FromResource(country.PictureUrl, country.GetType().GetTypeInfo().Assembly);
        }
    }
}
