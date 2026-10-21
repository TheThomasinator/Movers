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
    public partial class ItemAED : Form
    {
        string id;
        int digitCheck;

        public ItemAED()
        {
            InitializeComponent();            
            editIdCbx.Items.Add("");
            deleteIdCbx.Items.Add("");
            List<Stock> stock = AccessClasses.StockAccess.GetAllStock();
            foreach (Stock s in stock) //Populates the Id combo boxes with the Ids of all items of stock
            {
                editIdCbx.Items.Add(s.StockID + "-" + s.StockName);
                deleteIdCbx.Items.Add(s.StockID + "-" + s.StockName);
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void mainMenuBtn_Click(object sender, EventArgs e)
        {
            StockMenu stock = new StockMenu();
            this.Hide();
            stock.Show();
        }


        private void editIdCbx_SelectedIndexChanged(object sender, EventArgs e) //Populates the boxes on the edit tab with the details of the selected item of stock
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
                    else
                    {
                        break;
                    }
                }
                id = id.Substring(0, digitCheck);

                Stock stock = AccessClasses.StockAccess.GetStockById(id);
                editSNameTxt.Text = stock.StockName;
                editPriceTxt.Text = stock.Price.ToString();
                editQuantTxt.Text = stock.QuantInStock.ToString();
            }
        }
        private void deleteIdCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (deleteIdCbx.SelectedItem.ToString() != "")  //Populates the boxes on the delete tab with the details of the selected item of stock
            {
                id = deleteIdCbx.SelectedItem.ToString();
                digitCheck = 0;
                foreach (char c in id)
                {
                    if (char.IsDigit(c))
                    {
                        digitCheck++;
                    }
                    else
                    {
                        break;
                    }
                }
                id = id.Substring(0, digitCheck);

                Stock stock = AccessClasses.StockAccess.GetStockById(id);               
                deleteSNameTxt.Text = stock.StockName;
                deletePriceTxt.Text = stock.Price.ToString();
                deleteQuantTxt.Text = stock.QuantInStock.ToString();
            }
        }

        private void addBtn_Click(object sender, EventArgs e) //Adds an item of stock to the system with the details entered by the user if they meet the validation requirements
        {
            if (Validation(addSNameTxt.Text, addPriceTxt.Text, addQuantTxt.Text))
            {
                Stock myStock = new Stock(0, addSNameTxt.Text, decimal.Parse(addPriceTxt.Text), Int32.Parse(addQuantTxt.Text));
                double[] rows = AccessClasses.StockAccess.AddStock(myStock);

                if (rows[0] == 1)
                {
                    MessageBox.Show("Stock has been successfully added to the database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    editIdCbx.Items.Clear();
                    deleteIdCbx.Items.Clear();

                    editIdCbx.Items.Add("");
                    deleteIdCbx.Items.Add("");
                    List<Stock> stock = AccessClasses.StockAccess.GetAllStock();
                    foreach (Stock s in stock) //Updates the id boxes with the new item of stock
                    {
                        editIdCbx.Items.Add(s.StockID + "-" + s.StockName);
                        deleteIdCbx.Items.Add(s.StockID + "-" + s.StockName);
                    }

                    foreach (Control co in this.addTab.Controls)
                    {
                        if (co is TextBox)
                        {
                            co.Text = "";
                        }                        
                    }
                }
                else
                {
                    MessageBox.Show("Stock has not been added to the database.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void editBtn_Click(object sender, EventArgs e) //Edits an item of stock in the system with the details entered by the user if they meet the validation requirements
        {
            if (editIdCbx.Text != "")
            {
                if (Validation(editSNameTxt.Text, editPriceTxt.Text, editQuantTxt.Text))
                {
                    id = editIdCbx.SelectedItem.ToString();
                    digitCheck = 0; 
                    foreach (char c in id) //Checks for where the digits end so that it can be substringed for the id only
                    {
                        if (char.IsDigit(c))
                        {
                            digitCheck++;
                        }
                        else
                        {
                            break;
                        }

                    }
                    id = id.Substring(0, digitCheck);

                    int result = 0;
                    Stock myStock = new Stock(Int32.Parse(id), editSNameTxt.Text, decimal.Parse(editPriceTxt.Text), Int32.Parse(editQuantTxt.Text));
                    result = AccessClasses.StockAccess.EditStock(myStock);

                    if (result == 1)
                    {
                        MessageBox.Show("Item has been successfully updated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        editIdCbx.Items.Clear();
                        deleteIdCbx.Items.Clear();

                        editIdCbx.Items.Add("");
                        deleteIdCbx.Items.Add("");
                        List<Stock> stock = AccessClasses.StockAccess.GetAllStock();
                        foreach (Stock s in stock) //Updates the id boxes with the edited item of stock
                        {
                            editIdCbx.Items.Add(s.StockID + "-" + s.StockName);
                            deleteIdCbx.Items.Add(s.StockID + "-" + s.StockName);
                        }

                        foreach (Control co in this.editTab.Controls) 
                        {
                            if (co is TextBox)
                            {
                                co.Text = "";
                            }
                        }

                        editIdCbx.SelectedIndex = 0;
                    }
                    else
                    {
                        MessageBox.Show("Item has not been updated.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e) //Deletes a selected item of stock from the system that the user selected
        {
            if (deleteIdCbx.Text != "")
            {
                id = deleteIdCbx.SelectedItem.ToString();
                digitCheck = 0; 
                foreach (char c in id) //Checks for where the digits end so that it can be substringed for the id only
                {
                    if (char.IsDigit(c))
                    {
                        digitCheck++;
                    }
                    else
                    {
                        break;
                    }
                }
                id = id.Substring(0, digitCheck);

                Stock myStock = new Stock(Int32.Parse(id), deleteSNameTxt.Text, Convert.ToDecimal(deletePriceTxt.Text), Int32.Parse(deleteQuantTxt.Text));

                int result = AccessClasses.StockAccess.DeleteStock(myStock.StockID);

                if (result == 1)
                {
                    MessageBox.Show("Item has been successfully deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    editIdCbx.Items.Clear();
                    deleteIdCbx.Items.Clear();

                    editIdCbx.Items.Add("");
                    deleteIdCbx.Items.Add("");
                    List<Stock> stock = AccessClasses.StockAccess.GetAllStock();
                    foreach (Stock s in stock) //Updates the id boxes with the removed items of stock
                    {
                        editIdCbx.Items.Add(s.StockID + "-" + s.StockName);
                        deleteIdCbx.Items.Add(s.StockID + "-" + s.StockName);
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
                    MessageBox.Show("Item has not been deleted from the database.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private bool Validation(string sName, string price, string quant) //Checks to see if the entered details meet the required validation
        {
            decimal decPrice;
            int intQuant;
            if (sName != "" && price != "" && quant != "") //Checks for blank boxes
            {
                if (decimal.TryParse(price, out decPrice)) //Checks to see if price is a number
                {
                    for (int i = 0; i < price.Length; i++)
                    {
                        if(price[i] == '.') 
                        {
                            if (price.Substring(0, i) == price.Substring(0, price.Length - 3)) //Checks to see if there is only 2 decimal places after the . in the price
                            {
                                if (Int32.TryParse(quant, out intQuant) && intQuant >= 0) //Checks to see if quantity is a number
                                {
                                    return true;
                                }
                                else MessageBox.Show("Quantity should be an integer 0 or above!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else MessageBox.Show("Price should be a decimal of format 00.00!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else MessageBox.Show("Price should be a decimal of format 00.00!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else MessageBox.Show("Do not leave any fields blank!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
    }
}
