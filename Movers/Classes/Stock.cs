using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movers
{
    public class Stock
    {
        int stockID, quantInStock;
        string stockName;
        decimal price;

        public Stock()
        {

        }

        public Stock(int sID, string sName, decimal price, int quant)
        {
            StockID = sID;
            StockName = sName;
            Price = price;
            QuantInStock = quant;
        }

        public int StockID
        {
            get { return stockID; }
            set { stockID = value; }
        }

        public string StockName
        {
            get { return stockName; }
            set { stockName = value; }
        }

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        public int QuantInStock
        {
            get { return quantInStock; }
            set { quantInStock = value; }
        }
    }
}
