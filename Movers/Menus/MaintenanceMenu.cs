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
    public partial class MaintenanceMenu : Form
    {
        DataTable myTable = new DataTable();
        Van van = new Van();
        string type = "maintenanceType";
        string dateAndTime = "dateOfMaintenance";
        string duration = "duration";
        string vanId = "vanID";
        Staff driver, engineer;

        public MaintenanceMenu()
        {
            InitializeComponent();

            durationCbx.Items.Add("");
            durationCbx.Items.Add("15 Minutes");
            durationCbx.Items.Add("30 Minutes");
            durationCbx.Items.Add("45 Minutes");
            durationCbx.Items.Add("60 Minutes");
            durationCbx.Items.Add("75 Minutes");
            durationCbx.Items.Add("90 Minutes");
            durationCbx.Items.Add("105 Minutes");
            durationCbx.Items.Add("120 Minutes");

            typeCbx.Items.Add("");
            typeCbx.Items.Add("Repair");
            typeCbx.Items.Add("Monthly Checkup");
            typeCbx.Items.Add("MOT Checkup");
            typeCbx.Items.Add("MOT Exam");

            List<Van> vans = AccessClasses.VanAccess.GetAllVans();

            vanCbx.Items.Add("");
            foreach (Van v in vans) //Adds the vans to the combo box
            {
                vanCbx.Items.Add(v.VanID + "- " + v.RegistrationPlate);
            }

            CreateTable();
        }

        public void CreateTable() //Adds the details of the filtered maintenances to the table
        {
            maintenanceDGV.Rows.Clear();

            List<Maintenance> mlist = AccessClasses.MaintenanceAccess.GetFilteredMaintenance(type, duration, dateAndTime, vanId);

            foreach (Maintenance m in mlist)
            {
                driver = AccessClasses.MaintenanceAccess.GetDriver(m.MaintenanceID);
                engineer = AccessClasses.MaintenanceAccess.GetEngineer(m.MaintenanceID);
                van = AccessClasses.VanAccess.GetVanById(m.VanID);
                maintenanceDGV.Rows.Add(m.MaintenanceType, m.MaintenanceDate, m.MaintenanceDate.TimeOfDay, m.Duration, driver.FirstName + " " + driver.SecondName, engineer.FirstName + " " + engineer.SecondName, m.VanID + "- " + van.RegistrationPlate, m.Details);
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void mainMenuBtn_Click(object sender, EventArgs e)
        {
            MainMenu menu = new MainMenu();
            this.Hide();
            menu.Show();
        }

        private void aedBtn_Click(object sender, EventArgs e)
        {
            MaintenanceAED aed = new MaintenanceAED();
            this.Hide();
            aed.Show();
        }

        private void typeCbx_SelectedIndexChanged(object sender, EventArgs e) 
        {
            if (typeCbx.Text == "")
            {
                type = "maintenanceType";
            }
            else type = "'" + typeCbx.Text + "'";
            CreateTable();
        }

        private void durationCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (durationCbx.Text == "")
            {
                duration = "duration";
            }
            else
            {
                string[] dur = durationCbx.Text.Split(' ');
                duration = dur[0];
            }
            CreateTable();
        }

        private void dateDtp_ValueChanged(object sender, EventArgs e)
        {
            dateFilter();
        }

        private void dateEnabler_CheckedChanged(object sender, EventArgs e)
        {
            dateFilter();
        }

        private void timeDtp_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void vanCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(vanCbx.Text == "")
            {
                vanId = "vanID";
            }
            else
            {
                string[] vanSplit = vanCbx.Text.Split('-');
                vanId = vanSplit[0];
            }
            CreateTable();
        }

        private void reportBtn_Click(object sender, EventArgs e) //Creates a report with the added results 
        {
            PdfMaker p = new PdfMaker();
            p.CreatePdf(maintenanceDGV, "MaintenanceReport");
        }

        public void dateFilter()
        {
            if (!dateEnabler.Checked)
            {              
                dateAndTime = "dateOfMaintenance";            
            }
            else
            {
                dateAndTime = "'" + dateDtp.Value.ToString("yyyy-MM-dd") + "'";
            }
            CreateTable();
        }
    }
}
