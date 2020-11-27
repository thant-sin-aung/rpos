using System;
using System.Collections.Generic;
using System.Text;

namespace Com.MrIT.ViewModels
{
    class VmPaymentMethod:ViewModelItemBase
    {
        public string Name { get; set; }
        public bool NeedTransactionID { get; set; }

        public List<VmPayment> Payments { get; set; }
    }
}
