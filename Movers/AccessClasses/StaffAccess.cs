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
    class StaffAccess
    {
        private static string cString = ConfigurationManager.ConnectionStrings["MoversDatabase"].ConnectionString;

        public static List<Staff> GetAllStaff()
        {
            using (SqlConnection myCon = new SqlConnection(cString))
            {
                List<Staff> myStaff = new List<Staff>();
                myCon.Open();
                string myQuery = string.Format("Select * FROM STAFF");
                SqlCommand myCommand = new SqlCommand(myQuery, myCon);
                SqlDataReader myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    myStaff.Add(GetStaffFromReader(myReader));
                }

                myCon.Close();
                return myStaff;
            }
        }

        public static Staff GetStaffById(int id)
        {
            using (SqlConnection myCon = new SqlConnection(cString))
            {
                Staff myStaff = new Staff();
                myCon.Open();
                string myQuery = string.Format("Select * FROM STAFF WHERE staffID = " + id);
                SqlCommand myCommand = new SqlCommand(myQuery, myCon);
                SqlDataReader myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    myStaff = GetStaffFromReader(myReader);
                }

                myCon.Close();
                return myStaff;
            }
        }

        public static List<Staff> GetFilteredStaff(string fName, string sName, string pOrF, string jobTitle)
        {
            using (SqlConnection myCon = new SqlConnection(cString))
            {
                List<Staff> myStaff = new List<Staff>();
                myCon.Open();
                string myQuery = string.Format("Select * FROM STAFF WHERE firstName {0} AND lastName {1} AND jobTitle = {2} AND partOrFullTime = {3}", fName, sName, jobTitle, pOrF );
                SqlCommand myCommand = new SqlCommand(myQuery, myCon);
                SqlDataReader myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    myStaff.Add(GetStaffFromReader(myReader));
                }

                myCon.Close();
                return myStaff;
            }
        }


        public static Staff GetStaffFromReader(SqlDataReader reader)
        {
            Staff staff = new Staff();

            staff.StaffID = (int)reader[0];
            staff.FirstName = (string)reader[1];
            staff.SecondName = (string)reader[2];
            staff.JobTitle = (string)reader[3];
            staff.PartOrFullTime = (string)reader[4];

            return staff;
        }

        public static Staff GetStaffFromReaderById(SqlDataReader reader)
        {
            Staff staff = AccessClasses.StaffAccess.GetStaffById((int)reader[0]);           

            return staff;
        }


        public static double[] AddStaff(Staff st)
        {
            using (SqlConnection myCon = new SqlConnection(cString))
            {
                double[] rows = { 0, 0 };
                myCon.Open();

                string myQuery = string.Format("INSERT INTO STAFF VALUES ('{0}', '{1}', '{2}', '{3}')", st.FirstName, st.SecondName, st.JobTitle, st.PartOrFullTime);
                SqlCommand myCom = new SqlCommand(myQuery, myCon);
                rows[0] = myCom.ExecuteNonQuery();

                string myQuery2 = string.Format("SELECT SCOPE_IDENTITY()");
                SqlCommand myCom2 = new SqlCommand(myQuery2, myCon);
                rows[1] = (double)(decimal)myCom2.ExecuteScalar();

                myCon.Close();
                return rows;
            }
        }

        public static int EditStaff(Staff st)
        {
            using (SqlConnection myCon = new SqlConnection(cString))
            {
                int rows = 0;
                myCon.Open();
                string myQuery = string.Format("UPDATE STAFF SET firstName = '{1}', lastName = '{2}', jobTitle = '{3}', partOrFullTime = '{4}' WHERE staffID = '{0}'", st.StaffID, st.FirstName, st.SecondName, st.JobTitle, st.PartOrFullTime);
                SqlCommand myCommand = new SqlCommand(myQuery, myCon);
                rows = myCommand.ExecuteNonQuery();
                myCon.Close();
                return rows;
            }
        }

        public static int DeleteStaff(int id)
        {
            using (SqlConnection myCon = new SqlConnection(cString))
            {
                int rowsAffected = 0;
                myCon.Open();
                string myQuery = string.Format("DELETE FROM STAFF WHERE StaffID = '{0}'", id);
                SqlCommand myCom = new SqlCommand(myQuery, myCon);
                rowsAffected = myCom.ExecuteNonQuery();
                myCon.Close();
                return rowsAffected;
            }
        }

        public static List<Staff> GetStaffByJob(string job)
        {
            using (SqlConnection myCon = new SqlConnection(cString))
            {
                List<Staff> myStaff = new List<Staff>();
                myCon.Open();
                string myQuery = string.Format("Select * FROM STAFF WHERE jobTitle = '{0}'", job);
                SqlCommand myCommand = new SqlCommand(myQuery, myCon);
                SqlDataReader myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    myStaff.Add(GetStaffFromReader(myReader));
                }

                myCon.Close();
                return myStaff;
            }
        }
    }
}
