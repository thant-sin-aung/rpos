using System;
using System.Collections.Generic;
using System.Text;

namespace Com.MrIT.ViewModels
{
    public class VmMenuItemMaterial : ViewModelItemBase
    {
        public decimal Qty { get; set; }
        public VmMaterialItem MaterialItem { get; set; }
        public VmMaterialUOM MaterialUOM { get; set; }
        public VmMenuItemPortion MenuItemPortion { get; set; }
    }
}
