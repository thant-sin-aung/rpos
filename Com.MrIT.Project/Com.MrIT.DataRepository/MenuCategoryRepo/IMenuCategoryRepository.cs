using Com.MrIT.DBEntities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.MrIT.DataRepository
{
    public interface IMenuCategoryRepository : IGenericRepository<MenuCategory>
    {
        MenuCategory GetMenuCategory(int id);
    }
}
