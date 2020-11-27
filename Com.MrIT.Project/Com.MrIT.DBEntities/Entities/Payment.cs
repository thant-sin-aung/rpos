using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Com.MrIT.DBEntities.Entities
{
    [Table("payment")]
    public class Payment:GenericEntity
    {
        public string Method { get; set; }
        public decimal Amount { get; set;}
        public string TransactionID { get; set; }
        public string Status { get; set; }

        [ForeignKey("InvoiceID")]
        public virtual Invoice Invoice { get; set; }

        [ForeignKey("PaymentMethodID")]
        public virtual PaymentMethod PaymentMethod { get; set; }
    }
}
