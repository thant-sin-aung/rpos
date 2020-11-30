using System;
using System.Collections.Generic;
using System.Text;

namespace Com.MrIT.ViewModels
{
    public class VmMaterialUOM : ViewModelItemBase
    {
        public string Name { get; set; }

        public List<VmMenuItemMaterial> MenuItemMaterial { get; set; }
        public List<VmOrderItemMaterial> OrderItemMaterial { get; set; }
    }
}
