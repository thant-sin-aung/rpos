using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Com.MrIT.DBEntities.Entities
{
    [Table ("material_item")]
    public class MaterialItem : GenericEntity
    {
        public string Name { get; set; }

        [ForeignKey ("material_category_ID")]
        public virtual MaterialCategory MatrialCategory { get; set; }

        public ICollection<MenuItemMaterial> MenuItemMaterials { get; set; }
    }
}
