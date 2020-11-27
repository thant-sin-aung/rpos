using System;
using System.Collections.Generic;
using System.Text;

namespace Com.MrIT.ViewModels.VmTable
{
    public class VmOrder:ViewModelItemBase
    {
        public DateTime SubmittedOn { get; set }

        public string Status { get; set; }
        public List<VmOrderItem> OrderItems { get; set; }
    }
}
