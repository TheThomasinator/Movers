using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movers
{
    public partial class BookingsNeeded : Form
    {
        public BookingsNeeded()
        {
            InitializeComponent();
            List<Staff> staff = AccessClasses.StaffAccess.GetStaffByJob("Driver");
            staff.AddRange(AccessClasses.StaffAccess.GetStaffByJob("Assistant Driver"));
            List<Van> van = AccessClasses.VanAccess.GetAllVans();
            staffCbx.Items.Add("");
            vanCbx.Items.Add("");
            foreach (Staff s in staff) //Adds the staff to the combo box
            {
                staffCbx.Items.Add(s.StaffID + "-" + s.FirstName + " " + s.SecondName);
            }

            foreach(Van v in van) //Adds the vans to the combo box
            {
                vanCbx.Items.Add(v.VanID + "-" + v.RegistrationPlate);
            }

            CreateStaffTable();
            CreateVanTable();
        }

        public void CreateStaffTable() //Adds the filtered results of to the table
        {
            staffDgv.Rows.Clear();
            if (staffCbx.Text == "")
            {
                List<Staff> staff = AccessClasses.StaffAccess.GetAllStaff();
                foreach (Staff s in staff) //Gets all staff that need a refresher
                {
                    Tuple<Staff, DateTime, DateTime> refreshers = AccessClasses.TrainingAccess.RefresherNeeded(s.StaffID.ToString());
                    if (refreshers.Item1 != null)
                    {
                        staffDgv.Rows.Add(refreshers.Item1.StaffID, refreshers.Item1.FirstName + " " + refreshers.Item1.SecondName, refreshers.Item1.JobTitle, "Refresher", refreshers.Item2.ToString("dd-MM-yyyy"), refreshers.Item3.ToString("dd-MM-yyyy"));
                    }
                }

                foreach (Staff s in staff) //Gets all staff that need a refresher
                {
                    Tuple<Staff, DateTime, DateTime> refreshers = AccessClasses.TrainingAccess.FirstRefresherNeeded(s.StaffID.ToString());
                    if (refreshers.Item1 != null)
                    {
                        staffDgv.Rows.Add(refreshers.Item1.StaffID, refreshers.Item1.FirstName + " " + refreshers.Item1.SecondName, refreshers.Item1.JobTitle, "Refresher", refreshers.Item2.ToString("dd-MM-yyyy"), refreshers.Item3.ToString("dd-MM-yyyy"));
                    }
                }

                List<Staff> training1 = AccessClasses.TrainingAccess.Training1Needed("staffId"); //Gets all staff that need Training 1
                List<Staff> training2 = AccessClasses.TrainingAccess.Training2Needed("staffId"); //Gets all staff that need Training 2
                List<Staff> training3 = AccessClasses.TrainingAccess.Training3Needed("staffId"); //Gets all staff that need Training 3

                foreach (Staff s in training1) 
                {
                    staffDgv.Rows.Add(s.StaffID, s.FirstName + " " + s.SecondName, s.JobTitle, "Training1", "N/A", "N/A");
                }

                foreach (Staff s in training2)
                {
                    staffDgv.Rows.Add(s.StaffID, s.FirstName + " " + s.SecondName, s.JobTitle, "Training2", "N/A", "N/A");
                }

                foreach (Staff s in training3)
                {
                    staffDgv.Rows.Add(s.StaffID, s.FirstName + " " + s.SecondName, s.JobTitle, "Training3", "N/A", "N/A");
                }
            }
            else
            {
                string[] idSplit = staffCbx.Text.Split('-');
                Tuple<Staff, DateTime, DateTime> refreshers = AccessClasses.TrainingAccess.RefresherNeeded(idSplit[0]); //Gets if a specific staff needs a refresher
                if (refreshers.Item1 != null && (refreshers.Item1.JobTitle == "Driver" || refreshers.Item1.JobTitle == "Assistant Driver"))
                {
                    staffDgv.Rows.Add(refreshers.Item1.StaffID, refreshers.Item1.FirstName + " " + refreshers.Item1.SecondName, refreshers.Item1.JobTitle, "Refresher", refreshers.Item2.ToString("dd-MM-yyyy"), refreshers.Item3.ToString("dd-MM-yyyy"));
                }

                refreshers = AccessClasses.TrainingAccess.FirstRefresherNeeded(idSplit[0]); //Gets if a specific staff needs a refresher
                if (refreshers.Item1 != null && (refreshers.Item1.JobTitle == "Driver" || refreshers.Item1.JobTitle == "Assistant Driver"))
                {
                    staffDgv.Rows.Add(refreshers.Item1.StaffID, refreshers.Item1.FirstName + " " + refreshers.Item1.SecondName, refreshers.Item1.JobTitle, "Refresher", refreshers.Item2.ToString("dd-MM-yyyy"), refreshers.Item3.ToString("dd-MM-yyyy"));
                }

                List<Staff> training1 = AccessClasses.TrainingAccess.Training1Needed(idSplit[0]); //Gets if a specific staff needs Training 1
                List<Staff> training2 = AccessClasses.TrainingAccess.Training2Needed(idSplit[0]); //Gets if a specific staff needs Training 2
                List<Staff> training3 = AccessClasses.TrainingAccess.Training3Needed(idSplit[0]); //Gets if a specific staff needs Training 3

                foreach (Staff s in training1)
                {
                    staffDgv.Rows.Add(s.StaffID, s.FirstName + " " + s.SecondName, s.JobTitle, "Training1", "N/A", "N/A");
                }

                foreach (Staff s in training2)
                {
                    staffDgv.Rows.Add(s.StaffID, s.FirstName + " " + s.SecondName, s.JobTitle, "Training2", "N/A", "N/A");
                }

                foreach (Staff s in training3)
                {
                    staffDgv.Rows.Add(s.StaffID, s.FirstName + " " + s.SecondName, s.JobTitle, "Training3", "N/A", "N/A");
                }
            }
        }

        public void CreateVanTable() //Adds the filtered results of to the table
        {
            vanDgv.Rows.Clear();
            if (vanCbx.Text == "")
            {
                List<Van> vans = AccessClasses.VanAccess.GetAllVans();
                foreach (Van v in vans) //Gets all vans that need a checkup
                {
                    Tuple<Van, DateTime, DateTime> checkups = AccessClasses.MaintenanceAccess.CheckupNeeded(v.VanID.ToString()); 
                    if (checkups.Item1 != null)
                    {
                        vanDgv.Rows.Add(checkups.Item1.VanID, checkups.Item1.RegistrationPlate, "Monthly Checkup", checkups.Item2.ToString("dd-MM-yyyy"), checkups.Item3.ToString("dd-MM-yyyy"));
                    }
                }

                foreach (Van v in vans) //Gets all vans that need a MOT Exam
                {
                    Tuple<Van, DateTime, DateTime> mot = AccessClasses.MaintenanceAccess.MOTExamNeeded(v.VanID.ToString());
                    if (mot.Item1 != null)
                    {
                        vanDgv.Rows.Add(mot.Item1.VanID, mot.Item1.RegistrationPlate, "MOT Exam", mot.Item2.ToString("dd-MM-yyyy"), mot.Item3.ToString("dd-MM-yyyy"));
                        vanDgv.Rows.Add(mot.Item1.VanID, mot.Item1.RegistrationPlate, "MOT Checkup", mot.Item2.AddDays(-14).ToString("dd-MM-yyyy"), "N/A");
                    }
                }
                 
                vans = AccessClasses.MaintenanceAccess.FirstMOTExamNeeded(); //Gets all vans that need a MOT Exam
                foreach (Van v in vans)
                {
                    vanDgv.Rows.Add(v.VanID, v.RegistrationPlate, "MOT Exam", "ASAP", "N/A");
                }
            }
            else
            { 
                string[] idSplit = vanCbx.Text.Split('-'); 
                Tuple<Van, DateTime, DateTime> checkups = AccessClasses.MaintenanceAccess.CheckupNeeded(idSplit[0]); //Gets if a specific van needs a checkup
                if (checkups.Item1 != null)
                {
                    vanDgv.Rows.Add(checkups.Item1.VanID, checkups.Item1.RegistrationPlate, "Monthly Checkup", checkups.Item2.ToString("dd-MM-yyyy"), checkups.Item3.ToString("dd-MM-yyyy"));
                }

                Tuple<Van, DateTime, DateTime> mot = AccessClasses.MaintenanceAccess.MOTExamNeeded(idSplit[0]); //Gets if a specific van needs a MOT Exam
                if (mot.Item1 != null)
                {
                    vanDgv.Rows.Add(mot.Item1.VanID, mot.Item1.RegistrationPlate, "MOT Exam", mot.Item2.ToString("dd-MM-yyyy"), mot.Item3.ToString("dd-MM-yyyy"));
                    vanDgv.Rows.Add(mot.Item1.VanID, mot.Item1.RegistrationPlate, "MOT Checkup", mot.Item2.AddDays(-14).ToString("dd-MM-yyyy"), "N/A");
                }

                List<Van> vans = AccessClasses.MaintenanceAccess.FirstMOTExamNeeded(); //Gets if a specific van needs a MOT Exam
                foreach (Van v in vans)
                {
                    if (v.VanID.ToString() == idSplit[0])
                    {
                        vanDgv.Rows.Add(v.VanID, v.RegistrationPlate, "MOT Exam", "ASAP", "N/A");
                    }
                }
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            MainMenu menu = new MainMenu();
            this.Hide();
            menu.Show();
        }

        private void staffCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            CreateStaffTable();
        }

        private void vanCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            CreateVanTable();
        }

        private void staffReportBtn_Click(object sender, EventArgs e) //Creates a report based on the filtered results in the staff table
        {
            PdfMaker pdf = new PdfMaker();
            if (staffCbx.Text != "")
            {
                pdf.CreatePdf(staffDgv, "Bookings for " + staffCbx.Text);
            }
            else
            {
                pdf.CreatePdf(staffDgv, "Bookings for all staff");
            }
        }

        private void vanReportBtn_Click(object sender, EventArgs e) //Creates a report based on the filtered results in the van table
        {
            PdfMaker pdf = new PdfMaker();
            if (vanCbx.Text != "")
            {
                pdf.CreatePdf(vanDgv, "Bookings for " + vanCbx.Text);
            }
            else
            {
                pdf.CreatePdf(vanDgv, "Bookings for all vans");
            }
        }
    }
}
