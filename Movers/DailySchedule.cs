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
    public partial class DailySchedule : Form
    {
        DataTable jobTable, maintenanceTable, trainingTable;
        Staff driver, engineer;
        Van van;

        public DailySchedule()
        {
            InitializeComponent();
            dateDtp.Value = DateTime.Now;
            CreateTable();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void reportBtn_Click(object sender, EventArgs e) //Creates a report with the filtered results
        {
            PdfMaker p = new PdfMaker();
            p.CreateSchedulePdf(jobDgv, maintenanceDgv, trainingDgv, "DailySchedule", dateDtp.Value.ToString("dd-MM-yyyy"));
        }

        private void dateDtp_ValueChanged(object sender, EventArgs e)
        {
            CreateTable();
        }

        private void mainMenuBtn_Click(object sender, EventArgs e)
        {
            MainMenu menu = new MainMenu();
            this.Hide();
            menu.Show();
        }

        public void CreateTable() //Adds the filtered results to the tables
        {
            jobTable = new DataTable();
            jobTable.Columns.Add("Job ID");
            jobTable.Columns.Add("Job Type");
            jobTable.Columns.Add("Date of Job");
            jobTable.Columns.Add("First line");
            jobTable.Columns.Add("Second Line");
            jobTable.Columns.Add("Post Code");
            jobTable.Columns.Add("County");
            jobTable.Columns.Add("City");

            List<Job> jList = AccessClasses.JobAccess.GetAllJobsByDate(dateDtp.Value);
            List<Address> aList = AccessClasses.AddressAccess.GetAllAddresses();

            foreach (Job job in jList)
            {
                foreach (Address add in aList)
                {
                    if (job.AddressID == add.AddressID)
                    {
                        jobTable.Rows.Add(job.JobID, job.JobType, job.DateOfJob, add.FirstLine, add.SecondLine, add.PostCode, add.County, add.City);
                    }
                }
            }
            jobDgv.DataSource = jobTable;

            maintenanceTable = new DataTable();
            maintenanceTable.Columns.Add("Type");
            maintenanceTable.Columns.Add("Date");
            maintenanceTable.Columns.Add("Time");
            maintenanceTable.Columns.Add("Duration");
            maintenanceTable.Columns.Add("Driver");
            maintenanceTable.Columns.Add("Engineer");
            maintenanceTable.Columns.Add("Van");

            List<Maintenance> mlist = AccessClasses.MaintenanceAccess.GetMaintenanceByDate(dateDtp.Value);

            foreach (Maintenance m in mlist)
            {
                driver = AccessClasses.MaintenanceAccess.GetDriver(m.MaintenanceID);
                engineer = AccessClasses.MaintenanceAccess.GetEngineer(m.MaintenanceID);
                van = AccessClasses.VanAccess.GetVanById(m.VanID);
                maintenanceTable.Rows.Add(m.MaintenanceType, m.MaintenanceDate.ToString("dd-MM-yyyy"), m.MaintenanceDate.TimeOfDay, m.Duration, driver.FirstName + " " + driver.SecondName, engineer.FirstName + " " + engineer.SecondName, m.VanID + "- " + van.RegistrationPlate);
            }
            maintenanceDgv.DataSource = maintenanceTable;

            trainingTable = new DataTable();
            trainingTable.Columns.Add("Training Type");
            trainingTable.Columns.Add("Date");
            trainingTable.Columns.Add("Time");
            trainingTable.Columns.Add("Duration");
            trainingTable.Columns.Add("Staff Members");

            List<Training> training = AccessClasses.TrainingAccess.GetTrainingByDate(dateDtp.Value);

            foreach (Training t in training)
            {
                List<Staff> staff = AccessClasses.TrainingAccess.GetStaffOnTraining(t.TrainingID);
                List<string> staffDetails = new List<string>();
                foreach (Staff s in staff)
                {
                    staffDetails.Add(s.StaffID + "-" + s.FirstName + " " + s.SecondName);
                }
                trainingTable.Rows.Add(t.TrainingType, t.TrainingDate.Date.ToString("dd-MM-yyyy"), t.TrainingDate.TimeOfDay, t.Duration, string.Join(", ", staffDetails.ToArray()));
            }
            trainingDgv.DataSource = trainingTable;
        }
    }
}
