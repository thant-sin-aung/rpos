using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Com.MrIT.DBEntities.Entities
{
    [Table("invoice_partial_payment")]
    public class InvoicePartialPayment:GenericEntity
    {
        public decimal Qty { get; set; }
        public decimal Total { get; set; }
        

        [ForeignKey("MenuItemPortionID")]
        public virtual MenuItemPortion MenuItemPortion { get; set; }

        [ForeignKey("InvoiceID")]
        public virtual Invoice Invoice { get; set; }

    }
}
