using Com.MrIT.DBEntities;
using Com.MrIT.DBEntities.Entities;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.MrIT.DataRepository
{
    public class OrderRepository : GenericRepository<Order> , IOrderRepository
    {
        public OrderRepository(DataContext context, ILoggerFactory loggerFactory) :
        base(context, loggerFactory, "OrderRepository")
        {

        }
    }
}
