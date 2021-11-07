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
    }
}
