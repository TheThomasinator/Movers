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
    public partial class OrderStock : Form
    {
        List<Stock> currentStock = new List<Stock>();
        decimal totalOrderCost;

        public OrderStock()
        {
            InitializeComponent();
            List<Stock> stock = AccessClasses.StockAccess.GetAllStock();
            foreach (Stock s in stock) //Adds the items of stock to the combo box
            {
                stockCbx.Items.Add(s.StockID + "- " + s.StockName + " £" + s.Price.ToString());
            }

            List<Order> orders = AccessClasses.OrderAccess.GetAllOrders();
            foreach (Order or in orders) //Adds the orders to the combo box
            {
                if (!or.OrderArrived && or.Discrepancies == "")
                {
                    idCbx.Items.Add(or.OrderId + "- " + or.DateOrdered.ToString("dd-MM-yyyy") + " £" + or.TotalCost);
                }
            }

            foreach (Order or in orders) //Adds the orders to the combo box
            {
                if (!or.OrderArrived && or.Discrepancies != "")
                {
                    idCbx.Items.Add(or.OrderId + "- DISCREPANCIES " + or.DateOrdered.ToString("dd-MM-yyyy") + " £" + or.TotalCost);
                }
            }

            foreach (Order or in orders) //Adds the orders to the combo box
            {
                if (or.OrderArrived)
                {
                    idCbx.Items.Add(or.OrderId + "- ARRIVED " + or.DateOrdered.ToString("dd-MM-yyyy") + " £" + or.TotalCost);
                }
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            StockMenu menu = new StockMenu();
            this.Hide();
            menu.Show();
        }

        private void addStockbtn_Click(object sender, EventArgs e) //Adds the selected item of stock to a new order if the amount is above 0 
        {
            int amount = 0;
            if (stockCbx.Text != "" && amountTxt.Text != "")
            {
                if (Int32.TryParse(amountTxt.Text, out amount))
                {
                    if (amount >= 0)
                    {
                        bool existCheck = false;
                        string[] idSplit = stockCbx.Text.Split('-');
                        foreach (Stock s in currentStock) //If the stock has already been added then the amount will be adjusted to the new amount set
                        {
                            if (s.StockID == Int32.Parse(idSplit[0]))
                            {
                                existCheck = true;
                                if (amount > 0)
                                {
                                    s.QuantInStock = amount;
                                }
                                else
                                {
                                    currentStock.Remove(s);
                                }
                                break;                   
                            }
                        }                        

                        if (!existCheck) //If the stock was not previously in the list of stock on an order it will be added as long as the amount is above 0
                        {
                            if (amount > 0)
                            {
                                Stock stockDetails = AccessClasses.StockAccess.GetStockById(idSplit[0]);
                                stockDetails.QuantInStock = amount;
                                currentStock.Add(stockDetails);
                            }
                            else MessageBox.Show("Cannot add something of amount 0", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        CreateTable();
                    }
                    else MessageBox.Show("Amount must be a valid integer", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else MessageBox.Show("Amount must be a valid integer", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else MessageBox.Show("Fill all boxes", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void CreateTable() //Adds the stock on the order and its details to the table
        {
            DataTable table = new DataTable();
            table.Columns.Add("Stock Id");
            table.Columns.Add("Stock Name");
            table.Columns.Add("Price");
            table.Columns.Add("Quantity");
            table.Columns.Add("Item Total Cost");

            totalOrderCost = 0;

            foreach (Stock s in currentStock) //QuantInStock here actually refers to the amount chosen by the user, the variable is just repurposed for convenience
            {
                table.Rows.Add(s.StockID, s.StockName, "£" + s.Price, s.QuantInStock, "£" + s.Price * s.QuantInStock);
                totalOrderCost += s.QuantInStock * s.Price;
            }

            totalCostLbl.Text = "Total Cost: \n£" + totalOrderCost;

            orderDgv.DataSource = table;
        }


        private void addBtn_Click(object sender, EventArgs e) //Adds the order with the added stock to the system
        {
            if (currentStock.Count != 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to add this order? It cannot be removed or edited later", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    decimal totalCost = 0;
                    foreach (Stock s in currentStock) //Calculates total cost
                    {
                        totalCost += s.Price * s.QuantInStock;
                    }

                    Order order = new Order(0, DateTime.Today, false, totalCost, "");

                    double[] rows = AccessClasses.OrderAccess.AddOrder(order, currentStock);

                    if (rows[0] == 1)
                    {
                        idCbx.Items.Clear();
                        List<Order> orders = AccessClasses.OrderAccess.GetAllOrders();
                        foreach (Order or in orders) //Updates the combo box with the new order
                        {
                            if (!or.OrderArrived)
                            {
                                idCbx.Items.Add(or.OrderId + "- " + or.DateOrdered.ToString("dd-MM-yyyy") + " £" + or.TotalCost);
                            }
                        }

                        foreach (Order or in orders) //Updates the combo box with the new order
                        {
                            if (!or.OrderArrived && or.Discrepancies != "")
                            {
                                idCbx.Items.Add(or.OrderId + "- DISCREPANCIES " + or.DateOrdered.ToString("dd-MM-yyyy") + " £" + or.TotalCost);
                            }
                        }

                        foreach (Order or in orders) //Updates the combo box with the new order
                        {
                            if (or.OrderArrived)
                            {
                                idCbx.Items.Add(or.OrderId + "- ARRIVED " + or.DateOrdered.ToString("dd-MM-yyyy") + " £" + or.TotalCost);
                            }
                        }

                        MessageBox.Show("Order added succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        currentStock = new List<Stock>();
                        CreateTable();
                    }

                }
            }
            else MessageBox.Show("Can't add blank order", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void idCbx_SelectedIndexChanged(object sender, EventArgs e) //Updates the boxes and tabke on the manage tab to show the details of the selected order
        {
            if (idCbx.SelectedIndex != -1)
            {
                string[] idSplit = idCbx.Text.Split('-');
                Order order = AccessClasses.OrderAccess.GetOrderById(idSplit[0]);
                dateTxt.Text = order.DateOrdered.ToString("dd-MM-yyyy");
                costTxt.Text = "£" + order.TotalCost.ToString();
                discTxt.Text = order.Discrepancies;
                if (order.Discrepancies == "" && !order.OrderArrived) //Changes the text of the button based on if an order has not arrived, has arrived with discrepancies or if an order has been confirmed to have arrived
                {
                    discTxt.Enabled = true;
                    confirmBtn.Enabled = true;
                    confirmBtn.Text = "Confirm Order Arrived";
                }
                else if (order.Discrepancies != "" && !order.OrderArrived)
                {
                    discTxt.Enabled = false;
                    confirmBtn.Enabled = true;
                    discTxt.Text = order.Discrepancies;
                    confirmBtn.Text = "Confirm Discrepency fixed";
                }
                else
                {
                    confirmBtn.Enabled = false;
                    discTxt.Enabled = false;
                    confirmBtn.Text = "Already confirmed arrived";
                }

                DataTable table = new DataTable();
                table.Columns.Add("Stock Id");
                table.Columns.Add("Stock Name");
                table.Columns.Add("Price");
                table.Columns.Add("Quantity");
                table.Columns.Add("Item Total Cost");

                List<Stock> stock = AccessClasses.OrderAccess.GetStockOnOrder(idSplit[0]);          

                foreach (Stock s in stock)
                {
                    table.Rows.Add(s.StockID, s.StockName, "£" + s.Price, AccessClasses.OrderAccess.QuantOfStock(s.StockID.ToString(), idSplit[0]), "£" + s.Price * AccessClasses.OrderAccess.QuantOfStock(s.StockID.ToString(), idSplit[0]));
                }

                orderManageDgv.DataSource = table;
            }
        }

        private void confirmBtn_Click(object sender, EventArgs e) //Confirms if either the order has arrived with discrepancies, if an order has been confirmed to have arrived without them or if an orders discrepancies have been fixed
        {
            if (idCbx.Text != "")
            {
                string[] idSplit = idCbx.Text.Split('-');
                if (discTxt.Text == "")
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to confirm this order has no discrepancies? This cannot be undone", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        AccessClasses.OrderAccess.ConfirmOrderArrived(idSplit[0]);
                        List<Stock> orderStock = AccessClasses.OrderAccess.GetStockOnOrder(idSplit[0]);
                        List<Stock> currentStock = AccessClasses.StockAccess.GetAllStock();

                        foreach (Stock cs in currentStock) //Updates the stock in the system to add the stock that rrived with the order
                        {
                            foreach (Stock s in orderStock)
                            {
                                if (s.StockID == cs.StockID)
                                {
                                    cs.QuantInStock += AccessClasses.OrderAccess.QuantOfStock(s.StockID.ToString(), idSplit[0]);
                                    AccessClasses.StockAccess.EditStock(cs);
                                }
                            }
                        }
                    }
                }
                else if (discTxt.Text != "" && !discTxt.Text.Contains("DISCREPANCIES REPORTED"))
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to confirm this order has these discrepancies? This cannot be changed", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        string disc = discTxt.Text + " DISCREPANCIES REPORTED";
                        AccessClasses.OrderAccess.OrderDiscrepancies(idSplit[0], disc);
                    }
                }
                else if (discTxt.Text.Contains("DISCREPANCIES REPORTED"))
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to confirm the discrepancies on this order have been resolved? This cannot be undone", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        AccessClasses.OrderAccess.ConfirmOrderArrived(idSplit[0]);
                        List<Stock> orderStock = AccessClasses.OrderAccess.GetStockOnOrder(idSplit[0]);
                        List<Stock> currentStock = AccessClasses.StockAccess.GetAllStock();

                        foreach (Stock cs in currentStock)
                        {
                            foreach (Stock s in orderStock)
                            {
                                if (s.StockID == cs.StockID)
                                {
                                    cs.QuantInStock += AccessClasses.OrderAccess.QuantOfStock(s.StockID.ToString(), idSplit[0]);
                                    AccessClasses.StockAccess.EditStock(cs);
                                }
                            }
                        }
                    }
                }
                idCbx.Items.Clear();

                List<Order> orders = AccessClasses.OrderAccess.GetAllOrders();
                foreach (Order or in orders)  //Updates the combo box with the new order
                {
                    if (!or.OrderArrived && or.Discrepancies == "")
                    {
                        idCbx.Items.Add(or.OrderId + "- " + or.DateOrdered.ToString("dd-MM-yyyy") + " £" + or.TotalCost);
                    }
                }

                foreach (Order or in orders) //Updates the combo box with the new order
                {
                    if (!or.OrderArrived && or.Discrepancies != "")
                    {
                        idCbx.Items.Add(or.OrderId + "- DISCREPANCIES " + or.DateOrdered.ToString("dd-MM-yyyy") + " £" + or.TotalCost);
                    }
                }

                foreach (Order or in orders) //Updates the combo box with the new order
                {
                    if (or.OrderArrived)
                    {
                        idCbx.Items.Add(or.OrderId + "- ARRIVED " + or.DateOrdered.ToString("dd-MM-yyyy") + " £" + or.TotalCost);
                    }
                }

                idCbx.SelectedIndex = -1;
                discTxt.Clear();
                costTxt.Clear();
                dateTxt.Clear();
                orderManageDgv.DataSource = null;
            }
            else MessageBox.Show("Please select an order", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void reportBtn_Click(object sender, EventArgs e) //Creates a PDF with the details of the order selected 
        {
            if (idCbx.Text != "")
            {
                string arrived, disc;
                string[] idSplit = idCbx.Text.Split('-');
                Order order = AccessClasses.OrderAccess.GetOrderById(idSplit[0]);
                PdfMaker pdf = new PdfMaker();

                if (order.OrderArrived)
                {
                    arrived = "ARRIVED";
                }
                else
                {
                    arrived = "NOT ARRIVED";
                }

                if (order.Discrepancies == "")
                {
                    disc = "None";
                }
                else
                {
                    disc = order.Discrepancies.Replace("DISCREPANCIES REPORTED", "");
                }
                pdf.CreateOrderPdf(orderManageDgv, "Order", order.TotalCost, order.DateOrdered.ToString("dd-MM-yyyy"), disc, arrived);
            }
            else MessageBox.Show("Please select an order", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
