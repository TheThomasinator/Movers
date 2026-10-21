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
    public partial class VanMenu : Form
    {
        DataTable myTable = new DataTable();
        string size = "size";
        string reg = "= registrationPlate";
        string make = "= make";

        public VanMenu()
        {
            InitializeComponent();
            sizeCbx.Items.Add("");
            sizeCbx.Items.Add("Small");
            sizeCbx.Items.Add("Medium");
            sizeCbx.Items.Add("Large");
            CreateTable();
        }

        public void CreateTable() //Adds the filtered results into the table
        {
            myTable = new DataTable();
            myTable.Columns.Add("Size");
            myTable.Columns.Add("Registration Plate");
            myTable.Columns.Add("Make");

            List<Van> vlist = AccessClasses.VanAccess.GetFilteredVans(size, reg, make);

            foreach (Van van in vlist)
            {
                myTable.Rows.Add(van.Size, van.RegistrationPlate, van.Make);
            }
            vanDGV.DataSource = myTable;
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
            VanAED van = new VanAED();
            this.Hide();
            van.Show();
        }

        private void sizeCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sizeCbx.Text == "")
            {
                size = "size";
            }
            else size = "'" + sizeCbx.Text + "'";
            CreateTable();
        }

        private void regTxt_TextChanged(object sender, EventArgs e)
        {
            if (regTxt.Text == "")
            {
                reg = "= registrationPlate";
            }
            else reg = "LIKE '" + regTxt.Text + "%'";
            CreateTable();
        }

        private void makeTxt_TextChanged(object sender, EventArgs e)
        {
            if (makeTxt.Text == "")
            {
                make = "= make";
            }
            else make = "LIKE '" + makeTxt.Text + "%'";
            CreateTable();
        }
    }
}
