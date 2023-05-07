using Autorizacion_y_autenticacion_JWT.Models;

namespace Autorizacion_y_autenticacion_JWT.Constants
{
    public class CountryConstants
    {
        public static List<CountryModel> Countrys = new List<CountryModel>()
        {
            new CountryModel(){Name= "Argentina"},
            new CountryModel(){Name= "Peru"},
            new CountryModel(){Name= "Mexico"},
            new CountryModel(){Name= "Colombia"},
        };


    }
}
