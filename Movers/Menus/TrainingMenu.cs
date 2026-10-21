using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace Movers
{
    public partial class TrainingMenu : Form
    {
        string trainingType = "trainingType";
        string dateOfTraining = "CONVERT(date, TRAINING.dateOfTraining)";
        string duration = "duration";
        string staffId = "staffId";
        List<Training> training;

        public TrainingMenu()
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
            typeCbx.Items.Add("Refresher");
            typeCbx.Items.Add("Training1");
            typeCbx.Items.Add("Training2");
            typeCbx.Items.Add("Training3");

            staffCbx.Items.Add("");

            List<Staff> staff = AccessClasses.StaffAccess.GetStaffByJob("Driver");
            staff.AddRange(AccessClasses.StaffAccess.GetStaffByJob("Assistant Driver"));
            foreach(Staff s in staff) //Adds all the staff to the combo box
            {
                staffCbx.Items.Add(s.StaffID + "-" + s.FirstName + " " + s.SecondName);
            }

            CreateTable();
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

        public void CreateTable() //Adds the filtered results into the table
        {
            trainingDGV.Rows.Clear();

            if (staffCbx.Text == "")
            {
                training = AccessClasses.TrainingAccess.GetFilteredTraining(trainingType, duration, dateOfTraining);
            }
            else training = AccessClasses.TrainingAccess.GetFilteredTrainingAndStaff(trainingType, duration, dateOfTraining, staffId);

            foreach (Training t in training)
            {
                List<Staff> staff = AccessClasses.TrainingAccess.GetStaffOnTraining(t.TrainingID);
                List<string> staffDetails = new List<string>();
                foreach(Staff s in staff)
                {
                    staffDetails.Add(s.StaffID + "-" + s.FirstName + " " + s.SecondName);
                }
                trainingDGV.Rows.Add(t.TrainingType, t.TrainingDate.Date, t.TrainingDate.TimeOfDay, t.Duration, string.Join(", ", staffDetails.ToArray()));               
            }
        }

        private void staffCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(staffCbx.Text == "")
            {
                staffId = "staffID";
            }
            else
            {
                string[] idSplit = staffCbx.Text.Split('-');
                staffId = idSplit[0];
            }
            CreateTable();
        }

        private void typeCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(typeCbx.Text == "")
            {
                trainingType = "trainingType";
            }
            else
            {
                trainingType = "'" + typeCbx.Text + "'";
            }
            CreateTable();
        }

        private void dateDtp_ValueChanged(object sender, EventArgs e)
        {
            dateFilter();
        }

        public void dateFilter()
        {
            if (!dateEnabler.Checked)
            {
                dateOfTraining = "CONVERT(date, TRAINING.dateOfTraining)";
            }
            else
            {
                dateOfTraining = "'" + dateDtp.Value.ToString("yyyy-MM-dd") + "'";
            }
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

        private void dateEnabler_CheckedChanged(object sender, EventArgs e)
        {
            dateFilter();
        }

        private void aedBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void TrainingMenu_Load(object sender, EventArgs e)
        {

        }

        private void aedBtn_Click_1(object sender, EventArgs e)
        {
            TrainingAED aed = new TrainingAED();
            this.Hide();
            aed.Show();
        }

        private void reportBtn_Click(object sender, EventArgs e) //Create a PDF with the results in the table
        {
            PdfMaker p = new PdfMaker();
            p.CreatePdf(trainingDGV, "TrainingReport");
        }
    }
}
