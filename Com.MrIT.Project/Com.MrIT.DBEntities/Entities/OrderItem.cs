using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Com.MrIT.DBEntities.Entities
{
    [Table("order_item")]
    public class OrderItem:GenericEntity
    {
        public string ItemName { get; set; }
        public decimal Qty { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public string Note { get; set;}
        public string Status { get; set; }
        public bool IsGift { get; set; }

        public ICollection<OrderItemMaterial> OrderItemMaterials { get; set; }

        [ForeignKey("MenuItemPortionID")]
        public virtual MenuItemPortion MenuItemPortion { get; set; }

        [ForeignKey("OrderID")]
        public virtual Order Order { get; set; }
    }
}
