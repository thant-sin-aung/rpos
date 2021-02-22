using Com.MrIT.DBEntities;
using Com.MrIT.DBEntities.Entities;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Com.MrIT.DataRepository
{
    public class MenuCategoryRepository : GenericRepository<MenuCategory>, IMenuCategoryRepository
    {
        public MenuCategoryRepository(DataContext context, ILoggerFactory loggerFactory) :
        base(context, loggerFactory, "MenuCategoryRepository")
        {

        }

        public MenuCategory GetMenuCategory(int id)
        {
            var record = this.entities.Where(e => e.ID == id).SingleOrDefault();
            return record;
        }
    }
}
