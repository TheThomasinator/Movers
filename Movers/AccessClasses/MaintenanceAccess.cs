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
    class MaintenanceAccess
    {
        private static string cString = ConfigurationManager.ConnectionStrings["MoversDatabase"].ConnectionString;

        public static List<Maintenance> GetAllMaintenance()
        {
            using (SqlConnection myCon = new SqlConnection(cString))
            {
                List<Maintenance> myMaintenances = new List<Maintenance>();
                myCon.Open();
                string myQuery = string.Format("Select * FROM MAINTENANCE");
                SqlCommand myCommand = new SqlCommand(myQuery, myCon);
                SqlDataReader myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    myMaintenances.Add(GetMaintenanceFromReader(myReader));
                }

                myCon.Close();
                return myMaintenances;
            }
        }

        public static List<Maintenance> GetMaintenanceByDate(DateTime date)
        {
            using (SqlConnection myCon = new SqlConnection(cString))
            {
                List<Maintenance> myMaintenances = new List<Maintenance>();
                myCon.Open();
                string myQuery = string.Format("Select * FROM MAINTENANCE WHERE CAST(dateOfMaintenance AS DATE) = '{0}'", date.Date.ToString("yyyy-MM-dd"));
                SqlCommand myCommand = new SqlCommand(myQuery, myCon);
                SqlDataReader myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    myMaintenances.Add(GetMaintenanceFromReader(myReader));
                }

                myCon.Close();
                return myMaintenances;
            }
        }

        public static Maintenance GetMaintenanceById(int id)
        {
            using (SqlConnection myCon = new SqlConnection(cString))
            {
                Maintenance myMaintenance = new Maintenance();
                myCon.Open();
                string myQuery = string.Format("Select * FROM MAINTENANCE WHERE maintenanceId = {0}", id);
                SqlCommand myCommand = new SqlCommand(myQuery, myCon);
                SqlDataReader myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    myMaintenance = GetMaintenanceFromReader(myReader);
                }

                myCon.Close();
                return myMaintenance;
            }
        }

        public static List<Maintenance> GetFilteredMaintenance(string type, string duration, string dateAndTime, string vanId)
        {
            using (SqlConnection myCon = new SqlConnection(cString))
            {
                List<Maintenance> myMaintenance = new List<Maintenance>();
                myCon.Open();
                string myQuery = string.Format("Select * FROM MAINTENANCE WHERE maintenanceType = {0} AND duration = {1} AND vanID = {3} AND CONVERT(date, dateOfMaintenance) =  CONVERT(date, {2})", type, duration, dateAndTime, vanId);
                SqlCommand myCommand = new SqlCommand(myQuery, myCon);
                SqlDataReader myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    myMaintenance.Add(GetMaintenanceFromReader(myReader));
                }

                myCon.Close();
                return myMaintenance;
            }
        }

        public static Maintenance GetMaintenanceFromReader(SqlDataReader reader)
        {
            Maintenance maintenance = new Maintenance();

            maintenance.MaintenanceID = (int)reader[0];
            maintenance.VanID = (int)reader[1];
            maintenance.MaintenanceType = (string)reader[2];
            maintenance.MaintenanceDate = (DateTime)reader[3];
            maintenance.Duration = (int)reader[4];
            maintenance.Details = (string)reader[5];

            return maintenance;
        }

        public static Staff GetDriver(int mainID)
        {
            using (SqlConnection myCon = new SqlConnection(cString))
            {
                Staff driver = new Staff();
                myCon.Open();
                string myQuery = string.Format("SELECT STAFF.* FROM STAFF INNER JOIN STAFF_MAINTENANCE ON STAFF.staffID = STAFF_MAINTENANCE.staffID WHERE STAFF_MAINTENANCE.maintenanceID = {0} AND STAFF.jobTitle = 'Driver'", mainID);
                SqlCommand myCommand = new SqlCommand(myQuery, myCon);
                SqlDataReader myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    driver = AccessClasses.StaffAccess.GetStaffFromReader(myReader);
                }

                myCon.Close();
                return driver;
            }
        }

        public static Staff GetEngineer(int mainID)
        {
            using (SqlConnection myCon = new SqlConnection(cString))
            {
                Staff engineer = new Staff();
                myCon.Open();
                string myQuery = string.Format("SELECT STAFF.* FROM STAFF INNER JOIN STAFF_MAINTENANCE ON STAFF.staffID = STAFF_MAINTENANCE.staffID WHERE STAFF_MAINTENANCE.maintenanceID = {0} AND STAFF.jobTitle = 'Maintenance Engineer'", mainID);
                SqlCommand myCommand = new SqlCommand(myQuery, myCon);
                SqlDataReader myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    engineer = AccessClasses.StaffAccess.GetStaffFromReader(myReader);
                }

                myCon.Close();
                return engineer;
            }
        }

        public static Van GetVan(int mainID)
        {
            using (SqlConnection myCon = new SqlConnection(cString))
            {
                Van van = new Van();
                myCon.Open();
                string myQuery = string.Format("SELECT VAN.* FROM VAN INNER JOIN MAINTENANCE ON VAN.vanId = MAINTENANCE.vanId WHERE MAINTENANCE.maintenanceId = {0}", mainID);
                SqlCommand myCommand = new SqlCommand(myQuery, myCon);
                SqlDataReader myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    van = AccessClasses.VanAccess.GetVanFromReader(myReader);
                }

                myCon.Close();
                return van;
            }
        }

        public static double[] AddMaintenance(Maintenance ma, int engId, int driverId)
        {
            using (SqlConnection myCon = new SqlConnection(cString))
            {
                double[] rows = { 0, 0 };
                myCon.Open();

                string myQuery = string.Format("INSERT INTO MAINTENANCE VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')", ma.VanID, ma.MaintenanceType, ma.MaintenanceDate.ToString("yyyy-MM-dd HH:mm"), ma.Duration, ma.Details);
                SqlCommand myCom = new SqlCommand(myQuery, myCon);
                rows[0] = myCom.ExecuteNonQuery();

                string myQuery2 = string.Format("SELECT SCOPE_IDENTITY()");
                SqlCommand myCom2 = new SqlCommand(myQuery2, myCon);
                rows[1] = (double)(decimal)myCom2.ExecuteScalar();

                string myQuery3 = string.Format("INSERT INTO STAFF_MAINTENANCE VALUES ('{0}', '{1}')", driverId, rows[1]);
                SqlCommand myCom3 = new SqlCommand(myQuery3, myCon);
                rows[0] = myCom3.ExecuteNonQuery();

                if (ma.MaintenanceType != "MOT Exam")
                {
                    string myQuery4 = string.Format("INSERT INTO STAFF_MAINTENANCE VALUES ('{0}', '{1}')", engId, rows[1]);
                    SqlCommand myCom4 = new SqlCommand(myQuery4, myCon);
                    rows[0] = myCom4.ExecuteNonQuery();
                }

                myCon.Close();
                return rows;
            }
        }

        public static double EditMaintenance(Maintenance ma, int engId, int driverId)
        {
            using (SqlConnection myCon = new SqlConnection(cString))
            {
                double rows = 0;
                myCon.Open();

                string myQuery = string.Format("UPDATE MAINTENANCE SET vanId = '{0}', dateOfMaintenance = '{2}', duration = '{3}', details = '{4}' WHERE maintenanceID = '{5}'", ma.VanID, ma.MaintenanceType, ma.MaintenanceDate.ToString("yyyy-MM-dd HH:mm"), ma.Duration, ma.Details, ma.MaintenanceID);
                SqlCommand myCom = new SqlCommand(myQuery, myCon);
                rows = myCom.ExecuteNonQuery();

                string myQuery2 = string.Format("UPDATE STAFF_MAINTENANCE " +
                    "SET STAFF_MAINTENANCE.staffID = {0} " +
                    "FROM STAFF_MAINTENANCE " +
                    "INNER JOIN STAFF " +
                    "ON STAFF_MAINTENANCE.staffID = STAFF.staffID " +
                    "WHERE STAFF.JobTitle = 'Driver' " +
                    "AND STAFF_MAINTENANCE.maintenanceId = {1}", driverId, ma.MaintenanceID);
                SqlCommand myCom2 = new SqlCommand(myQuery2, myCon);
                rows = myCom2.ExecuteNonQuery();

                if (ma.MaintenanceType != "MOT Exam")
                {
                    string myQuery3 = string.Format("UPDATE STAFF_MAINTENANCE " +
                    "SET STAFF_MAINTENANCE.staffID = {0} " +
                    "FROM STAFF_MAINTENANCE " +
                    "INNER JOIN STAFF " +
                    "ON STAFF_MAINTENANCE.staffID = STAFF.staffID " +
                    "WHERE maintenanceID = {1} AND STAFF.jobTitle = 'Maintenance Engineer'", engId, ma.MaintenanceID);
                    SqlCommand myCom3 = new SqlCommand(myQuery3, myCon);
                    rows = myCom3.ExecuteNonQuery();
                }

                myCon.Close();
                return rows;
            }
        }

        public static int DeleteMaintenance(int id)
        {
            using (SqlConnection myCon = new SqlConnection(cString))
            {
                int rowsAffected = 0;
                myCon.Open();
                string myQuery = string.Format("DELETE FROM MAINTENANCE WHERE maintenanceID = {0}; DELETE FROM STAFF_MAINTENANCE WHERE maintenanceId = {0}", id);
                SqlCommand myCom = new SqlCommand(myQuery, myCon);
                rowsAffected = myCom.ExecuteNonQuery();
                myCon.Close();
                return rowsAffected;
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
                        "(SELECT COUNT(STAFF_TRAINING.trainingID) FROM STAFF_TRAINING WHERE STAFF_TRAINING.staffID = {2})) " +
                        "AND (((STAFF.staffId IN (SELECT staffId FROM STAFF_TRAINING INNER JOIN TRAINING ON STAFF_TRAINING.trainingID = TRAINING.trainingID WHERE TRAINING.trainingType = 'Training1')) " +
                        "AND(STAFF.staffId IN(SELECT staffId FROM STAFF_TRAINING INNER JOIN TRAINING ON STAFF_TRAINING.trainingID = TRAINING.trainingID WHERE TRAINING.trainingType = 'Training2')) " +
                        "AND(STAFF.staffId IN(SELECT staffId FROM STAFF_TRAINING INNER JOIN TRAINING ON STAFF_TRAINING.trainingID = TRAINING.trainingID WHERE TRAINING.trainingType = 'Training3')) " +
                        "AND STAFF.jobTitle = 'Driver') " +
                        "OR STAFF.jobTitle = 'Maintenance Engineer' " +
                        ")", startTime.ToString("yyyy -MM-dd HH:mm"), endTime.ToString("yyyy-MM-dd HH:mm"), s.StaffID);
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

       

        public static List<Van> AvailableVans(DateTime startTime, DateTime endTime)
        {
            using (SqlConnection myCon = new SqlConnection(cString))
            {
                List<Van> myVans = new List<Van>();
                List<Van> allVans = AccessClasses.VanAccess.GetAllVans();
                SqlDataReader myReader;
                myCon.Open();
                foreach (Van v in allVans)
                {
                    string myQuery = string.Format(
                        "SELECT DISTINCT MAINTENANCE.vanId FROM MAINTENANCE " +
                        "WHERE " +
                        "(SELECT COUNT(MAINTENANCE.vanId) FROM MAINTENANCE " +
                        "WHERE vanId = {2}" +
                        "AND NOT MAINTENANCE.dateOfMaintenance BETWEEN '{0}' and '{1}'" +
                        "AND NOT DATEADD(MINUTE, MAINTENANCE.duration, MAINTENANCE.dateOfMaintenance) BETWEEN '{0}' and '{1}' " +
                        "AND NOT '{0}' BETWEEN MAINTENANCE.dateOfMaintenance and DATEADD(MINUTE, MAINTENANCE.duration, MAINTENANCE.dateOfMaintenance) " +
                        "AND NOT '{1}' BETWEEN MAINTENANCE.dateOfMaintenance and DATEADD(MINUTE, MAINTENANCE.duration, MAINTENANCE.dateOfMaintenance)) " +
                        "= " +
                        "(SELECT COUNT(MAINTENANCE.vanId) FROM MAINTENANCE WHERE MAINTENANCE.vanId = {2}) " +
                        "AND vanId = {2} ", startTime.ToString("yyyy-MM-dd HH:mm"), endTime.ToString("yyyy-MM-dd HH:mm"), v.VanID);
                    SqlCommand myCommand = new SqlCommand(myQuery, myCon);
                    myReader = myCommand.ExecuteReader();

                    while (myReader.Read())
                    {
                        myVans.Add(AccessClasses.VanAccess.GetVanFromReaderById(myReader));
                    }

                    myReader.Close();
                }

                string myQuery2 = string.Format("SELECT VAN.vanId FROM VAN WHERE vanId NOT IN(SELECT vanId FROM MAINTENANCE)");
                SqlCommand myCommand2 = new SqlCommand(myQuery2, myCon);
                myReader = myCommand2.ExecuteReader();

                while (myReader.Read())
                {
                    myVans.Add(AccessClasses.VanAccess.GetVanFromReaderById(myReader));
                }

                myCon.Close();

                return myVans;
            }
        }

        public static Tuple<Van, DateTime, DateTime> CheckupNeeded(string id)
        {
            using (SqlConnection myCon = new SqlConnection(cString))
            {
                myCon.Open();
                string myQuery = string.Format("SELECT VAN.*, DATEADD(MONTH, 1, MAINTENANCE.dateOfMaintenance), MAINTENANCE.dateOfMaintenance " +
                    "FROM MAINTENANCE " +
                    "INNER JOIN VAN " +
                    "ON MAINTENANCE.vanID = VAN.vanID " +
                    "WHERE MAINTENANCE.maintenanceType = 'Monthly Checkup' " +
                    "AND MAINTENANCE.dateOfMaintenance < GETDATE() " +
                    "AND VAN.vanID = {0} " +
                    "ORDER BY DATEDIFF(day, MAINTENANCE.dateOfMaintenance, GETDATE()) ASC", id);
                SqlCommand myCommand = new SqlCommand(myQuery, myCon);
                SqlDataReader myReader = myCommand.ExecuteReader();
                Tuple<Van, DateTime, DateTime> vAndD = new Tuple<Van, DateTime, DateTime>(null, DateTime.Today, DateTime.Today);

                if (myReader.Read())
                {
                    Van van = VanAccess.GetVanFromReader(myReader); //Takes only the first in the reader as the list is sorted by most recent date
                    vAndD = new Tuple<Van, DateTime, DateTime>(van, (DateTime)myReader[4], (DateTime)myReader[5]);
                }

                myCon.Close();

                return vAndD;
            }
        }

        public static Tuple<Van, DateTime, DateTime> MOTExamNeeded(string id)
        {
            using (SqlConnection myCon = new SqlConnection(cString))
            {
                myCon.Open();
                string myQuery = string.Format("SELECT VAN.*, DATEADD(YEAR, 1, MAINTENANCE.dateOfMaintenance), MAINTENANCE.dateOfMaintenance " +
                    "FROM MAINTENANCE " +
                    "INNER JOIN VAN " +
                    "ON MAINTENANCE.vanID = VAN.vanID " +
                    "WHERE MAINTENANCE.maintenanceType = 'MOT Exam' " +
                    "AND MAINTENANCE.dateOfMaintenance < GETDATE() " +
                    "AND VAN.vanID = {0} " +
                    "ORDER BY DATEDIFF(day, MAINTENANCE.dateOfMaintenance, GETDATE()) ASC", id);
                SqlCommand myCommand = new SqlCommand(myQuery, myCon);
                SqlDataReader myReader = myCommand.ExecuteReader();
                Tuple<Van, DateTime, DateTime> vAndD = new Tuple<Van, DateTime, DateTime>(null, DateTime.Today, DateTime.Today);

                if (myReader.Read())
                {
                    Van van = VanAccess.GetVanFromReader(myReader); //Takes only the first in the reader as the list is sorted by most recent date
                    vAndD = new Tuple<Van, DateTime, DateTime>(van, (DateTime)myReader[4], (DateTime)myReader[5]);
                }

                myCon.Close();

                return vAndD;
            }
        }

        public static List<Van> FirstMOTExamNeeded()
        {
            using (SqlConnection myCon = new SqlConnection(cString))
            {
                List<Van> myVans = new List<Van>();
                SqlDataReader myReader;
                myCon.Open();
                string myQuery = string.Format("SELECT VAN.vanId FROM VAN WHERE vanId NOT IN(SELECT vanId FROM MAINTENANCE WHERE maintenanceType = 'MOT Exam')");
                SqlCommand myCommand = new SqlCommand(myQuery, myCon);
                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    myVans.Add(AccessClasses.VanAccess.GetVanFromReaderById(myReader));
                }

                myCon.Close();

                return myVans;
            }
        }

        public static string MaintenancesByVan(string id)
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

                foreach(Maintenance m in myMaintenances)
                {
                    mainList += "\n " + m.MaintenanceID + "-" + "  " + m.MaintenanceType + " " + m.MaintenanceDate + " ";
                }
                return mainList;
            }
        }

        public static string MaintenanceByStaff(string id)
        {
            using (SqlConnection myCon = new SqlConnection(cString))
            {
                string mainList = "";
                List<Maintenance> myMaintenances = new List<Maintenance>();
                SqlDataReader myReader;
                myCon.Open();

                string myQuery = string.Format("SELECT MAINTENANCE.* FROM STAFF_MAINTENANCE " +
                    "INNER JOIN MAINTENANCE " +
                    "ON STAFF_MAINTENANCE.maintenanceId = MAINTENANCE.maintenanceId " +
                    "WHERE staffId = {0}", id);
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
