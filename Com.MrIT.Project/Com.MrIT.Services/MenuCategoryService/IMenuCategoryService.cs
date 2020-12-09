using Com.MrIT.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.MrIT.Services
{
    public interface IMenuCategoryService
    {
        VmGenericServiceResult CreateMenuCategory(VmMenuCategory menuCategory);
    }
}
