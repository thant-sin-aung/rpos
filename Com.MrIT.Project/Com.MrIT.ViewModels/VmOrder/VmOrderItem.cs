using System;
using System.Collections.Generic;
using System.Text;

namespace Com.MrIT.ViewModels.VmTable
{
    class VmOrderItem:ViewModelItemBase
    {
        public string ItemName { get; set; }
        public decimal Qty { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public string Note { get; set; }
        public string Status { get; set; }
        public bool IsGift { get; set; }

        public List<VmOrderItemMaterial> OrderItemMaterials { get; set; }
        
    }
}
