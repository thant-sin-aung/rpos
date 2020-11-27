using System;
using System.Collections.Generic;
using System.Text;

namespace Com.MrIT.ViewModels.VmTable
{
    class VmInvoicePartialPayment:ViewModelItemBase
    {
        public decimal Qty { get; set; }
        public decimal Total { get; set; }
    }
}
