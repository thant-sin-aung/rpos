using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Com.MrIT.DBEntities.Entities
{
    [Table("order")]
    public class Order:GenericEntity
    {
        public DateTime SubmittedOn { get;set }

        public string Status { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; }

        [ForeignKey("InvoiceID")]
        public virtual Invoice Invoice { get; set; }
    }
}
