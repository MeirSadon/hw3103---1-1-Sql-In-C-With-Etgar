using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw3103___1_1_db_Country_And_Capital_City_
{
    class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Size_Km { get; set; }
        public int Birth_Year { get; set; }
        public int CapitalCity_Id { get; set; }

        public static bool operator ==(Country c1, Country c2)
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
        public static bool operator !=(Country c1, Country c2)
        {
            return !(c1.Id == c2.Id);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Country c = obj as Country;
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
            return $"Country Id: {Id}. Name: {Name}. Size: {Size_Km} KM. Birth Year: {Birth_Year}. Capital City Id: {CapitalCity_Id}.";
        }
    }
}
