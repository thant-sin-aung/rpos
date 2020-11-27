using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Com.MrIT.DBEntities.Entities
{
    [Table("payment_method")]
    public class PaymentMethod:GenericEntity
    {
        public string Name { get; set; }
        public bool NeedTransactionID { get; set; }

        public ICollection<Payment> Payments { get; set; }
    }
}
