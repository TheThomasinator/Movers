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
    public partial class TrainingAED : Form
    {
        int hours, minutes;
        DateTime dateAndTime;

        public TrainingAED()
        {
            InitializeComponent();
            addDurationCbx.Items.Add("");
            addDurationCbx.Items.Add("15 Minutes");
            addDurationCbx.Items.Add("30 Minutes");
            addDurationCbx.Items.Add("45 Minutes");
            addDurationCbx.Items.Add("60 Minutes");
            addDurationCbx.Items.Add("75 Minutes");
            addDurationCbx.Items.Add("90 Minutes");
            addDurationCbx.Items.Add("105 Minutes");
            addDurationCbx.Items.Add("120 Minutes");
            addDurationCbx.Items.Add("135 Minutes");
            addDurationCbx.Items.Add("150 Minutes");
            addDurationCbx.Items.Add("165 Minutes");
            addDurationCbx.Items.Add("180 Minutes");
            addDurationCbx.Items.Add("195 Minutes");
            addDurationCbx.Items.Add("210 Minutes");
            addDurationCbx.Items.Add("225 Minutes");
            addDurationCbx.Items.Add("240 Minutes");

            editDurationCbx.Items.Add("");
            editDurationCbx.Items.Add("15 Minutes");
            editDurationCbx.Items.Add("30 Minutes");
            editDurationCbx.Items.Add("45 Minutes");
            editDurationCbx.Items.Add("60 Minutes");
            editDurationCbx.Items.Add("75 Minutes");
            editDurationCbx.Items.Add("90 Minutes");
            editDurationCbx.Items.Add("105 Minutes");
            editDurationCbx.Items.Add("120 Minutes");
            editDurationCbx.Items.Add("135 Minutes");
            editDurationCbx.Items.Add("150 Minutes");
            editDurationCbx.Items.Add("165 Minutes");
            editDurationCbx.Items.Add("180 Minutes");
            editDurationCbx.Items.Add("195 Minutes");
            editDurationCbx.Items.Add("210 Minutes");
            editDurationCbx.Items.Add("225 Minutes");
            editDurationCbx.Items.Add("240 Minutes");

            addTypeCbx.Items.Add("");
            addTypeCbx.Items.Add("Refresher");
            addTypeCbx.Items.Add("Training1");
            addTypeCbx.Items.Add("Training2");
            addTypeCbx.Items.Add("Training3");

            editIdCbx.Items.Add("");
            deleteIdCbx.Items.Add("");
            assignIdCbx.Items.Add("");

            List<Training> trainingList = AccessClasses.TrainingAccess.GetAllTraining();
            foreach (Training t in trainingList) //Adds the trainings to all combo boxes
            {
                editIdCbx.Items.Add(t.TrainingID + "-" + t.TrainingType + " " + t.TrainingDate.ToString("dd-MM-yyyy HH:mm"));
                deleteIdCbx.Items.Add(t.TrainingID + "-" + t.TrainingType + " " + t.TrainingDate.ToString("dd-MM-yyyy HH:mm"));
                assignIdCbx.Items.Add(t.TrainingID + "-" + t.TrainingType + " " + t.TrainingDate.ToString("dd-MM-yyyy HH:mm"));
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            TrainingMenu menu = new TrainingMenu();
            this.Hide();
            menu.Show();
        }

        private void addBtn_Click(object sender, EventArgs e) //Adds a new training to the system with the users added details if they meet validation
        {
            dateAndTime = addDateDtp.Value;
            string time = addTimeDtp.Value.ToString("HH:mm");
            string[] timeSplit = time.Split(':');
            int Hour = Int32.Parse(timeSplit[0]);
            int Min = Int32.Parse(timeSplit[1].Substring(0, 2));

            dateAndTime = dateAndTime.Date + new TimeSpan(Hour, Min, 0); 
            string[] durSplit = addDurationCbx.Text.Split(' ');

            if (Validation(dateAndTime, new TimeSpan(Hour, Min, 0), addDurationCbx.Text, addTypeCbx.Text))
            {
                Training t = new Training(0, addTypeCbx.Text, dateAndTime, Int32.Parse(durSplit[0]));
                double[] rows = AccessClasses.TrainingAccess.AddTraining(t);

                if (rows[0] == 1)
                {
                    MessageBox.Show("Training has been added to database", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    addDurationCbx.SelectedIndex = 0;
                    addTypeCbx.SelectedIndex = 0;

                    editIdCbx.Items.Clear();
                    deleteIdCbx.Items.Clear();
                    assignIdCbx.Items.Clear();

                    editIdCbx.Items.Add("");
                    deleteIdCbx.Items.Add("");
                    assignIdCbx.Items.Add("");

                    List<Training> trainingList = AccessClasses.TrainingAccess.GetAllTraining();
                    foreach (Training tr in trainingList) //Updates the boxes with the added training
                    {
                        editIdCbx.Items.Add(tr.TrainingID + "-" + tr.TrainingType + " " + tr.TrainingDate.ToString("dd-MM-yyyy HH:mm"));
                        deleteIdCbx.Items.Add(tr.TrainingID + "-" + tr.TrainingType + " " + tr.TrainingDate.ToString("dd-MM-yyyy HH:mm"));
                        assignIdCbx.Items.Add(tr.TrainingID + "-" + tr.TrainingType + " " + tr.TrainingDate.ToString("dd-MM-yyyy HH:mm"));
                    }
                }
            }
        }

        private void editIdCbx_SelectedIndexChanged(object sender, EventArgs e) //Adds the details of the selected training to the edit tab boxes
        {
            if (editIdCbx.Text != "")
            {
                string[] idSplit = editIdCbx.Text.Split('-');
                Training t = AccessClasses.TrainingAccess.GetTrainingById(idSplit[0]);

                editTypeTxt.Text = t.TrainingType;
                editDurationCbx.Text = t.Duration + " Minutes";
                editDateDtp.Value = t.TrainingDate.Date;
                editTimeDtp.Value = t.TrainingDate;
            }
            else
            {
                editTypeTxt.Text = "";
                editDurationCbx.SelectedIndex = 0;
            }
        }

        private void editBtn_Click(object sender, EventArgs e) //Edits a training in the system with the added details if they meet validation
        {
            dateAndTime = editDateDtp.Value;
            string time = editTimeDtp.Value.ToString("HH:mm");
            string[] timeSplit = time.Split(':');
            int Hour = Int32.Parse(timeSplit[0]);
            int Min = Int32.Parse(timeSplit[1].Substring(0, 2));

            dateAndTime = dateAndTime.Date + new TimeSpan(Hour, Min, 0);

            string[] idSplit = editIdCbx.Text.Split('-');

            if (Validation(dateAndTime, new TimeSpan(Hour, Min, 0), editDurationCbx.Text, editTypeTxt.Text))
            {
                if (editDateDtp.Value.Date >= DateTime.Now.Date) //Makes sure you can't edit a training that has happened
                {
                    int id = Int32.Parse(idSplit[0]);

                    Training training = new Training(id, editTypeTxt.Text, dateAndTime, Int32.Parse(editDurationCbx.Text.Substring(0, editDurationCbx.Text.Length - 8)));
                    double rows = AccessClasses.TrainingAccess.EditTraining(training);

                    if (rows == 1)
                    {
                        MessageBox.Show("Training has been successfully edited in the database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        editIdCbx.Items.Clear();
                        deleteIdCbx.Items.Clear();
                        assignIdCbx.Items.Clear();

                        editIdCbx.Items.Add("");
                        deleteIdCbx.Items.Add("");
                        assignIdCbx.Items.Add("");

                        List<Training> trainingList = AccessClasses.TrainingAccess.GetAllTraining();
                        foreach (Training tr in trainingList) //Updates the trainings with the edited training
                        {
                            editIdCbx.Items.Add(tr.TrainingID + "-" + tr.TrainingType + " " + tr.TrainingDate.ToString("dd-MM-yyyy HH:mm"));
                            deleteIdCbx.Items.Add(tr.TrainingID + "-" + tr.TrainingType + " " + tr.TrainingDate.ToString("dd-MM-yyyy HH:mm"));
                            assignIdCbx.Items.Add(tr.TrainingID + "-" + tr.TrainingType + " " + tr.TrainingDate.ToString("dd-MM-yyyy HH:mm"));
                        }

                        editIdCbx.SelectedIndex = 0;
                    }
                    else
                    {
                        MessageBox.Show("Training has not been edited in the database.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else MessageBox.Show("You cannot edit a training that has already happened", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void assignIdCbx_SelectedIndexChanged(object sender, EventArgs e) //Updates the boxes on the assign tab with the selected training
        {
            if (assignIdCbx.Text != "")
            {
                string[] idSplit = assignIdCbx.Text.Split('-');
                Training t = AccessClasses.TrainingAccess.GetTrainingById(idSplit[0]);

                assignTypeTxt.Text = t.TrainingType;
                assignDurTxt.Text = t.Duration + " Minutes";
                assignDateDtp.Value = t.TrainingDate.Date;
                assignTimeDtp.Value = t.TrainingDate;

                dateAndTime = t.TrainingDate;
                string time = t.TrainingDate.ToString("HH:mm");
                string[] timeSplit = time.Split(':');
                int Hour = Int32.Parse(timeSplit[0]);
                int Min = Int32.Parse(timeSplit[1].Substring(0, 2));

                dateAndTime = dateAndTime.Date + new TimeSpan(Hour, Min, 0);

                List<Staff> validStaff = AccessClasses.TrainingAccess.AvailableStaff(dateAndTime, dateAndTime.AddMinutes(t.Duration)); //Gets staff available at the selected time
                List<Staff> assignedStaff = AccessClasses.TrainingAccess.GetStaffOnTraining(t.TrainingID); //Gets staff already assigned to the training
                assignStaffIdCbx.Items.Clear();
                assignStaffIdCbx.Items.Add("");

                validStaff = validStaff.OrderBy(x => x.StaffID).ToList();

                foreach (Staff s in assignedStaff) //Adds assigned staff to the combo box with the word "ASSIGNED" to show they are already on the training
                {
                    assignStaffIdCbx.Items.Add(s.StaffID + "-ASSIGNED " + s.FirstName + " " + s.SecondName);
                }

                foreach (Staff s in validStaff) //Adds the staff available at the time to the combo box
                {
                    if (s.JobTitle == "Driver" || s.JobTitle == "Assistant Driver")
                    {
                        assignStaffIdCbx.Items.Add(s.StaffID + "-" + s.FirstName + " " + s.SecondName);
                    }
                }
                assignFNameTxt.Text = "";
                assignSNameTxt.Text = "";
                assignTitleTxt.Text = "";

            }
            else
            {
                assignTypeTxt.Text = "";
                assignDurTxt.Text = "";
                assignFNameTxt.Text = "";
                assignSNameTxt.Text = "";
                assignTitleTxt.Text = "";
            }
        }

        private void assignStaffIdCbx_SelectedIndexChanged(object sender, EventArgs e) //Changes the details of the boxes for staff in the assign tab to the details of the selected staff
        {
            if (assignStaffIdCbx.Text != "")
            {
                string[] idSplit = assignStaffIdCbx.Text.Split('-');
                Staff st = AccessClasses.StaffAccess.GetStaffById(Int32.Parse(idSplit[0]));
                assignFNameTxt.Text = st.FirstName;
                assignSNameTxt.Text = st.SecondName;
                assignTitleTxt.Text = st.JobTitle;
            }
            else
            {
                assignFNameTxt.Text = "";
                assignSNameTxt.Text = "";
                assignTitleTxt.Text = "";
            }
        }

        private void assignBtn_Click(object sender, EventArgs e) //Assigns a selected staff member to a selected training
        {
            if (!assignStaffIdCbx.Text.Contains("ASSIGNED") && assignIdCbx.Text != "") //If the staff member is not already assigned
            {
                string[] staffSplit = assignStaffIdCbx.Text.Split('-');
                string[] trainSplit = assignIdCbx.Text.Split('-');

                double rows = AccessClasses.TrainingAccess.AssignStaff(Int32.Parse(trainSplit[0]), Int32.Parse(staffSplit[0]));

                if (rows == 1)
                {
                    MessageBox.Show("Staff has been succesfully assigned to training", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    assignIdCbx.SelectedIndex = 0;
                    assignStaffIdCbx.Items.Clear();
                }
            }
            else if (assignStaffIdCbx.Text != "" && assignIdCbx.Text != "") //If the staff member has already been assigned
            {
                MessageBox.Show("This staff member is currently assigned and cannot be assigned again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else MessageBox.Show("Please do not leave any boxes blank", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void unassignBtn_Click(object sender, EventArgs e) //Unassigns a selected staff member from a selected training
        {
            if (assignStaffIdCbx.Text.Contains("ASSIGNED") && assignIdCbx.Text != "") //If the staff member is assigned
            {
                string[] staffSplit = assignStaffIdCbx.Text.Split('-');
                string[] trainSplit = assignIdCbx.Text.Split('-');

                double rows = AccessClasses.TrainingAccess.UnAssignStaff(Int32.Parse(trainSplit[0]), Int32.Parse(staffSplit[0]));

                if (rows == 1)
                {
                    MessageBox.Show("Staff has been succesfully removed from training", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    assignIdCbx.SelectedIndex = 0;
                    assignStaffIdCbx.Items.Clear();
                }
            }
            else if (assignStaffIdCbx.Text != "" && assignIdCbx.Text != "") //If the staff member is not already assigned
            {
                MessageBox.Show("This staff member is not currently assigned and cannot be unassigned", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else MessageBox.Show("Please do not leave any boxes blank", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void deleteBtn_Click(object sender, EventArgs e) //Deletes a training the user has selected from the system
        {
            if (deleteIdCbx.Text != "")
            {
                if (deleteDateDtp.Value.Date >= DateTime.Now.Date) //If the training was not before today
                {
                    string[] id = deleteIdCbx.Text.Split('-');
                    int rowsAffected = AccessClasses.TrainingAccess.DeleteTraining(Int32.Parse(id[0]));

                    if (rowsAffected != 0)
                    {
                        MessageBox.Show("Training has been successfully deleted from the database", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        foreach (Control co in this.deleteTab.Controls)
                        {
                            if (co is TextBox)
                            {
                                co.Text = "";
                            }
                        }

                        List<Training> training = AccessClasses.TrainingAccess.GetAllTraining();
                        editIdCbx.Items.Clear();
                        deleteIdCbx.Items.Clear();

                        editIdCbx.Items.Add("");
                        deleteIdCbx.Items.Add("");

                        foreach (Training t in training) //Update the training combo boxes with the deleted training
                        {
                            editIdCbx.Items.Add(t.TrainingID + "-" + t.TrainingType + " " + t.TrainingDate.ToString("dd-MM-yyyy HH:mm"));
                            deleteIdCbx.Items.Add(t.TrainingID + "-" + t.TrainingType + " " + t.TrainingDate.ToString("dd-MM-yyyy HH:mm"));
                            assignIdCbx.Items.Add(t.TrainingID + "-" + t.TrainingType + " " + t.TrainingDate.ToString("dd-MM-yyyy HH:mm"));
                        }
                    }
                    else MessageBox.Show("Training has not been successfully deleted from the database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else MessageBox.Show("You cannot delete a training that has already happened", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else MessageBox.Show("Do not leave any boxes blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void deleteIdCbx_SelectedIndexChanged(object sender, EventArgs e) //Changes the boxes in the delete tab to be that of the selected training
        {
            if (deleteIdCbx.Text != "")
            {
                string[] idSplit = deleteIdCbx.Text.Split('-');
                Training t = AccessClasses.TrainingAccess.GetTrainingById(idSplit[0]);
                deleteTypeTxt.Text = t.TrainingType;
                deleteDateDtp.Value = t.TrainingDate;
                deleteTimeDtp.Value = t.TrainingDate;
                deleteDurationTxt.Text = t.Duration.ToString();
            }
            else
            {
                deleteTypeTxt.Text = "";
                deleteDurationTxt.Text = "";
            }
        }

        public bool Validation(DateTime date, TimeSpan time, string dur, string type) //Checks if the added details meet the required validation
        {
            if (type != "" && dur != "") //If nothing is blank
            {
                int duration = Int32.Parse(dur.Substring(0, dur.Length - 8));

                if (duration >= 60)
                {
                    minutes = duration % 60;
                    hours = (duration - (duration % 60)) / 60;
                }
                else
                {
                    hours = 0;
                    minutes = duration;
                }

                if (date.Date > DateTime.Today.Date) //If training is not before today
                {
                    if ((time >= new TimeSpan(9, 0, 0)) && (new TimeSpan(time.Hours + hours, time.Minutes + minutes, 0) <= new TimeSpan(17, 0, 0))) //If training is between 9AM and 5PM
                    {
                        return true;
                    }
                    else MessageBox.Show("Please select a time and duration that falls between the working hours of 9am to 5pm", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else MessageBox.Show("Please select a valid future date", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else MessageBox.Show("Do not leave any boxes blank", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            return false;
        }
    }
}
