using System;
using System.Collections.Generic;
using System.Text;

namespace Com.MrIT.ViewModels
{
    public class VmTableItem:ViewModelItemBase
    {
        public string TableNumber { get; set; }
        public string Type { get; set; }
        public decimal Charges { get; set; }

        public List<VmTableStatus> TableStatuses { get; set; }
        public List<VmInvoice> Invoices { get; set; }
    }
}
