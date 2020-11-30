using System;
using System.Collections.Generic;
using System.Text;

namespace Com.MrIT.ViewModels
{
    public class VmMaterialCategory : ViewModelItemBase
    {
        public string Name { get; set; }

        public List<VmMaterialItem> MaterialItem { get; set; }
    }
}
