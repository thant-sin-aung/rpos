using System;
using System.Collections.Generic;
using System.Text;

namespace Com.MrIT.ViewModels
{
    public class VmMenuType : ViewModelItemBase
    {
        public string Name { get; set; }

        public List<VmMenuType> MenuTypes { get; set; }
    }
}
