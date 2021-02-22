///using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
//using System.Text;

namespace Com.MrIT.DBEntities.Entities
{
    [Table ("menu_category")]
    public class MenuCategory : GenericEntity
    {
        public string Name { get; set; }

        public ICollection<MenuType> MenuTypes { get; set; }
    }
}
