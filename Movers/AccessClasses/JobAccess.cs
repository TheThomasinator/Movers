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
    public class JobAccess
    {
        private static string cString = ConfigurationManager.ConnectionStrings["MoversDatabase"].ConnectionString;

        public static List<Job> GetAllJobs()
        {
            using (SqlConnection myCon = new SqlConnection(cString))
            {
                List<Job> myJobs = new List<Job>();
                myCon.Open();
                string myQuery = string.Format("Select * FROM JOB");
                SqlCommand myCommand = new SqlCommand(myQuery, myCon);
                SqlDataReader myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    myJobs.Add(GetJobFromReader(myReader));
                }

                myCon.Close();
                return myJobs;
            }
        }

        public static List<Job> GetAllJobsByDate(DateTime date)
        {
            using (SqlConnection myCon = new SqlConnection(cString))
            {
                List<Job> myJobs = new List<Job>();
                myCon.Open();
                string myQuery = string.Format("Select * FROM JOB WHERE CAST(dateOfJob AS DATE) = '{0}'", date.Date.ToString("yyyy-MM-dd"));
                SqlCommand myCommand = new SqlCommand(myQuery, myCon);
                SqlDataReader myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    myJobs.Add(GetJobFromReader(myReader));
                }

                myCon.Close();
                return myJobs;
            }
        }



        public static Job GetJobFromReader(SqlDataReader reader)
        {
            Job myJob = new Job();

            myJob.JobID = (int)reader[0];
            myJob.AddressID = (int)reader[1];
            myJob.JobType = (string)reader[2];
            myJob.DateOfJob = (DateTime)reader[3];

            return myJob;
        }
    }
}
