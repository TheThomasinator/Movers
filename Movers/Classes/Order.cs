using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movers
{
    class Order
    {
        int orderId;
        DateTime dateOrdered;
        bool orderArrived;
        decimal totalCost;
        string discrepancies;

        public Order()
        {

        }

        public Order(int id, DateTime date, bool arrived, decimal cost, string disc)
        {
            OrderId = id;
            DateOrdered = date;
            OrderArrived = arrived;
            TotalCost = cost;
        }

        public int OrderId
        {
            get { return orderId; }
            set { orderId = value; }
        }

        public DateTime DateOrdered
        {
            get { return dateOrdered; }
            set { dateOrdered = value; }
        }

        public bool OrderArrived
        {
            get { return orderArrived; }
            set { orderArrived = value; }
        }

        public decimal TotalCost
        {
            get { return totalCost; }
            set { totalCost = value; }
        }

        public string Discrepancies
        {
            get { return discrepancies; }
            set { discrepancies = value; }
        }
    }
}
