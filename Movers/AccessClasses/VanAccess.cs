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
    class VanAccess
    {
        private static string cString = ConfigurationManager.ConnectionStrings["MoversDatabase"].ConnectionString;

        public static List<Van> GetAllVans()
        {
            using (SqlConnection myCon = new SqlConnection(cString))
            {
                List<Van> myVans = new List<Van>();
                myCon.Open();
                string myQuery = string.Format("Select * FROM VAN");
                SqlCommand myCommand = new SqlCommand(myQuery, myCon);
                SqlDataReader myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    myVans.Add(GetVanFromReader(myReader));
                }

                myCon.Close();
                return myVans;
            }
        }

        public static Van GetVanFromReader(SqlDataReader reader)
        {
            Van van = new Van();

            van.VanID = (int)reader[0];
            van.Size = (string)reader[1];
            van.RegistrationPlate = (string)reader[2];
            van.Make = (string)reader[3];

            return van;
        }

        public static Van GetVanFromReaderById(SqlDataReader reader)
        {
            Van van = AccessClasses.VanAccess.GetVanById((int)reader[0]);         
            return van;
        }

        public static Van GetVanById(int id)
        {
            using (SqlConnection myCon = new SqlConnection(cString))
            {
                Van myVan = new Van();
                myCon.Open();
                string myQuery = string.Format("Select * FROM VAN WHERE vanID = {0} ", id);
                SqlCommand myCommand = new SqlCommand(myQuery, myCon);
                SqlDataReader myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    myVan = GetVanFromReader(myReader);
                }

                myCon.Close();
                return myVan;
            }
        }

        public static List<Van> GetFilteredVans(string size, string regPlate, string make)
        {
            using (SqlConnection myCon = new SqlConnection(cString))
            {
                List<Van> myVan = new List<Van>();
                myCon.Open();
                string myQuery = string.Format("Select * FROM VAN WHERE size = {0} AND registrationPlate {1} AND make {2}", size, regPlate, make);
                SqlCommand myCommand = new SqlCommand(myQuery, myCon);
                SqlDataReader myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    myVan.Add(GetVanFromReader(myReader));
                }

                myCon.Close();
                return myVan;
            }
        }

        public static double[] AddVan(Van van)
        {
            using (SqlConnection myCon = new SqlConnection(cString))
            {
                double[] rows = { 0, 0 };
                myCon.Open();

                string myQuery = string.Format("INSERT INTO VAN VALUES ('{0}', '{1}', '{2}')", van.Size, van.RegistrationPlate, van.Make);
                SqlCommand myCom = new SqlCommand(myQuery, myCon);
                rows[0] = myCom.ExecuteNonQuery();

                string myQuery2 = string.Format("SELECT SCOPE_IDENTITY()");
                SqlCommand myCom2 = new SqlCommand(myQuery2, myCon);
                rows[1] = (double)(decimal)myCom2.ExecuteScalar();

                myCon.Close();
                return rows;
            }
        }

        public static int EditVan(Van van)
        {
            using (SqlConnection myCon = new SqlConnection(cString))
            {
                int rowsAffected = 0;
                myCon.Open();
                string myQuery = string.Format("UPDATE VAN SET size = '{1}', registrationPlate = '{2}', make = '{3}' WHERE vanID = '{0}'", van.VanID, van.Size, van.RegistrationPlate, van.Make);
                SqlCommand myCommand = new SqlCommand(myQuery, myCon);
                rowsAffected = myCommand.ExecuteNonQuery();
                myCon.Close();
                return rowsAffected;
            }
        }

        public static int DeleteVan(int id)
        {
            using (SqlConnection myCon = new SqlConnection(cString))
            {
                int rowsAffected = 0;
                myCon.Open();
                string myQuery = string.Format("DELETE FROM VAN WHERE vanID = '{0}'", id);
                SqlCommand myCom = new SqlCommand(myQuery, myCon);
                rowsAffected = myCom.ExecuteNonQuery();
                myCon.Close();
                return rowsAffected;
            }
        }
    }
}

