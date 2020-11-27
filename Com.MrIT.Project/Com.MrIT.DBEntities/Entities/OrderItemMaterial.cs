using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Com.MrIT.DBEntities.Entities
{
    [Table("order_item_material")]
    public class OrderItemMaterial:GenericEntity
    {
        public decimal Qty { get; set; }
        

        [ForeignKey("MaterialItemID")]
        public virtual MaterialItem MaterialItem { get; set; }

        [ForeignKey("MaterialUOMID")]
        public virtual MaterialUOM MaterialUOM { get; set; }

        [ForeignKey("OrderItemID")]
        public virtual OrderItem OrderItem { get; set; }
    }
}
