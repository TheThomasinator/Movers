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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void jobBtn_Click(object sender, EventArgs e)
        {
            JobsMenu job = new JobsMenu();
            this.Hide();
            job.Show();
        }

        private void staffBtn_Click(object sender, EventArgs e)
        {
            StaffMenu staff = new StaffMenu();
            this.Hide();
            staff.Show();
        }

        private void maintenanceBtn_Click(object sender, EventArgs e)
        {
            MaintenanceMenu main = new MaintenanceMenu();
            this.Hide();
            main.Show();
        }

        private void trainingBtn_Click(object sender, EventArgs e)
        {
            TrainingMenu train = new TrainingMenu();
            this.Hide();
            train.Show();
        }

        private void stockBtn_Click(object sender, EventArgs e)
        {
            StockMenu stock = new StockMenu();
            this.Hide();
            stock.Show();
        }

        private void scheduleBtn_Click(object sender, EventArgs e)
        {
            DailySchedule daily = new DailySchedule();
            this.Hide();
            daily.Show();
        }

        private void vanBtn_Click(object sender, EventArgs e)
        {
            VanMenu van = new VanMenu();
            this.Hide();
            van.Show();
        }

        private void bookingsBtn_Click(object sender, EventArgs e)
        {
            BookingsNeeded book = new BookingsNeeded();
            this.Hide();
            book.Show();
        }
    }
}
