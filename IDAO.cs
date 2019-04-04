using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw3103___1_1_db_Country_And_Capital_City_
{
    interface IDAO
    {
        object GetCountyAndItsCapitalCityName(int countryId);
        object GetCountyAndItsCapitalCityDetails(int countryId);
        object GetCountyAndItsCapitalCityName(string countryName);
        object GetCountyAndItsCapitalCityDetails(string countryName);

        //Etgar


    }
}
