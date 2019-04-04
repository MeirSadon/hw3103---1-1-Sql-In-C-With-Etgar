using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw3103___1_1_db_Country_And_Capital_City_
{
    class Capital_City
    {
        public int Id { get; set; }
        public string CityName { get; set; }
        public int Num_Citizens { get; set; }
        public int Country_Id { get; set; }


        public static bool operator ==(Capital_City c1, Capital_City c2)
        {
            if (ReferenceEquals(c1, null) && ReferenceEquals(c2, null))
                return true;
            if (ReferenceEquals(c1, null) || ReferenceEquals(c2, null))
                return false;
            if (ReferenceEquals(c1.Id, c2.Id))
                return true;
            else
                return false;
        }
        public static bool operator !=(Capital_City c1, Capital_City c2)
        {
            return !(c1.Id == c2.Id);
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Capital_City c = obj as Capital_City;
            if (c == null)
                return false;

            return this.Id == c.Id;
        }

        public override int GetHashCode()
        {
            return this.Id;
        }

        public override string ToString()
        {
            return $"Capital City Id: {Id}. City Name: {CityName}. Number Of Citizens: {Num_Citizens}. Country Id: {Country_Id}.";
        }
    }
}
