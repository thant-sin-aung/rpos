using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Com.MrIT.DBEntities.Entities
{
    [Table ("menu_item_portion")]
    public class MenuItemPortion : GenericEntity
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public ICollection<MenuItemMaterial> MenuItemMaterials { get; set; }

        [ForeignKey ("menu_item_ID")]
        public virtual MenuItem MenuItem{ get; set; }
    }
}
