//using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
//using System.Text;

namespace Com.MrIT.ViewModels
{
    public class VmMenuCategory : ViewModelItemBase
    {
        [Display (Name = "Menu Category")]
        public string Name { get; set; }

        public List<VmMenuType> MenuTypes { get; set; }
    }
}
