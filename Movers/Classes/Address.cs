using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movers
{
    public class Address
    {
        int addressID;
        string firstLine, secondLine, postCode, county, city;

        public Address()
        {

        }

        public Address(int aID, string fLine, string sLine, string pCode, string county, string city)
        {
            AddressID = aID;
            FirstLine = fLine;
            SecondLine = sLine;
            PostCode = pCode;
            County = county;
            City = city;
        }

        public int AddressID
        {
            get { return addressID; }
            set { addressID = value; }
        }

        public string FirstLine
        {
            get { return firstLine; }
            set { firstLine = value; }
        }

        public string SecondLine
        {
            get { return secondLine; }
            set { secondLine = value; }
        }

        public string County
        {
            get { return county; }
            set { county = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string PostCode
        {
            get { return postCode; }
            set { postCode = value; }
        }
    }
}
