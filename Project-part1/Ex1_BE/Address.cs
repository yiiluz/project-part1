using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_BE
{
    public struct Address
    {
        string city;
        string street;
        int buildingNumber;

        public Address(string c, string s, int n)
        {
            city = c;
            street = s;
            buildingNumber = n;

        }
        string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }
        string Street
        {
            get
            {
                return street;
            }
            set
            {
                street = value;
            }
        }
        int BuildingNumber
        {
            get
            {
                return buildingNumber;
            }
            set
            {
                buildingNumber = value;
            }
        }
        public string ToString()
        {
            string tmp = "City: " + City + ".\nStreet: " + Street + ". Building number: " + BuildingNumber + ".\n";
            return tmp;
        }
    }
}
