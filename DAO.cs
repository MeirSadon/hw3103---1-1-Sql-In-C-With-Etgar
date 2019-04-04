using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw3103___1_1_db_Country_And_Capital_City_
{
    class DAO : IDAO
    {
        SQLiteConnection connection;
        string dbName = @"Data Source = C:\meir\Countries.db";

        public DAO()
        {
            connection = new SQLiteConnection($"{dbName}; Version=3;");
            connection.Open();
        }
        public void Close()
        {
            connection.Close();
        }
        
        //*****   Get All Country And Capital City   *****
        public List<object> GetAllCountriesAndCapitalsCity()
        {
            using (SQLiteCommand cmd = new SQLiteCommand("Select * from Country JOIN CapitalCity", connection))
            {
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    List<object> CountriesAndCapitalsCity = new List<object>();
                    while (reader.Read() == true)
                    {
                        Country co = new Country
                        {
                            Id = (int)reader["ID"],
                            Name = (string)reader["NAME"],
                            Size_Km = (int)reader["SIZE_KM"],
                            Birth_Year = (int)reader["BIRTH_YEAR"],
                            CapitalCity_Id = (int)reader["CAPITALCITY_ID"],
                        };
                        Capital_City ca = new Capital_City
                        {
                            Id = (int)reader["ID"],
                            CityName = (string)reader["NAME"],
                            Num_Citizens = (int)reader["num_citizens"],
                            Country_Id = (int)reader["COUNTRY_ID"],
                        };
                        var CoAndCa = new { co, ca };
                        CountriesAndCapitalsCity.Add(CoAndCa);
                    }
                    return CountriesAndCapitalsCity;
                }
            }
        }



        //*****   Get Details Of Country And Name Of Capital City By Id   *****
        public object GetCountyAndItsCapitalCityName(int countryId)
        {
            var coAndCa = default(object);
            using (SQLiteCommand cmd = new SQLiteCommand($"select * from country join capitalCity on Country.id=capitalCity.id where country.id={countryId}", connection))
            {
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read() == true)
                    {
                        Country co = new Country
                        {
                            Id = (int)reader["ID"],
                            Name = (string)reader["NAME"],
                            Size_Km = (int)reader["SIZE_KM"],
                            Birth_Year = (int)reader["BIRTH_YEAR"],
                            CapitalCity_Id = (int)reader["CAPITALCITY_ID"],
                        };
                        Capital_City ca = new Capital_City
                        {
                            Id = (int)reader["ID"],
                            CityName = (string)reader["NAME"],
                            Num_Citizens = (int)reader["num_citizens"],
                            Country_Id = (int)reader["COUNTRY_ID"],
                        };
                        coAndCa = new { co, ca.CityName };
                    }
                }
            }
            return coAndCa;
        }
        
        //*****   Get All Details Of Country And Capital City By Id   *****
        public object GetCountyAndItsCapitalCityDetails(int countryId)
        {
            //List<object> ListOfCoAndCa = GetAllCountriesAndCapitalsCity();
            //var coNameAndCaDetails = from coAndCa in ListOfCoAndCa
            //                          where coAndCa. == countryId
            //                          select new { coAndCa };
            //Console.WriteLine(coNameAndCaDetails.GetHashCode());
            //return coNameAndCaDetails;

            var coAndCa = default(object);
            using (SQLiteCommand cmd = new SQLiteCommand($"select * from country join capitalCity on Country.id=capitalCity.id where country.id={countryId}", connection))
            {
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while(reader.Read() == true)
                    {
                        Country co = new Country
                        {
                            Id = (int)reader["ID"],
                            Name = (string)reader["NAME"],
                            Size_Km = (int)reader["SIZE_KM"],
                            Birth_Year = (int)reader["BIRTH_YEAR"],
                            CapitalCity_Id = (int)reader["CAPITALCITY_ID"],
                        };
                        Capital_City ca = new Capital_City
                        {
                            Id = (int)reader["ID"],
                            CityName = (string)reader["Name"],
                            Num_Citizens = (int)reader["num_citizens"],
                            Country_Id = (int)reader["COUNTRY_ID"],
                        };
                        coAndCa = new { co , ca};
                    }
                }
            }
            return coAndCa;
        }


        //*****   Get Details Of Country And Name Of Capital City By Name   *****
        public object GetCountyAndItsCapitalCityName(string countryName)
        {
            var coAndCa = default(object);
            using (SQLiteCommand cmd = new SQLiteCommand($"select * from country join capitalCity on Country.id=capitalCity.id where country.name={countryName}", connection))
            {
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read() == true)
                    {
                        Country co = new Country
                        {
                            Id = (int)reader["ID"],
                            Name = (string)reader["NAME"],
                            Size_Km = (int)reader["SIZE_KM"],
                            Birth_Year = (int)reader["BIRTH_YEAR"],
                            CapitalCity_Id = (int)reader["CAPITALCITY_ID"],
                        };
                        Capital_City ca = new Capital_City
                        {
                            Id = (int)reader["ID"],
                            CityName = (string)reader["NAME"],
                            Num_Citizens = (int)reader["num_citizens"],
                            Country_Id = (int)reader["COUNTRY_ID"],
                        };
                        coAndCa = new { co, ca };
                    }
                }
            }
            return coAndCa;
        }

        //*****   Get All Details Of Country And Capital City By Name   *****
        public object GetCountyAndItsCapitalCityDetails(string countryName)
        {
            var coAndCa = default(object);
            using (SQLiteCommand cmd = new SQLiteCommand($"select * from country join capitalCity on Country.id=capitalCity.id where country.name={countryName}", connection))
            {
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read() == true)
                    {
                        Country co = new Country
                        {
                            Id = (int)reader["ID"],
                            Name = (string)reader["NAME"],
                            Size_Km = (int)reader["SIZE_KM"],
                            Birth_Year = (int)reader["BIRTH_YEAR"],
                            CapitalCity_Id = (int)reader["CAPITALCITY_ID"],
                        };
                        Capital_City ca = new Capital_City
                        {
                            Id = (int)reader["ID"],
                            CityName = (string)reader["NAME"],
                            Num_Citizens = (int)reader["num_citizens"],
                            Country_Id = (int)reader["COUNTRY_ID"],
                        };
                        coAndCa = new { co, ca.CityName };
                    }
                }
            }
            return coAndCa;
        }


        //*****   Get Details Of Counties And Its Capitals City Name By Char   *****
        public List<object> GetDetailsOfCountiesAndItsCapitalsCityNameByChar(char firstChar)
        {
            List<object> ListOfCoAndCa = new List<object>();
            var coAndCa = default(object);
            using (SQLiteCommand cmd = new SQLiteCommand($"select * from country join capitalCity on Country.id=capitalCity.id where name like '{firstChar}%'", connection))
            {
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read() == true)
                    {
                        Country co = new Country
                        {
                            Id = (int)reader["ID"],
                            Name = (string)reader["NAME"],
                            Size_Km = (int)reader["SIZE_KM"],
                            Birth_Year = (int)reader["BIRTH_YEAR"],
                            CapitalCity_Id = (int)reader["CAPITALCITY_ID"],
                        };
                        Capital_City ca = new Capital_City
                        {
                            Id = (int)reader["ID"],
                            CityName = (string)reader["Name"],
                            Num_Citizens = (int)reader["num_citizens"],
                            Country_Id = (int)reader["COUNTRY_ID"],
                        };
                        coAndCa = new { co, ca.CityName };
                        ListOfCoAndCa.Add(coAndCa);
                    }
                }
            }
            return ListOfCoAndCa;
        }
    }
}
