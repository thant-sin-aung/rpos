using System;
using System.Collections.Generic;
using System.Text;

namespace Com.MrIT.ViewModels
{
    public class VmMaterialItem : ViewModelItemBase
    {
        public string Name { get; set; }

        public VmMaterialCategory MaterialCategory { get; set; }
    }
}
