using System;
using System.Collections.Generic;
using System.Text;

namespace Com.MrIT.ViewModels.VmTable
{
    class VmInvoice:ViewModelItemBase
    {
        public DateTime SaleOn { get; set }
        public decimal SubTotal { get; set; }
        public decimal Tax { get; set; }
        public decimal ServiceCharges { get; set; }
        public decimal TableCharges { get; set; }
        public decimal Total { get; set; }
        public string Status { get; set; }

        public List<VmPayment> Payments { get; set; }
        public List<VmOrder> Orders { get; set; }
        public List<VmInvoicePartialPayment> InvoicePartialPayments { get; set; }
    }
}
