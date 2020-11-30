using System;
using System.Collections.Generic;
using System.Text;

namespace Com.MrIT.ViewModels
{
    public class VmMenuItemPortion : ViewModelItemBase
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public List<VmMenuItemMaterial> MenuItemMaterial { get; set; }
        public List<VmOrderItem> OrderItem { get; set; }
        public List<VmInvoicePartialPayment> InvoicePartialPayment { get; set; }

        public VmMenuItem MenuItem { get; set; }
    }
}
