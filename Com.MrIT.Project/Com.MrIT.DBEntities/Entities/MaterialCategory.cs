using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Com.MrIT.DBEntities.Entities
{
    [Table ("material_category")]
    public class MaterialCategory : GenericEntity
    {
        public string Name { get; set; }

        public ICollection<MaterialItem> MaterialItems { get; set; }
    }
}
