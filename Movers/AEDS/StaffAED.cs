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
    public partial class StaffAED : Form
    {

        int digitCheck = 0;
        int specialCheck = 0;
        int spaceCheck = 0;
        string id;

        public StaffAED()
        {
            InitializeComponent();

            string[] cbxTitleStr = { "", "Driver", "Assistant Driver", "Admin", "Maintenance Engineer", "Cleaner" };

            foreach (string str in cbxTitleStr) //Adds the job titles to the combo boxes
            {
                addTitleCbx.Items.Add(str);
                editTitleCbx.Items.Add(str);
            }

            addPorFCbx.Items.Add("");
            addPorFCbx.Items.Add("Full");
            addPorFCbx.Items.Add("Part");
            editPorFCbx.Items.Add("");
            editPorFCbx.Items.Add("Full");
            editPorFCbx.Items.Add("Part");

            editIdCbx.Items.Add("");
            deleteIdCbx.Items.Add("");

            List<Staff> staff = AccessClasses.StaffAccess.GetAllStaff();
            foreach (Staff s in staff) //Adds the staff to the combo boces
            {
                editIdCbx.Items.Add(s.StaffID + "-" + s.FirstName + " " + s.SecondName);
                deleteIdCbx.Items.Add(s.StaffID + "-" + s.FirstName + " " + s.SecondName);
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void mainMenuBtn_Click(object sender, EventArgs e)
        {
            StaffMenu staff = new StaffMenu();
            this.Hide();
            staff.Show();
        }

        private void editIdCbx_SelectedIndexChanged(object sender, EventArgs e) //Changes the details in the edit tab to the selected staff
        {
            if (editIdCbx.SelectedItem.ToString() != "")
            {
                id = editIdCbx.SelectedItem.ToString();
                digitCheck = 0;
                foreach (char c in id)
                {
                    if (char.IsDigit(c))
                    {
                        digitCheck++;
                    }
                }
                id = id.Substring(0, digitCheck);

                Staff staff = AccessClasses.StaffAccess.GetStaffById(Int32.Parse(id));
                editFNameTxt.Text = staff.FirstName;
                editSNameTxt.Text = staff.SecondName;
                editTitleCbx.Text = staff.JobTitle;
                editPorFCbx.Text = staff.PartOrFullTime;
            }
            else
            {
                editFNameTxt.Text = "";
                editSNameTxt.Text = "";
                editTitleCbx.Text = "";
                editPorFCbx.Text = "";
            }
        }

        private void deleteIdCbx_SelectedIndexChanged(object sender, EventArgs e) //Changes the details in the delete tab to the selected staff
        {          
            if (deleteIdCbx.SelectedItem.ToString() != "")
            {
                id = deleteIdCbx.SelectedItem.ToString();
                digitCheck = 0; 
                foreach (char c in id)
                {
                    if (char.IsDigit(c))
                    {
                        digitCheck++;
                    }
                }
                id = id.Substring(0, digitCheck);

                Staff staff = AccessClasses.StaffAccess.GetStaffById(Int32.Parse(id));
                deleteFNameTxt.Text = staff.FirstName;
                deleteSNameTxt.Text = staff.SecondName;
                deleteTitleTxt.Text = staff.JobTitle;
                deletePorFTxt.Text = staff.PartOrFullTime;
            }
            else
            {
                deleteFNameTxt.Text = "";
                deleteSNameTxt.Text = "";
                deleteTitleTxt.Text = "";
                deletePorFTxt.Text = "";
            }
        }
        private void addBtn_Click(object sender, EventArgs e) //Adds a new staff member to the system with the added details from the user if they meet the validation
        {
            if (Validation(addFNameTxt.Text, addSNameTxt.Text, addPorFCbx.Text, addTitleCbx.Text))
            {
                Staff myStaff = new Staff(addFNameTxt.Text, addSNameTxt.Text, addTitleCbx.Text, addPorFCbx.Text, 0);
                double[] rows = AccessClasses.StaffAccess.AddStaff(myStaff);

                if (rows[0] == 1)
                {
                    MessageBox.Show("User has been successfully added to the database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    editIdCbx.Items.Clear();
                    deleteIdCbx.Items.Clear();
                    editIdCbx.Items.Add("");
                    deleteIdCbx.Items.Add("");
                    List<Staff> staff = AccessClasses.StaffAccess.GetAllStaff();
                    foreach (Staff s in staff) //Updates the combo boces with the new staff member
                    {
                        editIdCbx.Items.Add(s.StaffID + "-" + s.FirstName + " " + s.SecondName);
                        deleteIdCbx.Items.Add(s.StaffID + "-" + s.FirstName + " " + s.SecondName);
                    }

                    addPorFCbx.SelectedIndex = 0;
                    addTitleCbx.SelectedIndex = 0;

                    editPorFCbx.SelectedIndex = 0;
                    editTitleCbx.SelectedIndex = 0;

                    foreach (Control co in this.addTab.Controls)
                    {
                        if (co is TextBox)
                        {
                            co.Text = "";
                        }                       
                    }

                }
                else MessageBox.Show("User has not been added to the database.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void editBtn_Click(object sender, EventArgs e) //Edits a staff member in the system with the added details if they meet validation
        {
            if (editIdCbx.Text != "")
            {
                if (Validation(editFNameTxt.Text, editSNameTxt.Text, editPorFCbx.Text, editTitleCbx.Text))
                {
                    int result = 0;

                    id = editIdCbx.SelectedItem.ToString();
                    digitCheck = 0; 
                    foreach (char c in id)
                    {
                        if (char.IsDigit(c))
                        {
                            digitCheck++;
                        }
                    }
                    id = id.Substring(0, digitCheck);

                    Staff myStaff = new Staff(editFNameTxt.Text, editSNameTxt.Text, editTitleCbx.Text, editPorFCbx.Text, Int32.Parse(id));
                    result = AccessClasses.StaffAccess.EditStaff(myStaff);

                    if (result == 1)
                    {
                        MessageBox.Show("User has been successfully updated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        editIdCbx.Items.Clear();
                        deleteIdCbx.Items.Clear();
                        editIdCbx.Items.Add("");
                        deleteIdCbx.Items.Add("");

                        editIdCbx.SelectedIndex = 0;
                        deleteIdCbx.SelectedIndex = 0;

                        List<Staff> staff = AccessClasses.StaffAccess.GetAllStaff();
                        foreach (Staff s in staff) //Updates the boxes with the edited staff member
                        {
                            editIdCbx.Items.Add(s.StaffID + "-" + s.FirstName + " " + s.SecondName);
                            deleteIdCbx.Items.Add(s.StaffID + "-" + s.FirstName + " " + s.SecondName);
                        }

                        editPorFCbx.SelectedIndex = 0;
                        editTitleCbx.SelectedIndex = 0;

                        foreach (Control co in this.editTab.Controls)
                        {
                            if (co is TextBox)
                            {
                                co.Text = "";
                            }                           
                        }

                        foreach (Control co in this.deleteTab.Controls)
                        {
                            if (co is TextBox)
                            {
                                co.Text = "";
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("User has not been updated.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e) //Deletes a staff member from the system that the user has selected if the user selects yes when told what maintenances will be deleted
        {
            if (deleteIdCbx.Text != "")
            {
                id = deleteIdCbx.SelectedItem.ToString();
                digitCheck = 0; 
                foreach (char c in id) //Gets the id of the selected staff member
                {
                    if (char.IsDigit(c))
                    {
                        digitCheck++;
                    }
                }
                id = id.Substring(0, digitCheck);

                Staff myStaff = new Staff(deleteFNameTxt.Text, deleteSNameTxt.Text, deleteTitleTxt.Text, deletePorFTxt.Text, Int32.Parse(id));

                DialogResult diagResult = MessageBox.Show("Are you sure you want to delete this Staff member? It will remove these Maintenances: \n" + AccessClasses.MaintenanceAccess.MaintenanceByStaff(id), "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (diagResult == DialogResult.Yes)
                {
                    int result = AccessClasses.StaffAccess.DeleteStaff(myStaff.StaffID);

                    if (result == 1)
                    {
                        MessageBox.Show("User has been successfully deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        editIdCbx.Items.Clear();
                        deleteIdCbx.Items.Clear();
                        editIdCbx.Items.Add("");
                        deleteIdCbx.Items.Add("");

                        editIdCbx.SelectedIndex = 0;
                        editPorFCbx.SelectedIndex = 0;
                        editTitleCbx.SelectedIndex = 0;

                        List<Staff> staff = AccessClasses.StaffAccess.GetAllStaff();
                        foreach (Staff s in staff) //Updates the boxes with the deleted staff member
                        {
                            editIdCbx.Items.Add(s.StaffID + "-" + s.FirstName + " " + s.SecondName);
                            deleteIdCbx.Items.Add(s.StaffID + "-" + s.FirstName + " " + s.SecondName);
                        }

                        foreach (Control co in this.editTab.Controls)
                        {
                            if (co is TextBox)
                            {
                                co.Text = "";
                            }
                        }

                        foreach (Control co in this.deleteTab.Controls)
                        {
                            if (co is TextBox)
                            {
                                co.Text = "";
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("User has not been deleted from the database.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            else MessageBox.Show("Do not leave any boxes blank", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private bool Validation(string fName, string sName, string pOrF, string title) //Checks if the added details meet the required validation
        {
            digitCheck = 0;
            spaceCheck = 0;
            specialCheck = 0;

            if (fName != "" && sName != "" && pOrF!= "" && title != "") //Checks no boxes are blank
            {

                foreach (char c in fName)
                {
                    if (char.IsDigit(c))
                    {
                        digitCheck++;
                    }
                }

                foreach (char c in sName)
                {
                    if (char.IsDigit(c))
                    {
                        digitCheck++;
                    }
                }

                if (digitCheck == 0) //Checks names have no digits
                {
                    foreach (char c in fName)
                    {
                        if (char.IsWhiteSpace(c))
                        {
                            spaceCheck++;
                        }
                    }

                    foreach (char c in sName)
                    {
                        if (char.IsWhiteSpace(c))
                        {
                            spaceCheck++;
                        }
                    }

                    if (spaceCheck == 0) //Checks names have no spaces
                    {
                        foreach (char c in fName)
                        {
                            if (!char.IsLetter(c))
                            {
                                specialCheck++;
                            }
                        }

                        foreach (char c in sName)
                        {
                            if (!char.IsLetter(c))
                            {
                                specialCheck++;
                            }
                        }

                        if (specialCheck == 0) //Checks names have no special characters
                        {
                            return true;
                        }
                        else MessageBox.Show("Do not include special characters in any field", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else MessageBox.Show("Do not include spaces in any field", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else MessageBox.Show("Do not include numbers in any field", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else MessageBox.Show("Do not leave any boxes blank", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
    }
}

