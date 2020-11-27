using Com.MrIT.DBEntities;
using Com.MrIT.DBEntities.Entities;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.MrIT.DataRepository
{
    public class TableAreaRepository : GenericRepository<TableArea> , ITableAreaRepository
    {
        public TableAreaRepository(DataContext context, ILoggerFactory loggerFactory) :
        base(context, loggerFactory, "TableAreaRepository")
        {

        }
    }
}
