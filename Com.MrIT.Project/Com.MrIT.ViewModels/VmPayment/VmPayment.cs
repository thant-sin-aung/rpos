using System;
using System.Collections.Generic;
using System.Text;

namespace Com.MrIT.ViewModels
{
    public class VmPayment:ViewModelItemBase
    {
        public string Method { get; set; }
        public decimal Amount { get; set; }
        public string TransactionID { get; set; }
        public string Status { get; set; }
    }
}
