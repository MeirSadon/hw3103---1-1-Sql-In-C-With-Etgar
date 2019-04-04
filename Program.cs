using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw3103___1_1_db_Country_And_Capital_City_
{
    class Program
    {
        static void Main(string[] args)
        {
            DAO dao = new DAO();

            object a = dao.GetCountyAndItsCapitalCityDetails(1);
            Console.WriteLine(a);

            List<Object> countiesAndCapitals = dao.GetDetailsOfCountiesAndItsCapitalsCityNameByChar('a');
            countiesAndCapitals.ForEach(cc => Console.WriteLine(cc));



            dao.Close();
        }
    }
}
