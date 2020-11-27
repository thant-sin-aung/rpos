using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Com.MrIT.DBEntities.Entities
{
    [Table("table_item")]
    public class TableItem:GenericEntity
    {
        public string TableNumber { get; set; }
        public string Type { get; set; }
        public decimal Charges { get; set; }

        public ICollection<TableStatus> TableStatuses { get; set; }
        public ICollection<Invoice> Invoices { get; set; }

        [ForeignKey("TableAreaID")]
        public virtual TableArea TableArea { get; set; }
    }
}
