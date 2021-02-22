using Com.MrIT.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.MrIT.Services
{
    public interface IMenuCategoryService
    {
        VmGenericServiceResult CreateMenuCategory(VmMenuCategory menuCategory);
        
        VmGenericServiceResult UpdateMenuCategory(VmMenuCategory menuCategory);

        VmGenericServiceResult DeleteMenuCategory(int id);

        List<VmMenuCategory> GetAllMenuCategories();

        VmMenuCategory GetMenuCategory(int id);
    }
}
