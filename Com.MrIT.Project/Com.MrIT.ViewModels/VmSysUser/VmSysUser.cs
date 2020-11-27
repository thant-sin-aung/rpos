using System;
using System.Collections.Generic;
using System.Text;

namespace Com.MrIT.ViewModels
{
    public class VmSysUser:ViewModelItemBase
    {
        public string FullName { get; set; }
        public int PinCode { get; set; }
        public string Role { get; set; }
        public List<VmInvoice> Invoices { get; set; }
    }
}
