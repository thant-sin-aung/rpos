using Com.MrIT.DBEntities;
using Com.MrIT.DBEntities.Entities;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.MrIT.DataRepository
{
    public class PaymentMethodRepository : GenericRepository<PaymentMethod> , IPaymentMethodRepository
    {
        public PaymentMethodRepository(DataContext context, ILoggerFactory loggerFactory) :
        base(context, loggerFactory, "PaymentMethodRepository")
        {

        }
    }
}
