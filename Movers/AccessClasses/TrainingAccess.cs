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
    class TrainingAccess
    {
        private static string cString = ConfigurationManager.ConnectionStrings["MoversDatabase"].ConnectionString;

        public static List<Training> GetAllTraining()
        {
            using (SqlConnection myCon = new SqlConnection(cString))
            {
                List<Training> myTrainings = new List<Training>();
                myCon.Open();
                string myQuery = string.Format("Select * FROM TRAINING");
                SqlCommand myCommand = new SqlCommand(myQuery, myCon);
                SqlDataReader myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    myTrainings.Add(GetTrainingFromReader(myReader));
                }

                myCon.Close();
                return myTrainings;
            }
        }

        public static Training GetTrainingById(string id)
        {
            using (SqlConnection myCon = new SqlConnection(cString))
            {
                Training myTraining = new Training();
                myCon.Open();
                string myQuery = string.Format("Select * FROM TRAINING WHERE trainingId = {0}", id);
                SqlCommand myCommand = new SqlCommand(myQuery, myCon);
                SqlDataReader myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    myTraining = GetTrainingFromReader(myReader);
                }

                myCon.Close();
                return myTraining;
            }
        }

        public static double[] AddTraining(Training t)
        {
            using (SqlConnection myCon = new SqlConnection(cString))
            {
                double[] rows = { 0, 0 };
                myCon.Open();

                string myQuery = string.Format("INSERT INTO TRAINING VALUES ('{0}', '{1}', '{2}')", t.TrainingType, t.TrainingDate.ToString("yyyy-MM-dd HH:mm"), t.Duration);
                SqlCommand myCom = new SqlCommand(myQuery, myCon);
                rows[0] = myCom.ExecuteNonQuery();

                string myQuery2 = string.Format("SELECT SCOPE_IDENTITY()");
                SqlCommand myCom2 = new SqlCommand(myQuery2, myCon);
                rows[1] = (double)(decimal)myCom2.ExecuteScalar();            

                myCon.Close();
                return rows;
            }
        }

        public static double EditTraining(Training t)
        {
            using (SqlConnection myCon = new SqlConnection(cString))
            {
                double rows = 0;
                myCon.Open();

                string myQuery = string.Format("UPDATE TRAINING SET dateOfTraining = '{1}', duration = '{2}' WHERE trainingId = '{0}'", t.TrainingID, t.TrainingDate.ToString("yyyy-MM-dd HH:mm"), t.Duration);
                SqlCommand myCom = new SqlCommand(myQuery, myCon);
                rows = myCom.ExecuteNonQuery();
                
                myCon.Close();
                return rows;
            }
        }

        public static List<Training> GetFilteredTraining(string type, string duration, string tDate)
        {
            using (SqlConnection myCon = new SqlConnection(cString))
            {
                List<Training> myTrainings = new List<Training>();
                myCon.Open();
                string myQuery = string.Format("SELECT DISTINCT TRAINING.* " +
                    "FROM TRAINING " +
                    "WHERE TRAINING.trainingType = {0} " +
                    "AND CONVERT(date, TRAINING.dateOfTraining) = {1} " +
                    "AND TRAINING.duration = {2} ", type, string.Format(tDate, "yyyy-MM-dd"), duration);
                SqlCommand myCommand = new SqlCommand(myQuery, myCon);
                SqlDataReader myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    myTrainings.Add(GetTrainingFromReader(myReader));
                }

                myCon.Close();
                return myTrainings;
            }
        }

        public static List<Training> GetFilteredTrainingAndStaff(string type, string duration, string tDate, string staffId)
        {
            using (SqlConnection myCon = new SqlConnection(cString))
            {
                List<Training> myTrainings = new List<Training>();
                myCon.Open();
                string myQuery = string.Format("SELECT DISTINCT TRAINING.* " +
                    "FROM TRAINING " +
                    "INNER JOIN STAFF_TRAINING " +
                    "ON TRAINING.trainingId = STAFF_TRAINING.trainingId " +           
                    "WHERE TRAINING.trainingType = {0} " +
                    "AND CONVERT(date, TRAINING.dateOfTraining) = {1} " +
                    "AND TRAINING.duration = {2} " +
                    "AND STAFF_TRAINING.staffId = {3} " +
                    "SELECT DISTINCT TRAINING.* FROM TRAINING " +
                    "WHERE TRAINING.trainingID NOT IN(SELECT trainingId FROM STAFF_TRAINING) " +
                    "AND TRAINING.trainingType = {0} " +
                    "AND CONVERT(date, TRAINING.dateOfTraining) = {1} " +
                    "AND TRAINING.duration = {2} ", type, string.Format(tDate, "yyyy-MM-dd"), duration, staffId);
                SqlCommand myCommand = new SqlCommand(myQuery, myCon);
                SqlDataReader myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    myTrainings.Add(GetTrainingFromReader(myReader));
                }

                myCon.Close();
                return myTrainings;
            }
        }

        public static List<Staff> GetStaffOnTraining(int id)
        {
            using (SqlConnection myCon = new SqlConnection(cString))
            {
                List<Staff> staff = new List<Staff>();
                myCon.Open();
                string myQuery = string.Format("Select * FROM STAFF " +
                    "INNER JOIN STAFF_TRAINING " +
                    "ON STAFF.StaffId = STAFF_TRAINING.StaffId " +
                    "WHERE STAFF_TRAINING.trainingId = {0}", id);
                SqlCommand myCommand = new SqlCommand(myQuery, myCon);
                SqlDataReader myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    staff.Add(AccessClasses.StaffAccess.GetStaffFromReader(myReader));
                }

                myCon.Close();
                return staff;
            }
        }
        

        public static Training GetTrainingFromReader(SqlDataReader reader)
        {
            Training training = new Training();

            training.TrainingID = (int)reader[0];
            training.TrainingType = (string)reader[1];
            training.TrainingDate = (DateTime)reader[2];
            training.Duration = (int)reader[3];
           
            return training;
        }

        public static double AssignStaff(int tId, int sId)
        {
            using (SqlConnection myCon = new SqlConnection(cString))
            {
                double rows = 0;
                myCon.Open();

                string myQuery = string.Format("INSERT INTO STAFF_TRAINING VALUES ('{0}', '{1}')", sId, tId);
                SqlCommand myCom = new SqlCommand(myQuery, myCon);
                rows = myCom.ExecuteNonQuery();

                myCon.Close();
                return rows;
            }
        }

        public static double UnAssignStaff(int tId, int sId)
        {
            using (SqlConnection myCon = new SqlConnection(cString))
            {
                double rows = 0;
                myCon.Open();

                string myQuery = string.Format("DELETE FROM STAFF_TRAINING WHERE staffId = {0} AND trainingId = {1}", sId, tId);
                SqlCommand myCom = new SqlCommand(myQuery, myCon);
                rows = myCom.ExecuteNonQuery();

                myCon.Close();
                return rows;
            }
        }

        public static List<Training> GetTrainingByDate(DateTime date)
        {
            using (SqlConnection myCon = new SqlConnection(cString))
            {
                List<Training> myTraining = new List<Training>();
                myCon.Open();
                string myQuery = string.Format("Select * FROM TRAINING WHERE CAST(dateOfTraining AS DATE) = '{0}'", date.Date.ToString("yyyy-MM-dd"));
                SqlCommand myCommand = new SqlCommand(myQuery, myCon);
                SqlDataReader myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    myTraining.Add(GetTrainingFromReader(myReader));
                }

                myCon.Close();
                return myTraining;
            }
        }

        public static int DeleteTraining(int tId)
        {
            using (SqlConnection myCon = new SqlConnection(cString))
            {
                List<Staff> staff = GetStaffOnTraining(tId);
                foreach (Staff s in staff)
                {
                    UnAssignStaff(tId, s.StaffID);
                }

                int rows = 0;
                myCon.Open();         
                string myQuery = string.Format("DELETE FROM TRAINING WHERE trainingId = {0}", tId);
                SqlCommand myCom = new SqlCommand(myQuery, myCon);
                rows = myCom.ExecuteNonQuery();

                myCon.Close();
                return rows;
            }
        }

        public static List<Staff> Training1Needed(string id)
        {
            using (SqlConnection myCon = new SqlConnection(cString))
            {
                List<Staff> staff = new List<Staff>();
                myCon.Open();
                string myQuery = string.Format("SELECT STAFF.* FROM STAFF WHERE STAFF.staffId " +
                    "NOT IN(SELECT staffId FROM STAFF_TRAINING " +
                    "INNER JOIN TRAINING " +
                    "ON STAFF_TRAINING.trainingId = TRAINING.trainingId " +
                    "WHERE trainingType = 'Training1') " +
                    "AND STAFF.staffId = {0} " +
                    "AND (STAFF.jobTitle = 'Driver' OR STAFF.jobTitle = 'Assistant Driver')", id);
                SqlCommand myCommand = new SqlCommand(myQuery, myCon);
                SqlDataReader myReader = myCommand.ExecuteReader();

                while(myReader.Read())
                {
                   staff.Add(StaffAccess.GetStaffFromReader(myReader)); 
                }
            
                myCon.Close();

                return staff;
            }
        }

        public static List<Staff> Training2Needed(string id)
        {
            using (SqlConnection myCon = new SqlConnection(cString))
            {
                List<Staff> staff = new List<Staff>();
                myCon.Open();
                string myQuery = string.Format("SELECT STAFF.* FROM STAFF WHERE STAFF.staffId " +
                    "NOT IN(SELECT staffId FROM STAFF_TRAINING " +
                    "INNER JOIN TRAINING " +
                    "ON STAFF_TRAINING.trainingId = TRAINING.trainingId " +
                    "WHERE trainingType = 'Training2') " +
                    "AND STAFF.staffId = {0} " +
                    "AND (STAFF.jobTitle = 'Driver' OR STAFF.jobTitle = 'Assistant Driver')", id);
                SqlCommand myCommand = new SqlCommand(myQuery, myCon);
                SqlDataReader myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    staff.Add(StaffAccess.GetStaffFromReader(myReader));
                }

                myCon.Close();

                return staff;
            }
        }

        public static List<Staff> Training3Needed(string id)
        {
            using (SqlConnection myCon = new SqlConnection(cString))
            {
                List<Staff> staff = new List<Staff>();
                myCon.Open();
                string myQuery = string.Format("SELECT STAFF.* FROM STAFF WHERE STAFF.staffId " +
                    "NOT IN(SELECT staffId FROM STAFF_TRAINING " +
                    "INNER JOIN TRAINING " +
                    "ON STAFF_TRAINING.trainingId = TRAINING.trainingId " +
                    "WHERE trainingType = 'Training3') " +
                    "AND STAFF.staffId = {0} " +
                    "AND (STAFF.jobTitle = 'Driver' OR STAFF.jobTitle = 'Assistant Driver')", id);
                SqlCommand myCommand = new SqlCommand(myQuery, myCon);
                SqlDataReader myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    staff.Add(StaffAccess.GetStaffFromReader(myReader));
                }

                myCon.Close();

                return staff;
            }
        }

        public static Tuple<Staff, DateTime, DateTime> RefresherNeeded(string id)
        {
            using (SqlConnection myCon = new SqlConnection(cString))
            {
                myCon.Open();
                string myQuery = string.Format("SELECT STAFF.*, DATEADD(MONTH, 1, TRAINING.dateOfTraining),  dateOfTraining FROM TRAINING " +
                    "INNER JOIN STAFF_TRAINING " +
                    "ON TRAINING.trainingID = STAFF_TRAINING.trainingID " +
                    "INNER JOIN STAFF " +
                    "ON STAFF_TRAINING.staffID = STAFF.staffID " +
                    "WHERE TRAINING.trainingType = 'Refresher' " +
                    "AND TRAINING.dateOfTraining < GETDATE() " +
                    "AND STAFF.staffID = {0} " +
                    "AND (STAFF.jobTitle = 'Driver' OR STAFF.jobTitle = 'Assistant Driver')" +
                    "ORDER BY DATEDIFF(day, TRAINING.dateOfTraining, GETDATE()) ASC", id);
                SqlCommand myCommand = new SqlCommand(myQuery, myCon);
                SqlDataReader myReader = myCommand.ExecuteReader();
                Tuple<Staff, DateTime, DateTime> sAndD = new Tuple<Staff, DateTime, DateTime>(null, DateTime.Today, DateTime.Today);

                if (myReader.Read())
                {
                    Staff staff = StaffAccess.GetStaffFromReader(myReader); //Takes only the first in the reader as the list is sorted by most recent date
                    sAndD = new Tuple<Staff, DateTime, DateTime>(staff, (DateTime)myReader[5], (DateTime)myReader[6]);
                }

                myCon.Close();

                return sAndD;
            }
        }

        public static Tuple<Staff, DateTime, DateTime> FirstRefresherNeeded(string id)
        {
            using (SqlConnection myCon = new SqlConnection(cString))
            {
                myCon.Open();
                string myQuery = string.Format("SELECT STAFF.*, DATEADD(MONTH, 1, TRAINING.dateOfTraining),  dateOfTraining FROM TRAINING " +
                  "INNER JOIN STAFF_TRAINING " +
                  "ON TRAINING.trainingID = STAFF_TRAINING.trainingID " +
                  "INNER JOIN STAFF " +
                  "ON STAFF_TRAINING.staffID = STAFF.staffID " +
                  "WHERE TRAINING.trainingType = 'Training3' " +
                  "AND STAFF.staffId " +
                  "NOT IN(SELECT staffId FROM STAFF_TRAINING " +
                  "INNER JOIN TRAINING " +
                  "ON STAFF_TRAINING.trainingId = TRAINING.trainingId " +
                  "WHERE trainingType = 'Refresher') " +
                  "AND STAFF.staffID " +
                  "IN(SELECT staffId FROM STAFF_TRAINING " +
                  "INNER JOIN TRAINING " +
                  "ON STAFF_TRAINING.trainingId = TRAINING.trainingId " +
                  "WHERE trainingType = 'Training1') " +
                  "AND STAFF.staffID " +
                  "IN(SELECT staffId FROM STAFF_TRAINING " +
                  "INNER JOIN TRAINING " +
                  "ON STAFF_TRAINING.trainingId = TRAINING.trainingId " +
                  "WHERE trainingType = 'Training2') " +
                  "AND STAFF.staffID " +
                  "IN(SELECT staffId FROM STAFF_TRAINING " +
                  "INNER JOIN TRAINING " +
                  "ON STAFF_TRAINING.trainingId = TRAINING.trainingId " +
                  "WHERE trainingType = 'Training3') " +
                  "AND STAFF.staffId = {0} " +
                  "AND (STAFF.jobTitle = 'Driver' OR STAFF.jobTitle = 'Assistant Driver') " +
                  "ORDER BY DATEDIFF(day, TRAINING.dateOfTraining, GETDATE()) ASC", id);
                SqlCommand myCommand = new SqlCommand(myQuery, myCon);
                SqlDataReader myReader = myCommand.ExecuteReader();
                Tuple<Staff, DateTime, DateTime> sAndD = new Tuple<Staff, DateTime, DateTime>(null, DateTime.Today, DateTime.Today);

                if (myReader.Read())
                {
                    Staff staff = StaffAccess.GetStaffFromReader(myReader); //Takes only the first in the reader as the list is sorted by most recent date
                    sAndD = new Tuple<Staff, DateTime, DateTime>(staff, (DateTime)myReader[5], (DateTime)myReader[6]);
                }

                myCon.Close();

                return sAndD;
            }
        }

        public static List<Staff> AvailableStaff(DateTime startTime, DateTime endTime)
        {
            using (SqlConnection myCon = new SqlConnection(cString))
            {
                List<Staff> myStaff = new List<Staff>();
                myCon.Open();
                List<Staff> st = AccessClasses.StaffAccess.GetAllStaff();
                foreach (Staff s in st)
                {
                    string myQuery = string.Format("SELECT STAFF.staffID FROM STAFF " +
                        "WHERE STAFF.staffID = {2} " +
                        "AND " +
                        "(SELECT " +
                        "(SELECT COUNT(STAFF_MAINTENANCE.maintenanceID) FROM STAFF_MAINTENANCE " +
                        "INNER JOIN STAFF " +
                        "ON  STAFF_MAINTENANCE.staffID = STAFF.staffID " +
                        "INNER JOIN MAINTENANCE " +
                        "ON STAFF_MAINTENANCE.maintenanceID = MAINTENANCE.maintenanceID " +
                        "WHERE NOT MAINTENANCE.dateOfMaintenance BETWEEN '{0}' and '{1}' " +
                        "AND NOT DATEADD(MINUTE, MAINTENANCE.duration, MAINTENANCE.dateOfMaintenance) BETWEEN '{0}' and '{1}' " +
                        "AND NOT '{0}' BETWEEN MAINTENANCE.dateOfMaintenance and DATEADD(MINUTE, MAINTENANCE.duration, MAINTENANCE.dateOfMaintenance) " +
                        "AND NOT '{1}' BETWEEN MAINTENANCE.dateOfMaintenance and DATEADD(MINUTE, MAINTENANCE.duration, MAINTENANCE.dateOfMaintenance) " +
                        "AND STAFF_MAINTENANCE.staffID = {2}) " +
                        "+ " +
                        "(SELECT " +
                        "(SELECT COUNT(STAFF_TRAINING.trainingId) FROM STAFF_TRAINING " +
                        "INNER JOIN STAFF " +
                        "ON  STAFF_TRAINING.staffID = STAFF.staffID " +
                        "INNER JOIN TRAINING " +
                        "ON STAFF_TRAINING.trainingId = TRAINING.trainingId " +
                        "AND NOT TRAINING.dateOfTraining BETWEEN '{0}' and '{1}' " +
                        "AND NOT DATEADD(MINUTE, TRAINING.duration, TRAINING.dateOfTraining) BETWEEN '{0}' and '{1}' " +
                        "AND NOT '{0}' BETWEEN TRAINING.dateOfTraining and DATEADD(MINUTE, TRAINING.duration, TRAINING.dateOfTraining) " +
                        "AND NOT '{1}' BETWEEN TRAINING.dateOfTraining and DATEADD(MINUTE, TRAINING.duration, TRAINING.dateOfTraining) " +
                        "AND STAFF_TRAINING.staffID = {2}))) " +
                        "= " +
                        "(SELECT " +
                        "(SELECT COUNT(STAFF_MAINTENANCE.maintenanceID) FROM STAFF_MAINTENANCE WHERE STAFF_MAINTENANCE.staffID = {2} " +
                        "AND STAFF_MAINTENANCE.staffID = {2}) + " +
                        "(SELECT COUNT(STAFF_TRAINING.trainingID) FROM STAFF_TRAINING WHERE STAFF_TRAINING.staffID = {2}))", startTime.ToString("yyyy -MM-dd HH:mm"), endTime.ToString("yyyy-MM-dd HH:mm"), s.StaffID);
                    SqlCommand myCommand = new SqlCommand(myQuery, myCon);
                    SqlDataReader myReader = myCommand.ExecuteReader();

                    while (myReader.Read())
                    {
                        myStaff.Add(AccessClasses.StaffAccess.GetStaffFromReaderById(myReader));
                    }

                    myReader.Close();
                }

                myCon.Close();
                return myStaff;
            }
        }

        public static string TrainingByVan(string id)
        {
            using (SqlConnection myCon = new SqlConnection(cString))
            {
                string mainList = "";
                List<Maintenance> myMaintenances = new List<Maintenance>();
                SqlDataReader myReader;
                myCon.Open();

                string myQuery = string.Format("SELECT * FROM MAINTENANCE WHERE vanID = {0}", id);
                SqlCommand myCommand = new SqlCommand(myQuery, myCon);
                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    myMaintenances.Add(AccessClasses.MaintenanceAccess.GetMaintenanceFromReader(myReader));
                }

                myReader.Close();

                foreach (Maintenance m in myMaintenances)
                {
                    mainList += "\n " + m.MaintenanceID + "-" + "  " + m.MaintenanceType + " " + m.MaintenanceDate + " ";
                }
                return mainList;
            }
        }




    }
}
