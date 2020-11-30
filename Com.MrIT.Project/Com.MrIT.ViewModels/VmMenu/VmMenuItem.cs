using System;
using System.Collections.Generic;
using System.Text;

namespace Com.MrIT.ViewModels
{
    public class VmMenuItem : ViewModelItemBase
    {
        public string Name { get; set; }

        public string FeaturedImage { get; set; }
        public VmMenuCategory MenuCategory { get; set; }
        public VmMenuType MenuType { get; set; }

        public List<VmMenuItemPortion> MenuItemPortion { get; set; }
    }
}
