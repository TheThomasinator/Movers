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
    public class StockAccess
    {
        private static string cString = ConfigurationManager.ConnectionStrings["MoversDatabase"].ConnectionString;

        public static List<Stock> GetAllStock()
        {
            using (SqlConnection myCon = new SqlConnection(cString))
            {
                List<Stock> myStock = new List<Stock>();
                myCon.Open();
                string myQuery = string.Format("Select * FROM STOCK");
                SqlCommand myCommand = new SqlCommand(myQuery, myCon);
                SqlDataReader myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    myStock.Add(GetStockFromReader(myReader));
                }

                myCon.Close();
                return myStock;
            }
        }

        public static Stock GetStockById(string id)
        {
            using (SqlConnection myCon = new SqlConnection(cString))
            {
                Stock myStock = new Stock();
                myCon.Open();
                string myQuery = string.Format("Select * FROM STOCK WHERE stockID = " + id);
                SqlCommand myCommand = new SqlCommand(myQuery, myCon);
                SqlDataReader myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    myStock = GetStockFromReader(myReader);
                }

                myCon.Close();
                return myStock;
            }
        }

        public static Stock GetStockFromReader(SqlDataReader reader)
        {
            Stock stock = new Stock();

            stock.StockID = (int)reader[0];
            stock.StockName = (string)reader[1];
            stock.Price = (decimal)reader[2];
            stock.QuantInStock = (int)reader[3];

            return stock;
        }

        public static double[] AddStock(Stock st)
        {
            using (SqlConnection myCon = new SqlConnection(cString))
            {
                double[] rows = { 0, 0 };
                myCon.Open();

                string myQuery = string.Format("INSERT INTO STOCK VALUES ('{0}', '{1}', '{2}')", st.StockName, st.Price, st.QuantInStock);
                SqlCommand myCom = new SqlCommand(myQuery, myCon);
                rows[0] = myCom.ExecuteNonQuery();

                string myQuery2 = string.Format("SELECT SCOPE_IDENTITY()");
                SqlCommand myCom2 = new SqlCommand(myQuery2, myCon);
                rows[1] = (double)(decimal)myCom2.ExecuteScalar();

                myCon.Close();
                return rows;
            }
        }

        public static int EditStock(Stock st)
        {
            using (SqlConnection myCon = new SqlConnection(cString))
            {
                int rowsAffected = 0;
                myCon.Open();
                decimal price = new decimal(2);
                price = st.Price;
                string myQuery = string.Format("UPDATE STOCK SET stockName = '{0}', price = '{1}', quantInStock = '{2}' WHERE stockID = " + st.StockID, st.StockName, price, st.QuantInStock);
                SqlCommand myCommand = new SqlCommand(myQuery, myCon);
                rowsAffected = myCommand.ExecuteNonQuery();
                myCon.Close();
                return rowsAffected;
            }
        }

        public static int DeleteStock(int id)
        {
            using (SqlConnection myCon = new SqlConnection(cString))
            {
                int rowsAffected = 0;
                myCon.Open();
                string myQuery = string.Format("DELETE FROM STOCK WHERE StockID = '{0}'", id);
                SqlCommand myCom = new SqlCommand(myQuery, myCon);
                rowsAffected = myCom.ExecuteNonQuery();
                myCon.Close();
                return rowsAffected;
            }
        }
    }
}
