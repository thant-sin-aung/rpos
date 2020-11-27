using System;
using System.Collections.Generic;
using System.Text;

namespace Com.MrIT.ViewModels.VmTable
{
    public class VmTableArea:ViewModelItemBase
    {
        public string Name { get; set; }
        public List<VmTableItem> TableItems { get; set; }
    }
}
