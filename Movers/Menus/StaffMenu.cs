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
    public partial class StaffMenu : Form
    {
        DataTable myTable = new DataTable();
        string fName = "= firstName";
        string sName = "= lastName";
        string jobTitle = "jobTitle";
        string pOrF = "partOrFullTime";

        public StaffMenu()
        {
            InitializeComponent();
            string[] cbxTitleStr = { "", "Driver", "Assistant Driver", "Admin", "Maintenance Engineer", "Cleaner" };
            foreach (string str in cbxTitleStr) //Adds the job titkles to the combo box
            {
                titleCbx.Items.Add(str);
            }
            pOrFCbx.Items.Add("");
            pOrFCbx.Items.Add("Full");
            pOrFCbx.Items.Add("Part");

            CreateTable();

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        public void CreateTable() //Adds the filtered results to the table
        {
            myTable = new DataTable();
            myTable.Columns.Add("Staff Id");
            myTable.Columns.Add("First Name");
            myTable.Columns.Add("Second Name");
            myTable.Columns.Add("Job Title");
            myTable.Columns.Add("Part or Full Time");

            List<Staff> slist = AccessClasses.StaffAccess.GetFilteredStaff(fName, sName, pOrF, jobTitle);

            foreach (Staff staff in slist)
            {
                myTable.Rows.Add(staff.StaffID, staff.FirstName, staff.SecondName, staff.JobTitle, staff.PartOrFullTime);
            }
            staffDGV.DataSource = myTable;
        }



        private void aedBtn_Click(object sender, EventArgs e)
        {
            StaffAED staff = new StaffAED();
            this.Hide();
            staff.Show();
        }

        private void fNameTxt_TextChanged(object sender, EventArgs e)
        {
            if (fNameTxt.Text == "")
            {
                fName = "= firstName";
            }
            else fName = "LIKE '" + fNameTxt.Text + "%'";
            CreateTable();
        }

        private void sNameTxt_TextChanged(object sender, EventArgs e)
        {
            if (sNameTxt.Text == "")
            {
                sName = "= lastName";
            }
            else sName = "LIKE '" + sNameTxt.Text + "%'";
            CreateTable();
        }

        private void pOrFCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pOrFCbx.Text == "")
            {
                pOrF = "partOrFullTime";
            }
            else pOrF = "'" + pOrFCbx.Text + "'";
            CreateTable();
        }


        private void titleCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (titleCbx.Text == "")
            {
                jobTitle = "jobTitle";
            }
            else jobTitle = "'" + titleCbx.Text + "'";
            CreateTable();
        }

        private void mainMenuBtn_Click(object sender, EventArgs e)
        {
            MainMenu menu = new MainMenu();
            this.Hide();
            menu.Show();
        }
    }
}
