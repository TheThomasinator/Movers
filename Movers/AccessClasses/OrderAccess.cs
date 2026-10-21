using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Movers.AccessClasses
{
    class OrderAccess
    {
        private static string cString = ConfigurationManager.ConnectionStrings["MoversDatabase"].ConnectionString;

        public static List<Order> GetAllOrders()
        {
            using (SqlConnection myCon = new SqlConnection(cString))
            {
                List<Order> myOrder = new List<Order>();
                myCon.Open();
                string myQuery = string.Format("Select * FROM \"ORDER\"");
                SqlCommand myCommand = new SqlCommand(myQuery, myCon);
                SqlDataReader myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    myOrder.Add(GetOrderFromReader(myReader));
                }

                myCon.Close();
                return myOrder;
            }
        }

        public static Order GetOrderById(string id)
        {
            using (SqlConnection myCon = new SqlConnection(cString))
            {
                Order myOrder = new Order();
                myCon.Open();
                string myQuery = string.Format("Select * FROM \"ORDER\" WHERE orderID = " + id);
                SqlCommand myCommand = new SqlCommand(myQuery, myCon);
                SqlDataReader myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    myOrder = GetOrderFromReader(myReader);
                }

                myCon.Close();
                return myOrder;
            }
        }

        public static Order GetOrderFromReader(SqlDataReader reader)
        {
            Order order = new Order();

            order.OrderId = (int)reader[0];
            order.DateOrdered = (DateTime)reader[1];
            order.OrderArrived = (bool)reader[2];
            order.TotalCost = (decimal)reader[3];
            order.Discrepancies = (string)reader[4];

            return order;
        }

        public static double[] AddOrder(Order or, List<Stock> stock)
        {
            using (SqlConnection myCon = new SqlConnection(cString))
            {
                double[] rows = { 0, 0 };
                myCon.Open();

                string myQuery = string.Format("INSERT INTO \"ORDER\" VALUES ('{0}', 0, {1}, '{2}' )", or.DateOrdered, or.TotalCost, or.Discrepancies);
                SqlCommand myCom = new SqlCommand(myQuery, myCon);
                rows[0] = myCom.ExecuteNonQuery();

                string myQuery2 = string.Format("SELECT SCOPE_IDENTITY()");
                SqlCommand myCom2 = new SqlCommand(myQuery2, myCon);
                rows[1] = (double)(decimal)myCom2.ExecuteScalar();

                foreach(Stock s in stock)
                {
                    StockToOrder((int)rows[1], s.StockID, s.QuantInStock);
                }

                myCon.Close();
                return rows;
            }
        }

        public static int OrderDiscrepancies(string id, string disc)
        {
            using (SqlConnection myCon = new SqlConnection(cString))
            {
                int rowsAffected = 0;
                myCon.Open();
                string myQuery = string.Format("UPDATE \"ORDER\" SET discrepancies = '{0}' WHERE orderID = {1}", disc, id);
                SqlCommand myCommand = new SqlCommand(myQuery, myCon);
                rowsAffected = myCommand.ExecuteNonQuery();
                myCon.Close();
                return rowsAffected;
            }
        }

        public static int ConfirmOrderArrived(string id)
        {
            using (SqlConnection myCon = new SqlConnection(cString))
            {
                int rowsAffected = 0;
                myCon.Open();
                string myQuery = string.Format("UPDATE \"ORDER\" SET orderArrived = 1 WHERE orderID = {0}", id);
                SqlCommand myCommand = new SqlCommand(myQuery, myCon);
                rowsAffected = myCommand.ExecuteNonQuery();
                myCon.Close();
                return rowsAffected;
            }
        }

        public static void StockToOrder(int oId, int sId, int quant)
        {
            using (SqlConnection myCon = new SqlConnection(cString))
            {
                myCon.Open();

                string myQuery = string.Format("INSERT INTO STOCK_ORDER VALUES ('{0}', '{1}', '{2}')", sId, oId, quant);
                SqlCommand myCom = new SqlCommand(myQuery, myCon);
                myCom.ExecuteReader();
                myCon.Close();
            }
        }

        public static List<Stock> GetStockOnOrder(string id)
        {
            using (SqlConnection myCon = new SqlConnection(cString))
            {
                List<Stock> Stock = new List<Stock>();
                myCon.Open();
                string myQuery = string.Format("Select * FROM STOCK " +
                    "INNER JOIN STOCK_ORDER " +
                    "ON STOCK_ORDER.stockId = STOCK.stockId " +
                    "WHERE STOCK_ORDER.orderId = {0}", id);
                SqlCommand myCommand = new SqlCommand(myQuery, myCon);
                SqlDataReader myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    Stock.Add(AccessClasses.StockAccess.GetStockFromReader(myReader));
                }

                myCon.Close();
                return Stock;
            }
        }

        public static int QuantOfStock(string stockId, string orderId)
        {
            using (SqlConnection myCon = new SqlConnection(cString))
            {
                int quant = 0;
                myCon.Open();
                string myQuery = string.Format("Select quantityOrdered FROM STOCK_ORDER WHERE stockID = {0} AND orderID = {1} ", stockId, orderId);
                SqlCommand myCommand = new SqlCommand(myQuery, myCon);
                SqlDataReader myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    quant = (int)myReader[0];
                }

                myCon.Close();
                return quant;
            }
        }
    }
}
