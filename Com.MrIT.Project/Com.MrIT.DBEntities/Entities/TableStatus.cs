using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Com.MrIT.DBEntities.Entities
{
    [Table("table_status")]
    public class TableStatus:GenericEntity
    {
        public string Status { get;set }

        [ForeignKey("TableItemID")]
        public virtual TableItem TableItem { get; set; }
    }
}
