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
    public partial class VanAED : Form
    {
        int digitCheck, spaceCheck, specialCheck, letterCheck;
        string orgRegPlate;

        public VanAED()
        {
            InitializeComponent();

            editIdCbx.Items.Add("");
            deleteIdCbx.Items.Add("");

            List<Van> van = AccessClasses.VanAccess.GetAllVans();
            foreach (Van v in van) //Adds the vans to the combo boxes
            {
                editIdCbx.Items.Add(v.VanID + "-" + v.RegistrationPlate);
                deleteIdCbx.Items.Add(v.VanID + "-" + v.RegistrationPlate);
            }

            addSizeCbx.Items.Add("");
            addSizeCbx.Items.Add("Small");
            addSizeCbx.Items.Add("Medium");
            addSizeCbx.Items.Add("Large");

            editSizeCbx.Items.Add("");
            editSizeCbx.Items.Add("Small");
            editSizeCbx.Items.Add("Medium");
            editSizeCbx.Items.Add("Large");
        }

        private void editIdCbx_SelectedIndexChanged(object sender, EventArgs e) //Changes the boxes on the edit tab to the selected van
        {
            if (editIdCbx.SelectedItem.ToString() != "")
            {
                string[] idSplit = editIdCbx.SelectedItem.ToString().Split('-');
                Van van = AccessClasses.VanAccess.GetVanById(Int32.Parse(idSplit[0]));
                editSizeCbx.Text = van.Size;
                editRegPlateTxt.Text = van.RegistrationPlate;
                editMakeTxt.Text = van.Make;

                orgRegPlate = van.RegistrationPlate;
            }
            else
            {
                editSizeCbx.SelectedIndex = 0;
                editRegPlateTxt.Text = "";
                editMakeTxt.Text = "";
            }
        }

        private void deleteIdCbx_SelectedIndexChanged(object sender, EventArgs e)  //Changes the boxes on the delete tab to the selected van
        {
            if (deleteIdCbx.SelectedItem.ToString() != "")
            {
                string[] idSplit = deleteIdCbx.SelectedItem.ToString().Split('-');
                Van van = AccessClasses.VanAccess.GetVanById(Int32.Parse(idSplit[0]));
                deleteSizeTxt.Text = van.Size;
                deleteRegPlateTxt.Text = van.RegistrationPlate;
                deleteMakeTxt.Text = van.Make;
            }
            else
            {
                deleteSizeTxt.Text = "";
                deleteRegPlateTxt.Text = "";
                deleteMakeTxt.Text = "";
            }
        }

        private void addBtn_Click(object sender, EventArgs e) //Adds a new van to the system with the users added details if they meet validation 
        {
            if (Validation(addRegPlateTxt.Text, addMakeTxt.Text, addSizeCbx.Text, "Add"))
            {
                Van myVan = new Van(addSizeCbx.Text, addRegPlateTxt.Text, addMakeTxt.Text, 0);
                double[] rows = AccessClasses.VanAccess.AddVan(myVan);

                if (rows[0] == 1)
                {
                    MessageBox.Show("Van has been successfully added to the database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    editIdCbx.Items.Clear();
                    deleteIdCbx.Items.Clear();
                    editIdCbx.Items.Add("");
                    deleteIdCbx.Items.Add("");

                    List<Van> van = AccessClasses.VanAccess.GetAllVans();
                    foreach (Van v in van) //Updates the combo boxes with the new van
                    {
                        editIdCbx.Items.Add(v.VanID + "-" + v.RegistrationPlate);
                        deleteIdCbx.Items.Add(v.VanID + "-" + v.RegistrationPlate);
                    }

                    foreach (Control co in this.addTab.Controls)
                    {
                        if (co is TextBox)
                        {
                            co.Text = "";
                        }
                        addSizeCbx.SelectedIndex = 0;
                    }

                    foreach (Control co in this.editTab.Controls)
                    {
                        if (co is TextBox)
                        {
                            co.Text = "";
                        }
                        editSizeCbx.SelectedIndex = 0;
                    }

                    foreach (Control co in this.deleteTab.Controls)
                    {
                        if (co is TextBox)
                        {
                            co.Text = "";
                        }
                    }
                }
                else MessageBox.Show("Van has not been added to the database.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e) //Deletes the van the user selected from the system if the user confirms they want to when presented with what maintenances will be removed
        {
            if (deleteIdCbx.Text != "")
            {
                string[] idSplit = deleteIdCbx.Text.Split('-');

                Van myVan = new Van(deleteSizeTxt.Text, deleteRegPlateTxt.Text, deleteMakeTxt.Text, Int32.Parse(idSplit[0]));

                DialogResult diagResult = MessageBox.Show("Are you sure you want to delete this Van? It will remove these Maintenances: \n" + AccessClasses.MaintenanceAccess.MaintenancesByVan(idSplit[0]), "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (diagResult == DialogResult.Yes)
                {
                    int result = AccessClasses.VanAccess.DeleteVan(myVan.VanID);

                    if (result == 1)
                    {
                        MessageBox.Show("Van has been successfully deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        editIdCbx.Items.Clear();
                        deleteIdCbx.Items.Clear();
                        editIdCbx.Items.Add("");
                        deleteIdCbx.Items.Add("");

                        editIdCbx.SelectedIndex = 0;
                        deleteIdCbx.SelectedIndex = 0;

                        editSizeCbx.SelectedIndex = 0;

                        List<Van> van = AccessClasses.VanAccess.GetAllVans();
                        foreach (Van v in van) //Updates combo boxes with the deleted van
                        {
                            editIdCbx.Items.Add(v.VanID + "-" + v.RegistrationPlate);
                            deleteIdCbx.Items.Add(v.VanID + "-" + v.RegistrationPlate);
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
                        MessageBox.Show("Van has not been deleted from the database.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            else MessageBox.Show("Please fill all boxes", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void editBtn_Click(object sender, EventArgs e) //Edits a van in the system with the added details from user if they meet the validation
        {
            if (editIdCbx.Text != "")
            {
                if (Validation(editRegPlateTxt.Text, editMakeTxt.Text, editSizeCbx.SelectedItem.ToString(), "Edit"))
                {
                    int result = 0;
                    string[] idSplit = editIdCbx.Text.Split('-');                  

                    Van myVan = new Van(editSizeCbx.Text, editRegPlateTxt.Text, editMakeTxt.Text, Int32.Parse(idSplit[0]));
                    result = AccessClasses.VanAccess.EditVan(myVan);

                    if (result == 1)
                    {
                        MessageBox.Show("Van has been successfully updated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        editIdCbx.Items.Clear();
                        deleteIdCbx.Items.Clear();
                        editIdCbx.Items.Add("");
                        deleteIdCbx.Items.Add("");

                        editIdCbx.SelectedIndex = 0;
                        deleteIdCbx.SelectedIndex = 0;

                        editSizeCbx.SelectedIndex = 0;

                        List<Van> van = AccessClasses.VanAccess.GetAllVans();
                        foreach (Van v in van) //Updates combo boxes with edited van
                        {
                            editIdCbx.Items.Add(v.VanID + "-" + v.RegistrationPlate);
                            deleteIdCbx.Items.Add(v.VanID + "-" + v.RegistrationPlate);
                        }

                        foreach (Control co in this.editTab.Controls)
                        {
                            if (co is TextBox)
                            {
                                co.Text = "";
                            }

                            editIdCbx.SelectedIndex = 0;
                            editSizeCbx.SelectedIndex = 0;
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
                        MessageBox.Show("Van has not been updated.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill all boxes.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }



        private void menuBtn_Click(object sender, EventArgs e)
        {
            VanMenu van = new VanMenu();
            this.Hide();
            van.Show();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private bool Validation(string regPlate, string make, string size, string type) //Checks if the added details meet the required validation
        {
            digitCheck = 0;
            spaceCheck = 0;
            specialCheck = 0;

            if (regPlate != "" && make != "" && size != "") //If no boxes are blank
            {
                foreach (char c in make)
                {
                    if (char.IsDigit(c))
                    {
                        digitCheck++;
                    }
                }

                if (digitCheck == 0) //If the make has no digits
                {
                    foreach (char c in make)
                    {
                        if (char.IsWhiteSpace(c))
                        {
                            spaceCheck++;
                        }
                    }

                    if (spaceCheck == 0) //If the make has no spaces
                    {
                        foreach (char c in make)
                        {
                            if (!char.IsLetter(c))
                            {
                                specialCheck++;
                            }
                        }

                        if (specialCheck == 0) //If the make has no special characters
                        {
                            if (regPlate.Length == 8)
                            {
                                digitCheck = 0;
                                spaceCheck = 0;
                                letterCheck = 0;

                                foreach (char c in regPlate.Substring(0, 3))
                                {
                                    if (char.IsLetter(c))
                                    {
                                        letterCheck++;
                                    }
                                }

                                foreach (char c in regPlate.Substring(4, 4))
                                {
                                    if (char.IsDigit(c))
                                    {
                                        digitCheck++;
                                    }
                                }

                                if (letterCheck == 3 && digitCheck == 4 && char.IsWhiteSpace(regPlate[3])) //If the registration meets the format "AAA 1234"
                                {
                                    List<Van> vans = AccessClasses.VanAccess.GetAllVans();
                                    foreach (Van v in vans) //Checks if the new reg plate is already in the system
                                    {
                                        if (type == "Add")
                                        {
                                            if (v.RegistrationPlate == regPlate)
                                            {
                                                MessageBox.Show("This Registration Plate already exists", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                return false;
                                            }
                                        }
                                        else //if edit
                                        {
                                            if(v.RegistrationPlate == regPlate && regPlate != orgRegPlate)
                                            {
                                                MessageBox.Show("This Registration Plate already exists", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                return false;
                                            }
                                        }
                                    }
                                    return true; //If it does not return false i.e plate already exists or its an edit being made it will return true once the foreach is done
                                }
                                else MessageBox.Show("The reg plate should be in format AAA 1234", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else MessageBox.Show("The reg plate should be in format AAA 1234", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else MessageBox.Show("Do not include special characters in the van make field", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else MessageBox.Show("Do not include spaces in the van make field", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else MessageBox.Show("Do not include numbers in the van make field", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else MessageBox.Show("Do not leave any boxes blank", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
    }
}
