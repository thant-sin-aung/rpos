using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Com.MrIT.DBEntities.Entities
{
    [Table("table_area")]
    public class TableArea:GenericEntity
    {
        public string Name { get; set; }
        public ICollection<TableItem> TableItems { get; set; }
    }
}
