using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Com.MrIT.DBEntities.Entities
{
    [Table ("menu_item")]
    public class MenuItem : GenericEntity
    {
        public string Name { get; set; }

        public string FeaturedImage { get; set; }

        [ForeignKey ("menu_category_ID")]
        public virtual MenuCategory MenuCategory { get; set; }

        [ForeignKey ("menu_type_ID")]
        public virtual MenuType MenuType { get; set; }

        public ICollection<MenuItemPortion> MenuItemPortions { get; set; }
    }
}
