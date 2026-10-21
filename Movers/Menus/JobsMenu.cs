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
    public partial class JobsMenu : Form
    {
        DataTable myTable = new DataTable();

        public JobsMenu()
        {
            InitializeComponent();
            CreateTable(AccessClasses.JobAccess.GetAllJobs(), AccessClasses.AddressAccess.GetAllAddresses());
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void mainMenuBtn_Click(object sender, EventArgs e)
        {
            MainMenu main = new MainMenu();
            this.Hide();
            main.Show();
        }

        public void CreateTable(List<Job> jlist, List<Address> aList)
        {
            myTable = new DataTable();
            myTable.Columns.Add("Job ID");
            myTable.Columns.Add("Job Type");
            myTable.Columns.Add("Date of Job");
            myTable.Columns.Add("First line");
            myTable.Columns.Add("Second Line");
            myTable.Columns.Add("Post Code");
            myTable.Columns.Add("County");
            myTable.Columns.Add("City");

            foreach(Job job in jlist) //Adds all jobs and its details to the table
            {
                foreach (Address add in aList)
                {
                    if (job.AddressID == add.AddressID)
                    {
                        myTable.Rows.Add(job.JobID, job.JobType, job.DateOfJob.ToString("dd-MM-yyyy"), add.FirstLine, add.SecondLine, add.PostCode, add.County, add.City);
                    }
                }
            }
            jobDGV.DataSource = myTable;
        }
    }
}
