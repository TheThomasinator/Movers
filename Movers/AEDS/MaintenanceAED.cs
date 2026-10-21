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
    public partial class MaintenanceAED : Form
    {
        List<Van> vans = AccessClasses.VanAccess.GetAllVans();
        List<Maintenance> maintenances = AccessClasses.MaintenanceAccess.GetAllMaintenance();

        DateTime dateAndTime;

        public MaintenanceAED()
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

            addTypeCbx.Items.Add("");
            addTypeCbx.Items.Add("Repair");
            addTypeCbx.Items.Add("Monthly Checkup");
            addTypeCbx.Items.Add("MOT Checkup");
            addTypeCbx.Items.Add("MOT Exam");
            addTypeCbx.Items.Add("Full Service");

            editDurationCbx.Items.Add("");
            editDurationCbx.Items.Add("15 Minutes");
            editDurationCbx.Items.Add("30 Minutes");
            editDurationCbx.Items.Add("45 Minutes");
            editDurationCbx.Items.Add("60 Minutes");
            editDurationCbx.Items.Add("75 Minutes");
            editDurationCbx.Items.Add("90 Minutes");
            editDurationCbx.Items.Add("105 Minutes");
            editDurationCbx.Items.Add("120 Minutes");

            addEngineerIdCbx.Items.Add("");
            editEngineerIdCbx.Items.Add("");

            addDriverIdCbx.Items.Add("");
            editDriverIDCbx.Items.Add("");

            addVanIdCbx.Items.Add("");
            editVanIdCbx.Items.Add("");

            editIdCbx.Items.Add("");
            deleteIdCbx.Items.Add("");

            ChangeCbx(addDateDtp.Value, addTimeDtp.Value, 0, "Add");
            ChangeCbx(editDateDtp.Value, editTimeDtp.Value, 0, "Edit");

            maintenances = maintenances.OrderBy(x => x.MaintenanceID).ToList();
            foreach (Maintenance m in maintenances) //Populates the id boxes with all maintenances
            {
                editIdCbx.Items.Add(m.MaintenanceID + "- Van " + m.VanID + " " + m.MaintenanceDate.ToString("dd-MM-yyyy HH:mm"));
                deleteIdCbx.Items.Add(m.MaintenanceID + "- Van " + m.VanID + " " + m.MaintenanceDate.ToString("dd-MM-yyyy HH:mm"));
            }
        }

        #region Buttons
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            MaintenanceMenu maintenance = new MaintenanceMenu();
            this.Hide();
            maintenance.Show();
        }
        #endregion

        #region AEDButtons
        private void addBtn_Click(object sender, EventArgs e) //Adds a maintenance to the system with the added details from the user if they meet validation
        {
            dateAndTime = addDateDtp.Value;
            string time = addTimeDtp.Value.ToString("HH:mm");
            string[] timeSplit = time.Split(':');
            int Hour = Int32.Parse(timeSplit[0]);
            int Min = Int32.Parse(timeSplit[1].Substring(0, 2));

            dateAndTime = dateAndTime.Date + new TimeSpan(Hour, Min, 0); //Converts the duration from minutes to a timespan in hours and minutes

            string[] van = addVanIdCbx.Text.Split('-');
            string[] driver = addDriverIdCbx.Text.Split('-');
            string[] engineer = addEngineerIdCbx.Text.Split('-');

            if (Validation(dateAndTime, new TimeSpan(Hour, Min, 0), addDurationCbx.Text, addTypeCbx.Text, driver[0], engineer[0], van[0]))
            {
                int vanId = Int32.Parse(van[0]);
                int driverId = Int32.Parse(driver[0]);
                int engineerId = 0;
                if (addTypeCbx.Text != "MOT Exam") //An engineer Id is not needed for an MOT Exam 
                {
                    engineerId = Int32.Parse(engineer[0]);
                }

                Maintenance maintenance = new Maintenance(0, vanId, addTypeCbx.Text, dateAndTime, Int32.Parse(addDurationCbx.Text.Substring(0, addDurationCbx.Text.Length - 8)), addDetailsTxt.Text);
                double[] rows = AccessClasses.MaintenanceAccess.AddMaintenance(maintenance, engineerId, driverId);

                if (rows[0] == 1)
                {
                    MessageBox.Show("Maintenance has been successfully added to the database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    foreach (Control co in this.addTab.Controls)
                    {
                        if (co is TextBox)
                        {
                            co.Text = "";
                        }
                    }
                    addDriverIdCbx.SelectedIndex = 0;
                    addEngineerIdCbx.SelectedIndex = 0;
                    addVanIdCbx.SelectedIndex = 0;
                    addTypeCbx.SelectedIndex = 0;
                    addDurationCbx.SelectedIndex = 0;

                    if (addDurationCbx.SelectedIndex > 0) //Changes the combo boxes to have staff and vans that are available at the time and date selected
                    {
                        ChangeCbx(addDateDtp.Value, addTimeDtp.Value, Int32.Parse(addDurationCbx.Text.Substring(0, addDurationCbx.Text.Length - 8)), "Add");
                    }
                    else ChangeCbx(addDateDtp.Value, addTimeDtp.Value, 0, "Add");

                    editIdCbx.Items.Clear();
                    deleteIdCbx.Items.Clear();

                    editIdCbx.Items.Add("");
                    deleteIdCbx.Items.Add("");

                    List<Maintenance> maintenances = AccessClasses.MaintenanceAccess.GetAllMaintenance();
                    foreach (Maintenance m in maintenances) //Updates the id boxes with the added maintenance
                    {
                        editIdCbx.Items.Add(m.MaintenanceID + "- Van " + m.VanID + " " + m.MaintenanceDate.ToString("dd-MM-yyyy HH:mm"));
                        deleteIdCbx.Items.Add(m.MaintenanceID + "- Van " + m.VanID + " " + m.MaintenanceDate.ToString("dd-MM-yyyy HH:mm"));
                    }
                }
                else
                {
                    MessageBox.Show("Maintenance has not been added to the database.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void editBtn_Click(object sender, EventArgs e) //Edits the maintenance in the system with the added details if they meet the validation
        {
            dateAndTime = editDateDtp.Value;
            string time = editTimeDtp.Value.ToString("HH:mm");
            string[] timeSplit = time.Split(':');
            int Hour = Int32.Parse(timeSplit[0]);
            int Min = Int32.Parse(timeSplit[1].Substring(0, 2));

            dateAndTime = dateAndTime.Date + new TimeSpan(Hour, Min, 0); //Converts time from minutes to hours and minutes

            string[] van = editVanIdCbx.Text.Split('-');
            string[] driver = editDriverIDCbx.Text.Split('-');
            string[] engineer = editEngineerIdCbx.Text.Split('-');
            string[] id = editIdCbx.Text.Split('-');

            if (Validation(dateAndTime, new TimeSpan(Hour, Min, 0), editDurationCbx.Text, editTypeTxt.Text, driver[0], engineer[0], van[0]))
            {
                int vanId = Int32.Parse(van[0]);
                int driverId = Int32.Parse(driver[0]);
                int engineerId;
                if (editTypeTxt.Text == "MOT Exam") //An engineer is not needed if its an MOT Exam
                {
                    engineerId = 0;
                }
                else engineerId = Int32.Parse(engineer[0]);

                int mainId = Int32.Parse(id[0]);

                Maintenance maintenance = new Maintenance(mainId, vanId, editTypeTxt.Text, dateAndTime, Int32.Parse(editDurationCbx.Text.Substring(0, editDurationCbx.Text.Length - 8)), editDetailsTxt.Text);
                double rows = AccessClasses.MaintenanceAccess.EditMaintenance(maintenance, engineerId, driverId);

                if (rows == 1)
                {
                    MessageBox.Show("Maintenance has been successfully edited in the database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    foreach (Control co in this.editTab.Controls)
                    {
                        if (co is TextBox)
                        {
                            co.Text = "";
                        }
                    }
                    editDriverIDCbx.SelectedIndex = 0;
                    editEngineerIdCbx.SelectedIndex = 0;
                    editVanIdCbx.Text = "";
                    editDurationCbx.Text = "";
                    editIdCbx.SelectedIndex = 0;


                    if (addDurationCbx.SelectedIndex > 0) //Changes the combo boxes to have staff and vans that are available at the time and date selected
                    {
                        ChangeCbx(addDateDtp.Value, addTimeDtp.Value, Int32.Parse(addDurationCbx.Text.Substring(0, addDurationCbx.Text.Length - 8)), "Edit");
                    }
                    else ChangeCbx(addDateDtp.Value, addTimeDtp.Value, 0, "Edit");

                    editIdCbx.Items.Clear();
                    deleteIdCbx.Items.Clear();

                    editIdCbx.Items.Add("");
                    deleteIdCbx.Items.Add("");

                    List<Maintenance> maintenances = AccessClasses.MaintenanceAccess.GetAllMaintenance();
                    foreach (Maintenance m in maintenances) //Updates the id combo boxes with the edited maintenance
                    {
                        editIdCbx.Items.Add(m.MaintenanceID + "- Van " + m.VanID + " " + m.MaintenanceDate.ToString("dd-MM-yyyy HH:mm"));
                        deleteIdCbx.Items.Add(m.MaintenanceID + "- Van " + m.VanID + " " + m.MaintenanceDate.ToString("dd-MM-yyyy HH:mm"));
                    }
                }
                else
                {
                    MessageBox.Show("Maintenance has not been edited in the database.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e) //Deletes a maintenance that a user has selected from the system
        {
            if (deleteIdCbx.Text != "")
            {
                string[] id = deleteIdCbx.Text.Split('-');
                int rowsAffected = AccessClasses.MaintenanceAccess.DeleteMaintenance(Int32.Parse(id[0]));

                if (rowsAffected != 0)
                {
                    MessageBox.Show("Maintenance has been successfully deleted from the database", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    foreach (Control co in this.deleteTab.Controls)
                    {
                        if (co is TextBox)
                        {
                            co.Text = "";
                        }
                    }

                    List<Maintenance> maintenances = AccessClasses.MaintenanceAccess.GetAllMaintenance();
                    editIdCbx.Items.Clear();
                    deleteIdCbx.Items.Clear();

                    editIdCbx.Items.Add("");
                    deleteIdCbx.Items.Add("");

                    foreach (Maintenance m in maintenances) //Updates the id combo boxes with the removed maintenance
                    {
                        editIdCbx.Items.Add(m.MaintenanceID + "- Van " + m.VanID + " " + m.MaintenanceDate.ToString("dd-MM-yyyy HH:mm"));
                        deleteIdCbx.Items.Add(m.MaintenanceID + "- Van " + m.VanID + " " + m.MaintenanceDate.ToString("dd-MM-yyyy HH:mm"));
                    }

                }
                else MessageBox.Show("Maintenance has not been successfully deleted from the database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else MessageBox.Show("Do not leave any boxes blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        #endregion

        #region CbxChanges

        private void addTypeCbx_SelectedIndexChanged(object sender, EventArgs e) //If the type is changed to MOT Exam disable the enginner boxes so that they cannot be added as they are not needed
        {
            if (addTypeCbx.Text == "MOT Exam")
            {
                addEngineerIdCbx.SelectedIndex = 0;
                addEngineerIdCbx.Enabled = false;
            }
            else
            {
                addEngineerIdCbx.Enabled = true;
            }
        }

        private void addDriverIdCbx_SelectedIndexChanged(object sender, EventArgs e) //If the driver combo box is changed update the first name and second name boxes to that drivers name
        {
            if (addDriverIdCbx.SelectedIndex != 0)
            {
                string[] staffId = addDriverIdCbx.Text.Split('-');
                Staff driver = AccessClasses.StaffAccess.GetStaffById(Int32.Parse(staffId[0]));
                addDriverFNameTxt.Text = driver.FirstName;
                addDriverSNameTxt.Text = driver.SecondName;
            }
            else
            {
                addDriverFNameTxt.Text = "";
                addDriverSNameTxt.Text = "";
            }
        }

        private void editDriverIDCbx_SelectedIndexChanged_1(object sender, EventArgs e) //If the engineer combo box is changed update the first name and second name boxes to that engineers name
        {
            if (editDriverIDCbx.SelectedIndex != 0)
            {
                string[] staffId = editDriverIDCbx.Text.Split('-');
                Staff driver = AccessClasses.StaffAccess.GetStaffById(Int32.Parse(staffId[0]));
                editDriverFNameTxt.Text = driver.FirstName;
                editDriverSNameTxt.Text = driver.SecondName;
            }
            else
            {
                editDriverFNameTxt.Text = "";
                editDriverSNameTxt.Text = "";
            }
        }

        private void editDriverIdCbx_SelectedIndexChanged(object sender, EventArgs e) //If the driver combo box is changed update the first name and second name boxes to that drivers name
        {
            if (editDriverIDCbx.SelectedIndex != 0)
            {
                string[] staffId = editDriverIDCbx.Text.Split('-');
                Staff driver = AccessClasses.StaffAccess.GetStaffById(Int32.Parse(staffId[0]));
                editDriverFNameTxt.Text = driver.FirstName;
                editDriverSNameTxt.Text = driver.SecondName;
            }
            else
            {
                editDriverFNameTxt.Text = "";
                editDriverSNameTxt.Text = "";
            }
        }

        private void addEngineerIdCbx_SelectedIndexChanged(object sender, EventArgs e) //If the engineer combo box is changed update the first name and second name boxes to that engineers name
        {
            if (addEngineerIdCbx.SelectedIndex != 0)
            {
                string[] staffId = addEngineerIdCbx.Text.Split('-');
                Staff engineer = AccessClasses.StaffAccess.GetStaffById(Int32.Parse(staffId[0]));
                addEngineerFNameTxt.Text = engineer.FirstName;
                addEngineerSNameTxt.Text = engineer.SecondName;
            }
            else
            {
                addEngineerFNameTxt.Text = "";
                addEngineerSNameTxt.Text = "";
            }
        }

        private void addVanIdCbx_SelectedIndexChanged(object sender, EventArgs e) //If the van combo box is changed update the registration box to that vans registration 
        {
            if (addVanIdCbx.SelectedIndex != 0)
            {
                string[] vanId = addVanIdCbx.Text.Split('-');
                Van van = AccessClasses.VanAccess.GetVanById(Int32.Parse(vanId[0]));
                addVanRegtxt.Text = van.RegistrationPlate;
            }
            else
            {
                addVanRegtxt.Text = "";
            }
        }

        private void editEngineerIdCbx_SelectedIndexChanged(object sender, EventArgs e) //If the van combo box is changed update the registration box to that vans registration 
        {
            if (editEngineerIdCbx.SelectedIndex != 0)
            {
                string[] staffId = editEngineerIdCbx.Text.Split('-');
                Staff engineer = AccessClasses.StaffAccess.GetStaffById(Int32.Parse(staffId[0]));
                editEngineerFNameTxt.Text = engineer.FirstName;
                editEngineerSNameTxt.Text = engineer.SecondName;
            }
            else
            {
                editEngineerFNameTxt.Text = "";
                editEngineerSNameTxt.Text = "";
            }
        }

        private void addDurationCbx_SelectedIndexChanged(object sender, EventArgs e) //Change the combo boxes for staff and vans to be the vans and staff available at the new time
        {
            if (addDurationCbx.SelectedIndex > 0)
            {
                ChangeCbx(addDateDtp.Value, addTimeDtp.Value, Int32.Parse(addDurationCbx.Text.Substring(0, addDurationCbx.Text.Length - 8)), "Add");
            }
            else ChangeCbx(addDateDtp.Value, addTimeDtp.Value, 0, "Add");
        }

        private void editIdCbx_SelectedIndexChanged(object sender, EventArgs e) //Update the boxes in the edit tab to be the ones of the maintenance selected
        {
                if (editIdCbx.Text != "")
                {
                    string[] mainSplit = editIdCbx.Text.Split('-');
                    Maintenance main = AccessClasses.MaintenanceAccess.GetMaintenanceById(Int32.Parse(mainSplit[0]));

                    if (editDurationCbx.SelectedIndex > 0) //Change the combo boxes for staff and vans to be the vans and staff available at the new time
                {
                        ChangeCbx(editDateDtp.Value, editTimeDtp.Value, Int32.Parse(editDurationCbx.Text.Substring(0, editDurationCbx.Text.Length - 8)), "Edit");
                    }
                    else ChangeCbx(editDateDtp.Value, editTimeDtp.Value, 0, "Edit");

                    editTypeTxt.Text = main.MaintenanceType;
                    editDateDtp.Value = main.MaintenanceDate.Date;
                    editTimeDtp.Value = main.MaintenanceDate;
                    editDurationCbx.Text = main.Duration + " Minutes";
                    editDetailsTxt.Text = main.Details;

                    if (editTypeTxt.Text == "MOT Exam") //If its an MOT Exam an engineer is not needed so the combo box should be disabled
                    {
                        editEngineerIdCbx.SelectedIndex = 0;
                        editEngineerIdCbx.Enabled = false;
                    }
                    else
                    {
                        editEngineerIdCbx.Enabled = true;
                    }

                }
                else
                {
                    foreach (Control co in this.editTab.Controls)
                    {
                        if (co is TextBox)
                        {
                            co.Text = "";
                        }
                    }
                    editDriverIDCbx.SelectedIndex = 0;
                    editEngineerIdCbx.SelectedIndex = 0;
                    editVanIdCbx.Text = "";
                    editDurationCbx.Text = "";
                    editIdCbx.SelectedIndex = 0;
                }
            

        }

        private void deleteIdCbx_SelectedIndexChanged(object sender, EventArgs e) //Update the boxes in the delete tab to be the ones of the maintenance selected
        {
            if (deleteIdCbx.Text != "")
            {
                string[] mainSplit = deleteIdCbx.Text.Split('-');
                Maintenance main = AccessClasses.MaintenanceAccess.GetMaintenanceById(Int32.Parse(mainSplit[0]));

                deleteTypeTxt.Text = main.MaintenanceType;
                deleteDateDtp.Value = main.MaintenanceDate.Date;
                deleteTimeDtp.Value = main.MaintenanceDate;
                deleteDurationTxt.Text = main.Duration + " Minutes";
                deleteDetailsTxt.Text = main.Details;

                Staff driver = AccessClasses.MaintenanceAccess.GetDriver(main.MaintenanceID);
                deleteDriverIdTxt.Text = driver.StaffID + "- " + driver.FirstName + " " + driver.SecondName;
                deleteDriverFNameTxt.Text = driver.FirstName;
                deleteDriverSNameTxt.Text = driver.SecondName;

                if (main.MaintenanceType != "MOT Exam")  //If its not an mot exam then an engineer has been added so the boxes on the delete tab should have it added
                {
                    Staff engineer = AccessClasses.MaintenanceAccess.GetEngineer(main.MaintenanceID);
                    deleteEngineerIdTxt.Text = engineer.StaffID + "- " + engineer.FirstName + " " + engineer.SecondName;
                    deleteEngineerFNameTxt.Text = engineer.FirstName;
                    deleteEngineerSNameTxt.Text = engineer.SecondName;
                }
                else //If it is an mot exam then the details should not be added
                {
                    deleteEngineerIdTxt.Text = "";
                    deleteEngineerFNameTxt.Text = "";
                    deleteEngineerSNameTxt.Text = "";
                }

                Van van = AccessClasses.VanAccess.GetVanById(main.VanID);
                deleteVanIdTxt.Text = van.VanID + "- " + van.RegistrationPlate;
                deleteVanRegTxt.Text = van.RegistrationPlate;
            }
            else
            {
                foreach (Control co in this.deleteTab.Controls)
                {
                    if (co is TextBox)
                    {
                        co.Text = "";
                    }
                }
            }

        }

        private void editDurationCbx_SelectedIndexChanged(object sender, EventArgs e)  //Change the combo boxes for staff and vans to be the vans and staff available at the new time
        {
            if (editDurationCbx.Text != "")
            {
                ChangeCbx(editDateDtp.Value, editTimeDtp.Value, Int32.Parse(editDurationCbx.Text.Substring(0, editDurationCbx.Text.Length - 8)), "Edit");
            }
            else ChangeCbx(editDateDtp.Value, editTimeDtp.Value, 0, "Edit");
        }
        private void editVanIdCbx_SelectedIndexChanged(object sender, EventArgs e) //Add the details of the selected van to the boxes on the edit tab 
        {
            if (editVanIdCbx.SelectedIndex != 0)
            {
                string[] vanId = editVanIdCbx.Text.Split('-');
                Van van = AccessClasses.VanAccess.GetVanById(Int32.Parse(vanId[0]));
                editVanRegTxt.Text = van.RegistrationPlate;
            }
            else
            {
                editVanRegTxt.Text = "";
            }
        }

        #endregion

        #region Methods
        public void ChangeCbx(DateTime dateVal, DateTime timeVal, int duration, string addOrEdit)  //Change the combo boxes for staff and vans to be the vans and staff available at the new time
        {
            dateAndTime = dateVal;
            string time = timeVal.ToString("HH:mm");
            string[] timeSplit = time.Split(':');
            int Hour = Int32.Parse(timeSplit[0]);
            int Min = Int32.Parse(timeSplit[1].Substring(0, 2));

            dateAndTime = dateAndTime.Date + new TimeSpan(Hour, Min, 0); //Converts the duration from minutes to hours and minutes

            List<Staff> validStaff = AccessClasses.MaintenanceAccess.AvailableStaff(dateAndTime, dateAndTime.AddMinutes(duration)); //Staff available at the time selected

            List<Van> validVans = AccessClasses.MaintenanceAccess.AvailableVans(dateAndTime, dateAndTime.AddMinutes(duration)); //Vans available at the time selected

            validStaff = validStaff.OrderBy(x => x.StaffID).ToList(); //Order the list by id
            validVans = validVans.OrderBy(x => x.VanID).ToList(); //Order the list by id

            if (addOrEdit == "Add")
            {
                addDriverIdCbx.Items.Clear();
                addDriverFNameTxt.Clear();
                addDriverSNameTxt.Clear();
                addDriverIdCbx.Items.Add("");

                addEngineerIdCbx.Items.Clear();
                addEngineerFNameTxt.Clear();
                addEngineerSNameTxt.Clear();
                addEngineerIdCbx.Items.Add("");

                addVanIdCbx.Items.Clear();
                addVanRegtxt.Clear();
                addVanIdCbx.Items.Add("");
            }
            else
            {    
                editDriverIDCbx.Items.Clear();
                editDriverFNameTxt.Clear();
                editDriverSNameTxt.Clear();
                editDriverIDCbx.Items.Add("");

                editEngineerIdCbx.Items.Clear();
                editEngineerFNameTxt.Clear();
                editEngineerSNameTxt.Clear();
                editEngineerIdCbx.Items.Add("");

                editVanIdCbx.Items.Clear();
                editVanRegTxt.Clear();
                editVanIdCbx.Items.Add("");

                if (editIdCbx.Text != "") //Gets the staff currenly assigned to the maintenance and adds it to the combo box with "CURRENT" to signify currently assigned staff
                {
                    string[] idSplit = editIdCbx.Text.Split('-');
                    Staff driver = AccessClasses.MaintenanceAccess.GetDriver(Int32.Parse(idSplit[0]));
                    Staff engineer = AccessClasses.MaintenanceAccess.GetEngineer(Int32.Parse(idSplit[0]));
                    Van van = AccessClasses.MaintenanceAccess.GetVan(Int32.Parse(idSplit[0]));
                    editDriverIDCbx.Items.Add(driver.StaffID + "- CURRENT- " + driver.FirstName + " " + driver.SecondName);
                    editEngineerIdCbx.Items.Add(engineer.StaffID + "- CURRENT- " + engineer.FirstName + " " + engineer.SecondName);
                    editVanIdCbx.Items.Add(van.VanID + "- CURRENT- " + van.RegistrationPlate);
                }
            }

            foreach (Van v in validVans) //Adds the available vans to the combo boxes
            {
                if (addOrEdit == "Add")
                {
                    addVanIdCbx.Items.Add(v.VanID + "- " + v.RegistrationPlate);
                }
                else
                {
                    editVanIdCbx.Items.Add(v.VanID + "- " + v.RegistrationPlate);
                }
            }

            foreach (Staff e in validStaff) //Adds the available staff to the combo boxes
            {
                if (addOrEdit == "Add")
                {
                    if (e.JobTitle == "Maintenance Engineer")
                    {
                        addEngineerIdCbx.Items.Add(e.StaffID + "- " + e.FirstName + " " + e.SecondName);
                    }
                    else if (e.JobTitle == "Driver")
                    {
                        addDriverIdCbx.Items.Add(e.StaffID + "- " + e.FirstName + " " + e.SecondName);
                    }
                }
                else
                {
                    if (e.JobTitle == "Maintenance Engineer")
                    {
                        editEngineerIdCbx.Items.Add(e.StaffID + "- " + e.FirstName + " " + e.SecondName);
                    }
                    else if (e.JobTitle == "Driver")
                    {
                        editDriverIDCbx.Items.Add(e.StaffID + "- " + e.FirstName + " " + e.SecondName);
                    }
                }
            }
        }

        public bool Validation(DateTime date, TimeSpan time, string dur, string type, string driverId, string engId, string vanId) //Checks to see if the entered ddetails meet required validation
        {
            int minutes = 0;
            int hours = 0;

            if (type != "" && driverId != "" && vanId != "" && dur != "") //If no boxes are blank
            {
                if ((engId == "" && type == "MOT Exam") || (engId != "" && type != "MOT Exam")) //If type is mot exam an engineer is not needed OR if type is not mot exam an engineer is needed
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

                    if (date.Date > DateTime.Today.Date) //If the date is after today
                    {
                        if ((time >= new TimeSpan(9, 0, 0)) && (new TimeSpan(time.Hours + hours, time.Minutes + minutes, 0) <= new TimeSpan(17, 0, 0))) //If the time is between 9AM and 5PM
                        {
                            return true;
                        }
                        else MessageBox.Show("Please select a time and duration that falls between the working hours of 9am to 5pm", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else MessageBox.Show("Please select a valid future date", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else MessageBox.Show("Please fill all boxes", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else MessageBox.Show("Please fill all boxes", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            return false;
        }

        #endregion

        #region DtpChanges

        private void addDateDtp_ValueChanged(object sender, EventArgs e)  //Change the combo boxes for staff and vans to be the vans and staff available at the new time
        {
            if (addDurationCbx.SelectedIndex > 0) //The selected index auto defaults to -1, therefore to prevent it trying to take a null duration a conditional statement is needed to check for -1
            {
                ChangeCbx(addDateDtp.Value, addTimeDtp.Value, Int32.Parse(addDurationCbx.Text.Substring(0, addDurationCbx.Text.Length - 8)), "Add");
            }
            else ChangeCbx(addDateDtp.Value, addTimeDtp.Value, 0, "Add");
        }

        private void addTimeDtp_ValueChanged(object sender, EventArgs e)  //Change the combo boxes for staff and vans to be the vans and staff available at the new time
        {
            if (addDurationCbx.SelectedIndex > 0) //The selected index auto defaults to -1, therefore to prevent it trying to take a null duration a conditional statement is needed to check for -1
            {
                ChangeCbx(addDateDtp.Value, addTimeDtp.Value, Int32.Parse(addDurationCbx.Text.Substring(0, addDurationCbx.Text.Length - 8)), "Add");
            }
            else ChangeCbx(addDateDtp.Value, addTimeDtp.Value, 0, "Add");
        }

        private void editDateDtp_ValueChanged(object sender, EventArgs e)  //Change the combo boxes for staff and vans to be the vans and staff available at the new time
        {
            if (editDurationCbx.SelectedIndex > 0) //The selected index auto defaults to -1, therefore to prevent it trying to take a null duration a conditional statement is needed to check for -1
            {
                ChangeCbx(editDateDtp.Value, editTimeDtp.Value, Int32.Parse(editDurationCbx.Text.Substring(0, editDurationCbx.Text.Length - 8)), "Edit");
            }
            else ChangeCbx(editDateDtp.Value, editTimeDtp.Value, 0, "Edit");
        }

        private void editTimeDtp_ValueChanged(object sender, EventArgs e)  //Change the combo boxes for staff and vans to be the vans and staff available at the new time
        {
            if (editDurationCbx.SelectedIndex > 0) //The selected index auto defaults to -1, therefore to prevent it trying to take a null duration a conditional statement is needed to check for -1
            {
                ChangeCbx(editDateDtp.Value, editTimeDtp.Value, Int32.Parse(editDurationCbx.Text.Substring(0, editDurationCbx.Text.Length - 8)), "Edit");
            }
            else ChangeCbx(editDateDtp.Value, editTimeDtp.Value, 0, "Edit");
        }
        #endregion


    }
}
