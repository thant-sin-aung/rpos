using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Com.MrIT.DBEntities.Entities
{
    [Table ("material_uom")]
    public class MaterialUOM : GenericEntity
    {
        public string Name { get; set; }

        public ICollection<MenuItemMaterial> MenuItemMaterials { get; set; }
        public ICollection<OrderItemMaterial> OrderItemMaterials { get; set; }
    }
}
