using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Com.MrIT.DBEntities.Entities
{
    [Table ("menu_item_material")]
    public class MenuItemMaterial : GenericEntity
    {
        public decimal Qty { get; set; }

        [ForeignKey ("material_item_ID")]
        public virtual MaterialItem MaterialItem { get; set; }

        [ForeignKey ("material_uom_ID")]
        public virtual MaterialUOM MaterialUOM { get; set; }

        [ForeignKey ("menu_item_portion_ID")]
        public virtual MenuItemPortion MenuItemPortion { get; set; }
    }
}
