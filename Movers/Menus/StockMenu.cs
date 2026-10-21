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
    public partial class StockMenu : Form
    {
        DataTable myTable = new DataTable();

        public StockMenu()
        {
            InitializeComponent();
            CreateTable(AccessClasses.StockAccess.GetAllStock());
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
            ItemAED stock = new ItemAED();
            this.Hide();
            stock.Show();
        }

        public void CreateTable(List<Stock> slist) //Adds the filtered results to the table 
        {
            myTable = new DataTable();
            myTable.Columns.Add("Stock ID");
            myTable.Columns.Add("Stock Name");
            myTable.Columns.Add("Price");
            myTable.Columns.Add("Quantity in stock");

            foreach (Stock stock in slist)
            {
                myTable.Rows.Add(stock.StockID, stock.StockName, stock.Price.ToString("C"), stock.QuantInStock);
            }
            stockDGV.DataSource = myTable;
        }

        private void reportBtn_Click(object sender, EventArgs e) //Creates a PDF with the filtered results 
        {
            PdfMaker p = new PdfMaker();
            p.CreatePdf(stockDGV, "StockReport");
        }

        private void reOrderBtn_Click(object sender, EventArgs e)
        {
            OrderStock order = new OrderStock();
            this.Close();
            order.Show();
        }
    }
}
