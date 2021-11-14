using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderOrganizer_Capstone.Objects;
using DatabaseLib;

namespace OrderOrganizer_Capstone.Objects
{
    public class OrderManager
    {
        public event EventHandler OrderAdded;

        private OO_dbEntities dbcontext;

        public OrderManager(OO_dbEntities _dbcontext)
        {
            dbcontext = _dbcontext;
        }

        public void AddOrderToDB(object _, OrderEventArgs oeArgs)
        {
            dbcontext.orders.Add(oeArgs.Order);
            dbcontext.SaveChanges();

            OrderAdded(this, EventArgs.Empty);
        }

        public void RemovePayInfo(object _, OrderEventArgs oeArgs)
        {
            dbcontext.payments.Remove(oeArgs.Order.payment);
            dbcontext.SaveChanges();
        }

        public void UpdateOrder(object _, OrderEventArgs oeArgs)
        {
            var targetOrder = dbcontext.orders.Where(o => o.order_id == oeArgs.Order.order_id).FirstOrDefault();
            if (targetOrder != null)
            {
                targetOrder.raw_text = oeArgs.Order.raw_text;
                targetOrder.status = dbcontext.statuses.Where(s => s.status_id == oeArgs.Order.order_status).First();
                dbcontext.SaveChanges();
            }
        }
    }
}
