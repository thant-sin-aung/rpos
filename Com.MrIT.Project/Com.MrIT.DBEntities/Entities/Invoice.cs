using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Com.MrIT.DBEntities.Entities
{
    [Table("invoice")]
    public class Invoice:GenericEntity
    {
        public DateTime SaleOn { get;set }
        public decimal SubTotal { get; set; }
        public decimal Tax { get; set; }
        public decimal ServiceCharges { get; set; }
        public decimal TableCharges { get; set; }
        public decimal Total { get; set; }
        public string Status { get; set; }

        public ICollection<Payment> Payments { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<InvoicePartialPayment> InvoicePartialPayments { get; set; }

        [ForeignKey("TableItemID")]
        public virtual TableItem TableItem { get; set; }

        [ForeignKey("SysUserID")]
        public virtual SysUser SysUser { get; set; }
    }
}
