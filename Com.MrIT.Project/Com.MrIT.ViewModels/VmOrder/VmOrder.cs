using System;
using System.Collections.Generic;
using System.Text;

namespace Com.MrIT.ViewModels
{
    public class VmOrder:ViewModelItemBase
    {
        public DateTime SubmittedOn { get; set; }

        public string Status { get; set; }
        public List<VmOrderItem> OrderItemList { get; set; }
    }
}
