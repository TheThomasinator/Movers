using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Movers.AccessClasses
{
    class AddressAccess
    {
        private static string cString = ConfigurationManager.ConnectionStrings["MoversDatabase"].ConnectionString;

        public static List<Address> GetAllAddresses()
        {
            using (SqlConnection myCon = new SqlConnection(cString))
            {
                List<Address> myAddresses = new List<Address>();
                myCon.Open();
                string myQuery = string.Format("Select * FROM ADDRESS");
                SqlCommand myCommand = new SqlCommand(myQuery, myCon);
                SqlDataReader myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    myAddresses.Add(GetAddressFromReader(myReader));
                }

                myCon.Close();
                return myAddresses;
            }
        }

        public static Address GetAddressFromReader(SqlDataReader reader)
        {
            Address address = new Address();

            address.AddressID = (int)reader[0];
            address.FirstLine = (string)reader[1];
            address.SecondLine = (string)reader[2];
            address.PostCode = (string)reader[3];
            address.County = (string)reader[4];
            address.City = (string)reader[5];

            return address;
        }
    }
}
